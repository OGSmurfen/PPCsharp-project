using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Metadata;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using TouristAgency.DataAccess.UOW;
using TouristAgency.Models.DTOs;


namespace TouristAgency_Forms
{
    public partial class ChartForm : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        private List<ClientsWithDestinationsForChartDto>? _data;
        public ChartForm(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            InitializeComponent();
            
        }


        private async void ChartForm_Load(object sender, EventArgs e)
        {
            List<ClientsWithDestinationsForChartDto> data = await _unitOfWork.Clients.GetClientsWithDestinations();
            _data = data;

            InitializeClientsDestinationsChart();
        }

        private async void InitializeClientsDestinationsChart()
        {
            if (_data == null || !_data.Any())
                return;

            //var allDestinations = await _unitOfWork.Excursions.GetAllAsync();
            //List<string> uniqueDestinationCities = allDestinations.Select(e => e.Destination_City).Distinct().ToList();

            //var allClients = await _unitOfWork.Clients.GetAllAsync();
            //List<string> allClientCountries = allClients.Select(c => c.Country).Distinct().ToList();

            List<ClientsWithDestinationsForChartDto> allData = await _unitOfWork.Clients.GetClientsWithDestinations();


            var groupedData = allData
               .GroupBy(d => new { d.ClientCountry, d.Destination_Country, d.Destination_City })
               .Select(g => new
               {
                   ClientCountry = g.Key.ClientCountry,
                   Destination = $"{g.Key.Destination_Country} - {g.Key.Destination_City}",
                   VisitCount = g.Count()
               })
               .OrderByDescending(g => g.VisitCount) 
               .ToList();

            var plotView = new OxyPlot.WindowsForms.PlotView
            {
                Dock = DockStyle.Fill
            };

            var plotModel = new PlotModel { Title = "Most Visited Destinations by Client Country" };

            var clientCountries = groupedData.Select(d => d.ClientCountry).Distinct().ToList();

            var categoryAxis = new CategoryAxis
            {
                Position = AxisPosition.Left,
                Title = "Destinations",
                ItemsSource = groupedData.Select(d => d.Destination).Distinct().ToList()
            };
            var valueAxis = new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Number of Visits",
                Minimum = 0
            };

            foreach (var country in clientCountries)
            {
                var series = new BarSeries
                {
                    Title = country,
                    ItemsSource = groupedData
                        .Where(d => d.ClientCountry == country)
                        .Select(d => new BarItem { Value = d.VisitCount })
                        .ToList(),
                    LabelPlacement = LabelPlacement.Inside
                };
                plotModel.Series.Add(series);
            }

            plotModel.Axes.Add(categoryAxis);
            plotModel.Axes.Add(valueAxis);


            plotView.Model = plotModel;

            this.Controls.Add(plotView);
        }

       
       
    }
}
