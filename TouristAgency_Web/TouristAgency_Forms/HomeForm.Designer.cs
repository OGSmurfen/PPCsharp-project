namespace TouristAgency_Forms
{
    partial class HomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            open_clients_btn = new Button();
            open_orders_btn = new Button();
            open_excursions_btn = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            button_chartShow = new Button();
            button_lookupDestinations = new Button();
            button_lookupClients = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // open_clients_btn
            // 
            open_clients_btn.Location = new Point(25, 60);
            open_clients_btn.Name = "open_clients_btn";
            open_clients_btn.Size = new Size(304, 115);
            open_clients_btn.TabIndex = 0;
            open_clients_btn.Text = "Clients";
            open_clients_btn.UseVisualStyleBackColor = true;
            open_clients_btn.Click += button1_Click;
            // 
            // open_orders_btn
            // 
            open_orders_btn.Location = new Point(25, 369);
            open_orders_btn.Name = "open_orders_btn";
            open_orders_btn.Size = new Size(304, 115);
            open_orders_btn.TabIndex = 1;
            open_orders_btn.Text = "Orders";
            open_orders_btn.UseVisualStyleBackColor = true;
            open_orders_btn.Click += open_orders_btn_Click;
            // 
            // open_excursions_btn
            // 
            open_excursions_btn.Location = new Point(25, 211);
            open_excursions_btn.Name = "open_excursions_btn";
            open_excursions_btn.Size = new Size(304, 115);
            open_excursions_btn.TabIndex = 2;
            open_excursions_btn.Text = "Excursions";
            open_excursions_btn.UseVisualStyleBackColor = true;
            open_excursions_btn.Click += open_excursions_btn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(open_orders_btn);
            groupBox1.Controls.Add(open_excursions_btn);
            groupBox1.Controls.Add(open_clients_btn);
            groupBox1.Location = new Point(71, 119);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(371, 642);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "EditRecords";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button_chartShow);
            groupBox2.Controls.Add(button_lookupDestinations);
            groupBox2.Controls.Add(button_lookupClients);
            groupBox2.Location = new Point(850, 119);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(515, 642);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lookup";
            // 
            // button_chartShow
            // 
            button_chartShow.Location = new Point(97, 369);
            button_chartShow.Name = "button_chartShow";
            button_chartShow.Size = new Size(304, 115);
            button_chartShow.TabIndex = 2;
            button_chartShow.Text = "Chart";
            button_chartShow.UseVisualStyleBackColor = true;
            button_chartShow.Click += button_chartShow_Click;
            // 
            // button_lookupDestinations
            // 
            button_lookupDestinations.Location = new Point(97, 211);
            button_lookupDestinations.Name = "button_lookupDestinations";
            button_lookupDestinations.Size = new Size(304, 115);
            button_lookupDestinations.TabIndex = 1;
            button_lookupDestinations.Text = "Destinations";
            button_lookupDestinations.UseVisualStyleBackColor = true;
            button_lookupDestinations.Click += button_lookupDestinations_Click;
            // 
            // button_lookupClients
            // 
            button_lookupClients.Location = new Point(97, 60);
            button_lookupClients.Name = "button_lookupClients";
            button_lookupClients.Size = new Size(304, 115);
            button_lookupClients.TabIndex = 0;
            button_lookupClients.Text = "Clients";
            button_lookupClients.UseVisualStyleBackColor = true;
            button_lookupClients.Click += button_lookupClients_Click;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1470, 873);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "HomeForm";
            Text = "TouristAgency";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button open_clients_btn;
        private Button open_orders_btn;
        private Button open_excursions_btn;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button_chartShow;
        private Button button_lookupDestinations;
        private Button button_lookupClients;
    }
}
