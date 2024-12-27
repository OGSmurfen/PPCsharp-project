namespace TouristAgency_Forms
{
    partial class ClientsForm
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
            groupBox_InsertClient = new GroupBox();
            button_clientsClean = new Button();
            button_clientAdd = new Button();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker_clientInsuranceNr = new DateTimePicker();
            dateTimePicker_clientDOB = new DateTimePicker();
            textBox_clientGender = new TextBox();
            textBox_clientCountry = new TextBox();
            textBox_clientThreeNames = new TextBox();
            textBox_clientEGN = new TextBox();
            dataGridView_Clients = new DataGridView();
            button_clientsDelete = new Button();
            groupBox_InsertClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Clients).BeginInit();
            SuspendLayout();
            // 
            // groupBox_InsertClient
            // 
            groupBox_InsertClient.Controls.Add(button_clientsClean);
            groupBox_InsertClient.Controls.Add(button_clientAdd);
            groupBox_InsertClient.Controls.Add(label2);
            groupBox_InsertClient.Controls.Add(label1);
            groupBox_InsertClient.Controls.Add(dateTimePicker_clientInsuranceNr);
            groupBox_InsertClient.Controls.Add(dateTimePicker_clientDOB);
            groupBox_InsertClient.Controls.Add(textBox_clientGender);
            groupBox_InsertClient.Controls.Add(textBox_clientCountry);
            groupBox_InsertClient.Controls.Add(textBox_clientThreeNames);
            groupBox_InsertClient.Controls.Add(textBox_clientEGN);
            groupBox_InsertClient.Location = new Point(80, 71);
            groupBox_InsertClient.Name = "groupBox_InsertClient";
            groupBox_InsertClient.Size = new Size(536, 913);
            groupBox_InsertClient.TabIndex = 0;
            groupBox_InsertClient.TabStop = false;
            groupBox_InsertClient.Text = "InsertClient";
            // 
            // button_clientsClean
            // 
            button_clientsClean.Location = new Point(132, 725);
            button_clientsClean.Name = "button_clientsClean";
            button_clientsClean.Size = new Size(283, 84);
            button_clientsClean.TabIndex = 11;
            button_clientsClean.Text = "Clean";
            button_clientsClean.UseVisualStyleBackColor = true;
            button_clientsClean.Click += button2_Click;
            // 
            // button_clientAdd
            // 
            button_clientAdd.Location = new Point(123, 618);
            button_clientAdd.Name = "button_clientAdd";
            button_clientAdd.Size = new Size(301, 70);
            button_clientAdd.TabIndex = 10;
            button_clientAdd.Text = "Add / Modify";
            button_clientAdd.UseVisualStyleBackColor = true;
            button_clientAdd.Click += button_clientAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 397);
            label2.Name = "label2";
            label2.Size = new Size(166, 37);
            label2.TabIndex = 9;
            label2.Text = "Date of Birth";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 503);
            label1.Name = "label1";
            label1.Size = new Size(312, 37);
            label1.TabIndex = 8;
            label1.Text = "Insurance Date (Number)";
            // 
            // dateTimePicker_clientInsuranceNr
            // 
            dateTimePicker_clientInsuranceNr.Location = new Point(21, 539);
            dateTimePicker_clientInsuranceNr.Name = "dateTimePicker_clientInsuranceNr";
            dateTimePicker_clientInsuranceNr.Size = new Size(489, 43);
            dateTimePicker_clientInsuranceNr.TabIndex = 7;
            // 
            // dateTimePicker_clientDOB
            // 
            dateTimePicker_clientDOB.Location = new Point(21, 437);
            dateTimePicker_clientDOB.Name = "dateTimePicker_clientDOB";
            dateTimePicker_clientDOB.Size = new Size(489, 43);
            dateTimePicker_clientDOB.TabIndex = 6;
            // 
            // textBox_clientGender
            // 
            textBox_clientGender.Location = new Point(21, 305);
            textBox_clientGender.Name = "textBox_clientGender";
            textBox_clientGender.PlaceholderText = "Gender";
            textBox_clientGender.Size = new Size(489, 43);
            textBox_clientGender.TabIndex = 3;
            // 
            // textBox_clientCountry
            // 
            textBox_clientCountry.Location = new Point(21, 222);
            textBox_clientCountry.Name = "textBox_clientCountry";
            textBox_clientCountry.PlaceholderText = "Country";
            textBox_clientCountry.Size = new Size(489, 43);
            textBox_clientCountry.TabIndex = 2;
            // 
            // textBox_clientThreeNames
            // 
            textBox_clientThreeNames.Location = new Point(21, 145);
            textBox_clientThreeNames.Name = "textBox_clientThreeNames";
            textBox_clientThreeNames.PlaceholderText = "Three Names";
            textBox_clientThreeNames.Size = new Size(489, 43);
            textBox_clientThreeNames.TabIndex = 1;
            // 
            // textBox_clientEGN
            // 
            textBox_clientEGN.Location = new Point(21, 62);
            textBox_clientEGN.Name = "textBox_clientEGN";
            textBox_clientEGN.PlaceholderText = "Client EGN";
            textBox_clientEGN.Size = new Size(489, 43);
            textBox_clientEGN.TabIndex = 0;
            textBox_clientEGN.TextChanged += textBox_clientEGN_TextChanged;
            // 
            // dataGridView_Clients
            // 
            dataGridView_Clients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Clients.Location = new Point(766, 106);
            dataGridView_Clients.Name = "dataGridView_Clients";
            dataGridView_Clients.ReadOnly = true;
            dataGridView_Clients.RowHeadersWidth = 92;
            dataGridView_Clients.Size = new Size(1737, 694);
            dataGridView_Clients.TabIndex = 1;
            dataGridView_Clients.CellClick += dataGridView_Clients_CellClick;
            // 
            // button_clientsDelete
            // 
            button_clientsDelete.Location = new Point(1339, 842);
            button_clientsDelete.Name = "button_clientsDelete";
            button_clientsDelete.Size = new Size(362, 101);
            button_clientsDelete.TabIndex = 2;
            button_clientsDelete.Text = "Delete";
            button_clientsDelete.UseVisualStyleBackColor = true;
            button_clientsDelete.Click += button_clientsDelete_Click;
            // 
            // ClientsForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2589, 1069);
            Controls.Add(button_clientsDelete);
            Controls.Add(dataGridView_Clients);
            Controls.Add(groupBox_InsertClient);
            Name = "ClientsForm";
            Text = "ClientsForm";
            Load += ClientsForm_Load;
            groupBox_InsertClient.ResumeLayout(false);
            groupBox_InsertClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Clients).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox_InsertClient;
        private TextBox textBox_clientGender;
        private TextBox textBox_clientCountry;
        private TextBox textBox_clientThreeNames;
        private TextBox textBox_clientEGN;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker_clientInsuranceNr;
        private DateTimePicker dateTimePicker_clientDOB;
        private Button button_clientAdd;
        private DataGridView dataGridView_Clients;
        private Button button_clientsClean;
        private Button button_clientsDelete;
    }
}