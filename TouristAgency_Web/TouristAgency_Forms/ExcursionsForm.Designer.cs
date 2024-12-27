namespace TouristAgency_Forms
{
    partial class ExcursionsForm
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
            button_excursionsClean = new Button();
            button_excursionsAdd = new Button();
            label5 = new Label();
            label4 = new Label();
            dateTimePicker__excursionEndDate = new DateTimePicker();
            dateTimePicker_excursionBeginDate = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            numericUpDown_excursionAdditionalPrice = new NumericUpDown();
            numericUpDown_excursionPriceExcursion = new NumericUpDown();
            numericUpDown_excursionPriceTransport = new NumericUpDown();
            textBox_excursionDestinationCity = new TextBox();
            textBox_excursionDestinationCountry = new TextBox();
            dataGridView_excursions = new DataGridView();
            button_excursionsDelete = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_excursionAdditionalPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_excursionPriceExcursion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_excursionPriceTransport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_excursions).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button_excursionsClean);
            groupBox1.Controls.Add(button_excursionsAdd);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dateTimePicker__excursionEndDate);
            groupBox1.Controls.Add(dateTimePicker_excursionBeginDate);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(numericUpDown_excursionAdditionalPrice);
            groupBox1.Controls.Add(numericUpDown_excursionPriceExcursion);
            groupBox1.Controls.Add(numericUpDown_excursionPriceTransport);
            groupBox1.Controls.Add(textBox_excursionDestinationCity);
            groupBox1.Controls.Add(textBox_excursionDestinationCountry);
            groupBox1.Location = new Point(92, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(521, 924);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Excursion";
            // 
            // button_excursionsClean
            // 
            button_excursionsClean.Location = new Point(139, 803);
            button_excursionsClean.Name = "button_excursionsClean";
            button_excursionsClean.Size = new Size(226, 96);
            button_excursionsClean.TabIndex = 18;
            button_excursionsClean.Text = "Clean";
            button_excursionsClean.UseVisualStyleBackColor = true;
            button_excursionsClean.Click += button_excursionsClean_Click;
            // 
            // button_excursionsAdd
            // 
            button_excursionsAdd.Location = new Point(139, 688);
            button_excursionsAdd.Name = "button_excursionsAdd";
            button_excursionsAdd.Size = new Size(226, 96);
            button_excursionsAdd.TabIndex = 17;
            button_excursionsAdd.Text = "Add / Modify";
            button_excursionsAdd.UseVisualStyleBackColor = true;
            button_excursionsAdd.Click += button_excursionsAdd_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 304);
            label5.Name = "label5";
            label5.Size = new Size(125, 37);
            label5.TabIndex = 16;
            label5.Text = "End Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 219);
            label4.Name = "label4";
            label4.Size = new Size(147, 37);
            label4.TabIndex = 15;
            label4.Text = "Begin Date";
            // 
            // dateTimePicker__excursionEndDate
            // 
            dateTimePicker__excursionEndDate.Location = new Point(50, 344);
            dateTimePicker__excursionEndDate.Name = "dateTimePicker__excursionEndDate";
            dateTimePicker__excursionEndDate.Size = new Size(450, 43);
            dateTimePicker__excursionEndDate.TabIndex = 14;
            // 
            // dateTimePicker_excursionBeginDate
            // 
            dateTimePicker_excursionBeginDate.Location = new Point(50, 259);
            dateTimePicker_excursionBeginDate.Name = "dateTimePicker_excursionBeginDate";
            dateTimePicker_excursionBeginDate.Size = new Size(450, 43);
            dateTimePicker_excursionBeginDate.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 583);
            label3.Name = "label3";
            label3.Size = new Size(205, 37);
            label3.TabIndex = 12;
            label3.Text = "Additional Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 486);
            label2.Name = "label2";
            label2.Size = new Size(192, 37);
            label2.TabIndex = 11;
            label2.Text = "Excursion Price";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 388);
            label1.Name = "label1";
            label1.Size = new Size(192, 37);
            label1.TabIndex = 10;
            label1.Text = "Transport Price";
            label1.Click += label1_Click;
            // 
            // numericUpDown_excursionAdditionalPrice
            // 
            numericUpDown_excursionAdditionalPrice.DecimalPlaces = 2;
            numericUpDown_excursionAdditionalPrice.Location = new Point(50, 623);
            numericUpDown_excursionAdditionalPrice.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown_excursionAdditionalPrice.Name = "numericUpDown_excursionAdditionalPrice";
            numericUpDown_excursionAdditionalPrice.Size = new Size(450, 43);
            numericUpDown_excursionAdditionalPrice.TabIndex = 9;
            // 
            // numericUpDown_excursionPriceExcursion
            // 
            numericUpDown_excursionPriceExcursion.DecimalPlaces = 2;
            numericUpDown_excursionPriceExcursion.Location = new Point(50, 526);
            numericUpDown_excursionPriceExcursion.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown_excursionPriceExcursion.Name = "numericUpDown_excursionPriceExcursion";
            numericUpDown_excursionPriceExcursion.Size = new Size(450, 43);
            numericUpDown_excursionPriceExcursion.TabIndex = 8;
            // 
            // numericUpDown_excursionPriceTransport
            // 
            numericUpDown_excursionPriceTransport.DecimalPlaces = 2;
            numericUpDown_excursionPriceTransport.Location = new Point(50, 426);
            numericUpDown_excursionPriceTransport.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown_excursionPriceTransport.Name = "numericUpDown_excursionPriceTransport";
            numericUpDown_excursionPriceTransport.Size = new Size(450, 43);
            numericUpDown_excursionPriceTransport.TabIndex = 7;
            // 
            // textBox_excursionDestinationCity
            // 
            textBox_excursionDestinationCity.Location = new Point(50, 135);
            textBox_excursionDestinationCity.Name = "textBox_excursionDestinationCity";
            textBox_excursionDestinationCity.PlaceholderText = "Destination City";
            textBox_excursionDestinationCity.Size = new Size(450, 43);
            textBox_excursionDestinationCity.TabIndex = 1;
            // 
            // textBox_excursionDestinationCountry
            // 
            textBox_excursionDestinationCountry.Location = new Point(50, 65);
            textBox_excursionDestinationCountry.Name = "textBox_excursionDestinationCountry";
            textBox_excursionDestinationCountry.PlaceholderText = "Destination Country";
            textBox_excursionDestinationCountry.Size = new Size(450, 43);
            textBox_excursionDestinationCountry.TabIndex = 0;
            // 
            // dataGridView_excursions
            // 
            dataGridView_excursions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_excursions.Location = new Point(647, 95);
            dataGridView_excursions.Name = "dataGridView_excursions";
            dataGridView_excursions.ReadOnly = true;
            dataGridView_excursions.RowHeadersWidth = 92;
            dataGridView_excursions.Size = new Size(1911, 765);
            dataGridView_excursions.TabIndex = 1;
            dataGridView_excursions.CellClick += dataGridView_excursions_CellClick;
            // 
            // button_excursionsDelete
            // 
            button_excursionsDelete.Location = new Point(1400, 901);
            button_excursionsDelete.Name = "button_excursionsDelete";
            button_excursionsDelete.Size = new Size(436, 118);
            button_excursionsDelete.TabIndex = 2;
            button_excursionsDelete.Text = "Delete";
            button_excursionsDelete.UseVisualStyleBackColor = true;
            button_excursionsDelete.Click += button_excursionsDelete_Click;
            // 
            // ExcursionsForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2596, 1070);
            Controls.Add(button_excursionsDelete);
            Controls.Add(dataGridView_excursions);
            Controls.Add(groupBox1);
            Name = "ExcursionsForm";
            Text = "ExcursionsForm";
            Load += ExcursionsForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_excursionAdditionalPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_excursionPriceExcursion).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_excursionPriceTransport).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_excursions).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox_excursionDestinationCountry;
        private TextBox textBox_excursionDestinationCity;
        private Label label1;
        private NumericUpDown numericUpDown_excursionAdditionalPrice;
        private NumericUpDown numericUpDown_excursionPriceExcursion;
        private NumericUpDown numericUpDown_excursionPriceTransport;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label4;
        private DateTimePicker dateTimePicker__excursionEndDate;
        private DateTimePicker dateTimePicker_excursionBeginDate;
        private Button button_excursionsAdd;
        private Button button_excursionsClean;
        private DataGridView dataGridView_excursions;
        private Button button_excursionsDelete;
    }
}