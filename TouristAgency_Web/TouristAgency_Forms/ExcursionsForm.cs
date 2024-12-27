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
using TouristAgency.Models;

namespace TouristAgency_Forms
{
    public partial class ExcursionsForm : Form
    {
        private int? selectedExcursionId;
        private readonly IUnitOfWork _unitOfWork;
        public ExcursionsForm(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            InitializeComponent();
            selectedExcursionId = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button_excursionsAdd_Click(object sender, EventArgs e)
        {
            string destinationCountry = textBox_excursionDestinationCountry.Text;
            string destinationCity = textBox_excursionDestinationCity.Text;

            if (selectedExcursionId == null)
            {
                if (!string.IsNullOrEmpty(destinationCountry) && !string.IsNullOrEmpty(destinationCity))
                {
                    Excursions excursion = new Excursions
                    {
                        Destination_Country = destinationCountry,
                        Destination_City = destinationCity,
                        BeginDate = DateOnly.FromDateTime(dateTimePicker_excursionBeginDate.Value),
                        EndDate = DateOnly.FromDateTime(dateTimePicker__excursionEndDate.Value),
                        Price_Transport = numericUpDown_excursionPriceTransport.Value,
                        Price_Excursion = numericUpDown_excursionPriceExcursion.Value,
                        Price_Additional = numericUpDown_excursionAdditionalPrice.Value,
                    };

                    await _unitOfWork.Excursions.CreateAsync(excursion);
                    await _unitOfWork.SaveAsync();

                    CleanFields();
                    LoadGridView();
                }
                else
                {
                    MessageBox.Show("Please enter correct information");
                }
            }
            if (selectedExcursionId != null)
            {
                if (!string.IsNullOrEmpty(destinationCountry) && !string.IsNullOrEmpty(destinationCity))
                {
                    var excursionToUpdate = await _unitOfWork.Excursions.GetAsync(e => e.ExcursionId == selectedExcursionId);

                    excursionToUpdate.Destination_Country = destinationCountry;
                    excursionToUpdate.Destination_City = destinationCity;
                    excursionToUpdate.BeginDate = DateOnly.FromDateTime(dateTimePicker_excursionBeginDate.Value);
                    excursionToUpdate.EndDate = DateOnly.FromDateTime(dateTimePicker__excursionEndDate.Value);
                    excursionToUpdate.Price_Transport = numericUpDown_excursionPriceTransport.Value;
                    excursionToUpdate.Price_Excursion = numericUpDown_excursionPriceExcursion.Value;
                    excursionToUpdate.Price_Additional = numericUpDown_excursionAdditionalPrice.Value;

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

        private async void LoadGridView()
        {
            var data = await _unitOfWork.Excursions.GetAllAsync();
            dataGridView_excursions.DataSource = data;
        }

        private void CleanFields()
        {
            textBox_excursionDestinationCountry.Text = "";
            textBox_excursionDestinationCity.Text = "";
            dateTimePicker_excursionBeginDate.Value = DateTime.Today;
            dateTimePicker__excursionEndDate.Value = DateTime.Today;
            numericUpDown_excursionPriceTransport.Value = 0m;
            numericUpDown_excursionPriceExcursion.Value = 0m;
            numericUpDown_excursionAdditionalPrice.Value = 0m;

            selectedExcursionId = null;
        }

        private void dataGridView_excursions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            if (e.RowIndex >= 0)
            {
                //var clickedRow = dgv.Rows[e.RowIndex];
                var clickedRow = dgv.CurrentRow;

                if (clickedRow != null)
                {
                    var clickedRecord = (Excursions)clickedRow.DataBoundItem;

                    textBox_excursionDestinationCountry.Text = clickedRecord.Destination_Country;
                    textBox_excursionDestinationCity.Text = clickedRecord.Destination_City;
                    dateTimePicker_excursionBeginDate.Value = clickedRecord.BeginDate.ToDateTime(TimeOnly.MinValue);
                    dateTimePicker__excursionEndDate.Value = clickedRecord.EndDate.ToDateTime(TimeOnly.MinValue);
                    numericUpDown_excursionPriceTransport.Value = clickedRecord.Price_Transport;
                    numericUpDown_excursionPriceExcursion.Value = clickedRecord.Price_Excursion;
                    numericUpDown_excursionAdditionalPrice.Value = clickedRecord.Price_Additional == null ? 0m : (decimal)clickedRecord.Price_Additional;

                    selectedExcursionId = clickedRecord.ExcursionId;
                }




            }
        }

        private void ExcursionsForm_Load(object sender, EventArgs e)
        {
            LoadGridView();
        }

        private void button_excursionsClean_Click(object sender, EventArgs e)
        {
            CleanFields();
        }

        private async void button_excursionsDelete_Click(object sender, EventArgs e)
        {

            if(selectedExcursionId == null) return;

            var confirmResult = MessageBox.Show(
               "Are you sure you want to delete this excursion?",
               "Confirm Delete",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.No) return;

            var toDelete = await _unitOfWork.Excursions.GetAsync(e => e.ExcursionId == selectedExcursionId);
            _unitOfWork.Excursions.Delete(toDelete);
            await _unitOfWork.SaveAsync();

            CleanFields();
            LoadGridView();
        }
    }
}
