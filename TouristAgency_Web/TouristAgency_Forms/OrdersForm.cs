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
using TouristAgency.Models.DTOs;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TouristAgency_Forms
{
    public partial class OrdersForm : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        private int? selectedOrderId;
        private List<OrderWith_ClientExcursionDTO> _orders;

        public OrdersForm(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            InitializeComponent();
            selectedOrderId = 0;
        }

        private async void OrdersForm_Load(object sender, EventArgs e)
        {
            var clients = await _unitOfWork.Clients.GetAllAsync();
            var excursions = await _unitOfWork.Excursions.GetAllAsync();
            var orders = await _unitOfWork.Orders.GetAllAsync();

            comboBox_orderClientId.DataSource = clients;
            comboBox_orderClientId.ValueMember = nameof(Clients.ClientId);
            comboBox_orderClientId.DisplayMember = nameof(Clients.DisplayName);

            comboBox_orderExcursionId.DataSource = excursions;
            comboBox_orderExcursionId.ValueMember = nameof(Excursions.ExcursionId);
            comboBox_orderExcursionId.DisplayMember = nameof(Excursions.DisplayName);

            LoadGridViewNoFilter();
        }

        private void button_orderClear_Click(object sender, EventArgs e)
        {

        }

        private async void button_orderDelete_Click(object sender, EventArgs e)
        {
            if (selectedOrderId == null) return;

            var confirmResult = MessageBox.Show(
               $"Are you sure you want to delete order with Id: {selectedOrderId}",
               "Confirm Delete",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.No) return;



            var orderToDelete = await _unitOfWork.Orders.GetAsync(o => o.OrderId == selectedOrderId);
            _unitOfWork.Orders.Delete(orderToDelete);
            await _unitOfWork.SaveAsync();
            selectedOrderId = null;

            LoadGridViewNoFilter();
        }

        private async void LoadGridViewNoFilter()
        {
            var data = await _unitOfWork.Orders.GetOrdersWithClientsExcursionsAsync();
            _orders = data;

            dataGridView1.DataSource = _orders;
        }

        private async void button_orderAdd_Click(object sender, EventArgs e)
        {
            int clientId = Convert.ToInt32(comboBox_orderClientId.SelectedValue);
            int excursionId = Convert.ToInt32(comboBox_orderExcursionId.SelectedValue);
            if (int.IsPositive(clientId) && int.IsPositive(excursionId))
            {
                Orders order = new Orders
                {
                    ClientId = clientId,
                    ExcursionId = excursionId,
                    DateIssued = DateOnly.FromDateTime(dateTimePicker_orderDateIssued.Value)
                };

                await _unitOfWork.Orders.CreateAsync(order);
                await _unitOfWork.SaveAsync();

                LoadGridViewNoFilter();
            }
            else
            {
                MessageBox.Show("Please enter correct information");
            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            if (e.RowIndex >= 0)
            {
                //var clickedRow = dgv.Rows[e.RowIndex];
                var clickedRow = dgv.CurrentRow;

                if (clickedRow != null)
                {
                    var clickedRecord = (OrderWith_ClientExcursionDTO)clickedRow.DataBoundItem;


                    selectedOrderId = clickedRecord.OrderId;
                }




            }
        }

        private async void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_filterOrderCreatedDate_ValueChanged(object sender, EventArgs e)
        {
            DateOnly date = DateOnly.FromDateTime(dateTimePicker_filterOrderCreatedDate.Value);

            List<OrderWith_ClientExcursionDTO> filtered = _orders.Where(d => d.DateOrderCreated == date).ToList();

            dataGridView1.DataSource = filtered;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadGridViewNoFilter();
        }

        private void textBox_filterByEGN_TextChanged(object sender, EventArgs e)
        {
            bool isParsed = int.TryParse(textBox_filterByEGN.Text, out int egn);

            if (!isParsed) { dataGridView1.DataSource = _orders; return; }

            List<OrderWith_ClientExcursionDTO> filtered = _orders.Where(e => e.ClientEGN.ToString().Contains(egn.ToString())).ToList();

            dataGridView1.DataSource = filtered;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_ordersFilterByInsurance_ValueChanged(object sender, EventArgs e)
        {
            
            DateOnly date = DateOnly.FromDateTime(dateTimePicker_ordersFilterByInsurance.Value);

            List<OrderWith_ClientExcursionDTO> filtered = _orders.Where(d => d.ClientInsuranceNumber == date).ToList();

            dataGridView1.DataSource = filtered;
        }
    }
}
