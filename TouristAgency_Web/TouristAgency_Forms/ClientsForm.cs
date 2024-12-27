using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TouristAgency.DataAccess.UOW;
using TouristAgency.Models;

namespace TouristAgency_Forms
{
    public partial class ClientsForm : Form
    {
        private Clients? selectedClient;
        private readonly IUnitOfWork _unitOfWork;
        public ClientsForm(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            InitializeComponent();
            selectedClient = null;
        }

        private async void button_clientAdd_Click(object sender, EventArgs e)
        {
            bool isValidEgn = int.TryParse(textBox_clientEGN.Text, out int egn);
            string threeNames = textBox_clientThreeNames.Text;
            string country = textBox_clientCountry.Text;
            string gender = textBox_clientGender.Text;

            // Create
            if (selectedClient == null)
            {

                if (isValidEgn && !string.IsNullOrEmpty(threeNames) &&
                    !string.IsNullOrEmpty(country) && !string.IsNullOrEmpty(gender))
                {
                    Clients client = new Clients
                    {
                        EGN = egn,
                        ThreeNames = threeNames,
                        Country = country,
                        Gender = gender,
                        BirthDate = DateOnly.FromDateTime(dateTimePicker_clientDOB.Value),
                        InsuranceNumber = DateOnly.FromDateTime(dateTimePicker_clientInsuranceNr.Value)
                    };

                    await _unitOfWork.Clients.CreateAsync(client);
                    await _unitOfWork.SaveAsync();

                    CleanFields();
                    LoadGridView();
                }
                else
                {
                    MessageBox.Show("Please enter correct information");
                }




            }
            // Update
            if (selectedClient != null)
            {
                if (isValidEgn && !string.IsNullOrEmpty(threeNames) &&
                    !string.IsNullOrEmpty(country) && !string.IsNullOrEmpty(gender))
                {
                    var clientToUpdate = await _unitOfWork.Clients.GetAsync(c => c.ClientId == selectedClient.ClientId);

                    if (clientToUpdate != null)
                    {
                        // Update properties of the existing client
                        clientToUpdate.EGN = egn;
                        clientToUpdate.ThreeNames = threeNames;
                        clientToUpdate.Country = country;
                        clientToUpdate.Gender = gender;
                        clientToUpdate.BirthDate = DateOnly.FromDateTime(dateTimePicker_clientDOB.Value);
                        clientToUpdate.InsuranceNumber = DateOnly.FromDateTime(dateTimePicker_clientInsuranceNr.Value);
                    }


                    //_unitOfWork.Clients.Update(client); we dont need to call that. EF Core tracks entity automatically
                    await _unitOfWork.SaveAsync();

                    CleanFields();
                    LoadGridView();
                }
                else
                {
                    MessageBox.Show("Please enter correct information");
                }
            }



        }

        private void dataGridView_Clients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            if (e.RowIndex >= 0)
            {
                //var clickedRow = dgv.Rows[e.RowIndex];
                var clickedRow = dgv.CurrentRow;

                if (clickedRow != null)
                {
                    var clickedRecord = (Clients)clickedRow.DataBoundItem;

                    textBox_clientEGN.Text = clickedRecord.EGN.ToString();
                    textBox_clientThreeNames.Text = clickedRecord.ThreeNames;
                    textBox_clientCountry.Text = clickedRecord.Country;
                    textBox_clientGender.Text = clickedRecord.Gender;
                    dateTimePicker_clientDOB.Value = clickedRecord.BirthDate.ToDateTime(TimeOnly.MinValue);
                    dateTimePicker_clientInsuranceNr.Value = clickedRecord.InsuranceNumber.ToDateTime(TimeOnly.MinValue);


                    selectedClient = new Clients
                    {
                        ClientId = clickedRecord.ClientId,
                        EGN = clickedRecord.EGN,
                        ThreeNames = clickedRecord.ThreeNames,
                        Country = clickedRecord.Country,
                        Gender = clickedRecord.Gender,
                        BirthDate = clickedRecord.BirthDate,
                        InsuranceNumber = clickedRecord.InsuranceNumber
                    };
                }




            }
        }


        private void ClientsForm_Load(object sender, EventArgs e)
        {
            LoadGridView();

        }
        private async void LoadGridView()
        {
            var clientsData = await _unitOfWork.Clients.GetAllAsync();
            dataGridView_Clients.DataSource = clientsData;
        }

        private void CleanFields()
        {
            textBox_clientEGN.Text = "";
            textBox_clientThreeNames.Text = "";
            textBox_clientCountry.Text = "";
            textBox_clientGender.Text = "";
            dateTimePicker_clientDOB.Value = DateTime.Today;
            dateTimePicker_clientInsuranceNr.Value = DateTime.Today;

            selectedClient = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CleanFields();
        }

        private async void button_clientsDelete_Click(object sender, EventArgs e)
        {
            if (selectedClient == null) return;

            var confirmResult = MessageBox.Show(
               "Are you sure you want to delete this client?",
               "Confirm Delete",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.No) return;



            var clientToDelete = await _unitOfWork.Clients.GetAsync(c => c.ClientId == selectedClient.ClientId);
            _unitOfWork.Clients.Delete(clientToDelete);
            await _unitOfWork.SaveAsync();

            CleanFields();
            LoadGridView();
        }

        private void textBox_clientEGN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
