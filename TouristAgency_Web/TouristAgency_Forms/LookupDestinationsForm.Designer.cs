namespace TouristAgency_Forms
{
    partial class LookupDestinationsForm
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
            dataGridView_lookupDestinations = new DataGridView();
            textBox_clientThreeNames = new TextBox();
            button_destinationSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_lookupDestinations).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_lookupDestinations
            // 
            dataGridView_lookupDestinations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_lookupDestinations.Location = new Point(143, 162);
            dataGridView_lookupDestinations.Name = "dataGridView_lookupDestinations";
            dataGridView_lookupDestinations.ReadOnly = true;
            dataGridView_lookupDestinations.RowHeadersWidth = 92;
            dataGridView_lookupDestinations.Size = new Size(2052, 785);
            dataGridView_lookupDestinations.TabIndex = 0;
            // 
            // textBox_clientThreeNames
            // 
            textBox_clientThreeNames.Location = new Point(143, 91);
            textBox_clientThreeNames.Name = "textBox_clientThreeNames";
            textBox_clientThreeNames.PlaceholderText = "Client Three Names";
            textBox_clientThreeNames.Size = new Size(385, 43);
            textBox_clientThreeNames.TabIndex = 1;
            // 
            // button_destinationSearch
            // 
            button_destinationSearch.Location = new Point(879, 94);
            button_destinationSearch.Name = "button_destinationSearch";
            button_destinationSearch.Size = new Size(169, 52);
            button_destinationSearch.TabIndex = 2;
            button_destinationSearch.Text = "Search";
            button_destinationSearch.UseVisualStyleBackColor = true;
            button_destinationSearch.Click += button_destinationSearch_Click;
            // 
            // LookupDestinationsForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2428, 1050);
            Controls.Add(button_destinationSearch);
            Controls.Add(textBox_clientThreeNames);
            Controls.Add(dataGridView_lookupDestinations);
            Name = "LookupDestinationsForm";
            Text = "LookupDestinationsForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView_lookupDestinations).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView_lookupDestinations;
        private TextBox textBox_clientThreeNames;
        private Button button_destinationSearch;
    }
}