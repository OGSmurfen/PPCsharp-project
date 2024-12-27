using Microsoft.Extensions.DependencyInjection;
using TouristAgency.DataAccess.UOW;

namespace TouristAgency_Forms
{
    public partial class HomeForm : Form
    {
        private readonly IServiceProvider _serviceProvider;

        public HomeForm(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Resolve ClientsForm from DI container
            var clientsForm = _serviceProvider.GetRequiredService<ClientsForm>();
            this.Hide();
            clientsForm.ShowDialog();
            this.Show();
        }

        private void open_orders_btn_Click(object sender, EventArgs e)
        {
            var ordersForm = _serviceProvider.GetService<OrdersForm>();
            this.Hide();
            ordersForm.ShowDialog();
            this.Show();
        }

        private void open_excursions_btn_Click(object sender, EventArgs e)
        {
            var excursionsForm = _serviceProvider.GetService<ExcursionsForm>();
            this.Hide();
            excursionsForm.ShowDialog();
            this.Show();
        }

        private void button_lookupClients_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetService<LookupClients>();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void button_lookupDestinations_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetService<LookupDestinationsForm>();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void button_chartShow_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetService<ChartForm>();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
