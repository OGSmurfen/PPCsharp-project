using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TouristAgency.DataAccess.UOW;
using TouristAgency.Models.DTOs;

namespace TouristAgency_Forms
{
    public partial class LookupDestinationsForm : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        public LookupDestinationsForm(IUnitOfWork uow)
        {
            _unitOfWork = uow;
            InitializeComponent();
        }

        private async void button_destinationSearch_Click(object sender, EventArgs e)
        {
            string threeNames = textBox_clientThreeNames.Text;
            if (string.IsNullOrEmpty(threeNames)) return;


            List<DestinationLookupDto> data = await _unitOfWork.Excursions.DestinationsWithClientAndPrices(threeNames);

            dataGridView_lookupDestinations.DataSource = data;
        }
    }
}
