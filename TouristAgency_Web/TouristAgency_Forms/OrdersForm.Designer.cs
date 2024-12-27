namespace TouristAgency_Forms
{
    partial class OrdersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            button_orderAdd = new Button();
            comboBox_orderClientId = new ComboBox();
            comboBox_orderExcursionId = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker_orderDateIssued = new DateTimePicker();
            dataGridView1 = new DataGridView();
            button_orderDelete = new Button();
            dateTimePicker_filterOrderCreatedDate = new DateTimePicker();
            label4 = new Label();
            button1 = new Button();
            textBox_filterByEGN = new TextBox();
            label5 = new Label();
            dateTimePicker_ordersFilterByInsurance = new DateTimePicker();
            label6 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button_orderAdd);
            groupBox1.Controls.Add(comboBox_orderClientId);
            groupBox1.Controls.Add(comboBox_orderExcursionId);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dateTimePicker_orderDateIssued);
            groupBox1.Location = new Point(12, 86);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(642, 884);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Orders";
            // 
            // button_orderAdd
            // 
            button_orderAdd.Location = new Point(175, 596);
            button_orderAdd.Name = "button_orderAdd";
            button_orderAdd.Size = new Size(253, 96);
            button_orderAdd.TabIndex = 2;
            button_orderAdd.Text = "Add";
            button_orderAdd.UseVisualStyleBackColor = true;
            button_orderAdd.Click += button_orderAdd_Click;
            // 
            // comboBox_orderClientId
            // 
            comboBox_orderClientId.FormattingEnabled = true;
            comboBox_orderClientId.Location = new Point(6, 290);
            comboBox_orderClientId.Name = "comboBox_orderClientId";
            comboBox_orderClientId.Size = new Size(630, 45);
            comboBox_orderClientId.TabIndex = 5;
            // 
            // comboBox_orderExcursionId
            // 
            comboBox_orderExcursionId.FormattingEnabled = true;
            comboBox_orderExcursionId.Location = new Point(6, 135);
            comboBox_orderExcursionId.Name = "comboBox_orderExcursionId";
            comboBox_orderExcursionId.Size = new Size(630, 45);
            comboBox_orderExcursionId.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 396);
            label3.Name = "label3";
            label3.Size = new Size(154, 37);
            label3.TabIndex = 3;
            label3.Text = "Date Issued";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 250);
            label2.Name = "label2";
            label2.Size = new Size(116, 37);
            label2.TabIndex = 2;
            label2.Text = "Client Id";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 86);
            label1.Name = "label1";
            label1.Size = new Size(158, 37);
            label1.TabIndex = 1;
            label1.Text = "Excursion Id";
            // 
            // dateTimePicker_orderDateIssued
            // 
            dateTimePicker_orderDateIssued.Location = new Point(6, 447);
            dateTimePicker_orderDateIssued.Name = "dateTimePicker_orderDateIssued";
            dateTimePicker_orderDateIssued.Size = new Size(630, 43);
            dateTimePicker_orderDateIssued.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(716, 119);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 92;
            dataGridView1.Size = new Size(1782, 745);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button_orderDelete
            // 
            button_orderDelete.Location = new Point(1417, 910);
            button_orderDelete.Name = "button_orderDelete";
            button_orderDelete.Size = new Size(253, 96);
            button_orderDelete.TabIndex = 2;
            button_orderDelete.Text = "Delete";
            button_orderDelete.UseVisualStyleBackColor = true;
            button_orderDelete.Click += button_orderDelete_Click;
            // 
            // dateTimePicker_filterOrderCreatedDate
            // 
            dateTimePicker_filterOrderCreatedDate.Location = new Point(1880, 51);
            dateTimePicker_filterOrderCreatedDate.Name = "dateTimePicker_filterOrderCreatedDate";
            dateTimePicker_filterOrderCreatedDate.Size = new Size(450, 43);
            dateTimePicker_filterOrderCreatedDate.TabIndex = 3;
            dateTimePicker_filterOrderCreatedDate.ValueChanged += dateTimePicker_filterOrderCreatedDate_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1880, 11);
            label4.Name = "label4";
            label4.Size = new Size(174, 37);
            label4.TabIndex = 4;
            label4.Text = "Filter By Date";
            // 
            // button1
            // 
            button1.Location = new Point(2348, 42);
            button1.Name = "button1";
            button1.Size = new Size(169, 52);
            button1.TabIndex = 5;
            button1.Text = "Clear Filters";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox_filterByEGN
            // 
            textBox_filterByEGN.Location = new Point(749, 51);
            textBox_filterByEGN.Name = "textBox_filterByEGN";
            textBox_filterByEGN.Size = new Size(450, 43);
            textBox_filterByEGN.TabIndex = 6;
            textBox_filterByEGN.TextChanged += textBox_filterByEGN_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(749, 11);
            label5.Name = "label5";
            label5.Size = new Size(171, 37);
            label5.TabIndex = 7;
            label5.Text = "Filter By EGN";
            // 
            // dateTimePicker_ordersFilterByInsurance
            // 
            dateTimePicker_ordersFilterByInsurance.Location = new Point(1316, 49);
            dateTimePicker_ordersFilterByInsurance.Name = "dateTimePicker_ordersFilterByInsurance";
            dateTimePicker_ordersFilterByInsurance.Size = new Size(450, 43);
            dateTimePicker_ordersFilterByInsurance.TabIndex = 8;
            dateTimePicker_ordersFilterByInsurance.ValueChanged += dateTimePicker_ordersFilterByInsurance_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1338, 9);
            label6.Name = "label6";
            label6.Size = new Size(231, 37);
            label6.TabIndex = 9;
            label6.Text = "Filter by Insurance";
            label6.Click += label6_Click;
            // 
            // OrdersForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2585, 1074);
            Controls.Add(label6);
            Controls.Add(dateTimePicker_ordersFilterByInsurance);
            Controls.Add(label5);
            Controls.Add(textBox_filterByEGN);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(dateTimePicker_filterOrderCreatedDate);
            Controls.Add(button_orderDelete);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "OrdersForm";
            Text = "OrdersForm";
            Load += OrdersForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker_orderDateIssued;
        private ComboBox comboBox_orderClientId;
        private ComboBox comboBox_orderExcursionId;
        private Button button_orderAdd;
        private Button button_orderDelete;
        private DateTimePicker dateTimePicker_filterOrderCreatedDate;
        private Label label4;
        private Button button1;
        private TextBox textBox_filterByEGN;
        private Label label5;
        private DateTimePicker dateTimePicker_ordersFilterByInsurance;
        private Label label6;
    }
}