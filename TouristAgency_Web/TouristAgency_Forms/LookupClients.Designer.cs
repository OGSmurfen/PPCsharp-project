namespace TouristAgency_Forms
{
    partial class LookupClients
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
            dataGridView_lookupClients = new DataGridView();
            dateTimePicker_beginDate = new DateTimePicker();
            dateTimePicker_endDate = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            button_searchClients = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_lookupClients).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_lookupClients
            // 
            dataGridView_lookupClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_lookupClients.Location = new Point(74, 150);
            dataGridView_lookupClients.Name = "dataGridView_lookupClients";
            dataGridView_lookupClients.ReadOnly = true;
            dataGridView_lookupClients.RowHeadersWidth = 92;
            dataGridView_lookupClients.Size = new Size(1833, 661);
            dataGridView_lookupClients.TabIndex = 0;
            // 
            // dateTimePicker_beginDate
            // 
            dateTimePicker_beginDate.Location = new Point(74, 74);
            dateTimePicker_beginDate.Name = "dateTimePicker_beginDate";
            dateTimePicker_beginDate.Size = new Size(450, 43);
            dateTimePicker_beginDate.TabIndex = 1;
            // 
            // dateTimePicker_endDate
            // 
            dateTimePicker_endDate.Location = new Point(611, 74);
            dateTimePicker_endDate.Name = "dateTimePicker_endDate";
            dateTimePicker_endDate.Size = new Size(450, 43);
            dateTimePicker_endDate.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 18);
            label1.Name = "label1";
            label1.Size = new Size(147, 37);
            label1.TabIndex = 3;
            label1.Text = "Begin Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(659, 18);
            label2.Name = "label2";
            label2.Size = new Size(125, 37);
            label2.TabIndex = 4;
            label2.Text = "End Date";
            // 
            // button_searchClients
            // 
            button_searchClients.Location = new Point(1199, 65);
            button_searchClients.Name = "button_searchClients";
            button_searchClients.Size = new Size(169, 52);
            button_searchClients.TabIndex = 5;
            button_searchClients.Text = "Search";
            button_searchClients.UseVisualStyleBackColor = true;
            button_searchClients.Click += button_searchClients_Click;
            // 
            // LookupClients
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2029, 917);
            Controls.Add(button_searchClients);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker_endDate);
            Controls.Add(dateTimePicker_beginDate);
            Controls.Add(dataGridView_lookupClients);
            Name = "LookupClients";
            Text = "LookupClients";
            Load += LookupClients_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_lookupClients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView_lookupClients;
        private DateTimePicker dateTimePicker_beginDate;
        private DateTimePicker dateTimePicker_endDate;
        private Label label1;
        private Label label2;
        private Button button_searchClients;
    }
}