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
    public partial class LookupClients : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        public LookupClients(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            InitializeComponent();
        }

        private void LookupClients_Load(object sender, EventArgs e)
        {

        }

        private async void button_searchClients_Click(object sender, EventArgs e)
        {
            DateOnly beginDate = DateOnly.FromDateTime(dateTimePicker_beginDate.Value);
            DateOnly endDate = DateOnly.FromDateTime(dateTimePicker_endDate.Value);

            List<ClientWith_DestinationDTO> clientsData = await _unitOfWork.Clients.GetClientsByDateRange(beginDate, endDate);

            dataGridView_lookupClients.DataSource = clientsData;


        }
    }
}
