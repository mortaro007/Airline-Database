namespace Companie_Aeriana
{
    partial class Select_Interogare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Select_Interogare));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.TicketSearch = new System.Windows.Forms.Button();
            this.PilotsSearch = new System.Windows.Forms.Button();
            this.CodPlecareSearch = new System.Windows.Forms.Button();
            this.searchAvioane = new System.Windows.Forms.ComboBox();
            this.AeronaveSearch = new System.Windows.Forms.Button();
            this.ticketOptions = new System.Windows.Forms.ComboBox();
            this.PilotID = new System.Windows.Forms.ComboBox();
            this.CxZ = new System.Windows.Forms.Button();
            this.ZxAeronava = new System.Windows.Forms.Button();
            this.BxAeronava = new System.Windows.Forms.Button();
            this.CxRezervare = new System.Windows.Forms.Button();
            this.RxZ = new System.Windows.Forms.Button();
            this.PxA = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.TicketSearch);
            this.panel1.Controls.Add(this.PilotsSearch);
            this.panel1.Controls.Add(this.CodPlecareSearch);
            this.panel1.Controls.Add(this.searchAvioane);
            this.panel1.Controls.Add(this.AeronaveSearch);
            this.panel1.Controls.Add(this.ticketOptions);
            this.panel1.Controls.Add(this.PilotID);
            this.panel1.Controls.Add(this.CxZ);
            this.panel1.Controls.Add(this.ZxAeronava);
            this.panel1.Controls.Add(this.BxAeronava);
            this.panel1.Controls.Add(this.CxRezervare);
            this.panel1.Controls.Add(this.RxZ);
            this.panel1.Controls.Add(this.PxA);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 450);
            this.panel1.TabIndex = 69;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CloseButton.BackgroundImage = global::Companie_Aeriana.Properties.Resources.arrow_right__1_;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Location = new System.Drawing.Point(12, 43);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(24, 24);
            this.CloseButton.TabIndex = 65;
            this.CloseButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(802, 24);
            this.panel2.TabIndex = 64;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "OTP",
            "BCM",
            "FCO",
            "NAP",
            "CPH",
            "IST",
            "LTN"});
            this.comboBox2.Location = new System.Drawing.Point(443, 170);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 30;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // TicketSearch
            // 
            this.TicketSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TicketSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TicketSearch.FlatAppearance.BorderSize = 0;
            this.TicketSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TicketSearch.Font = new System.Drawing.Font("Constantia", 12F);
            this.TicketSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TicketSearch.Image = ((System.Drawing.Image)(resources.GetObject("TicketSearch.Image")));
            this.TicketSearch.Location = new System.Drawing.Point(579, 303);
            this.TicketSearch.Name = "TicketSearch";
            this.TicketSearch.Size = new System.Drawing.Size(182, 48);
            this.TicketSearch.TabIndex = 36;
            this.TicketSearch.Text = "Căutare bilete\r\ndupă tip";
            this.TicketSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TicketSearch.UseVisualStyleBackColor = false;
            this.TicketSearch.Click += new System.EventHandler(this.TicketSearch_Click);
            // 
            // PilotsSearch
            // 
            this.PilotsSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PilotsSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PilotsSearch.FlatAppearance.BorderSize = 0;
            this.PilotsSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PilotsSearch.Font = new System.Drawing.Font("Constantia", 12F);
            this.PilotsSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PilotsSearch.Image = ((System.Drawing.Image)(resources.GetObject("PilotsSearch.Image")));
            this.PilotsSearch.Location = new System.Drawing.Point(579, 230);
            this.PilotsSearch.Name = "PilotsSearch";
            this.PilotsSearch.Size = new System.Drawing.Size(182, 42);
            this.PilotsSearch.TabIndex = 35;
            this.PilotsSearch.Text = "Căutare piloți";
            this.PilotsSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PilotsSearch.UseVisualStyleBackColor = false;
            this.PilotsSearch.Click += new System.EventHandler(this.PilotsSearch_Click);
            // 
            // CodPlecareSearch
            // 
            this.CodPlecareSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CodPlecareSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CodPlecareSearch.FlatAppearance.BorderSize = 0;
            this.CodPlecareSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CodPlecareSearch.Font = new System.Drawing.Font("Constantia", 12F);
            this.CodPlecareSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CodPlecareSearch.Image = ((System.Drawing.Image)(resources.GetObject("CodPlecareSearch.Image")));
            this.CodPlecareSearch.Location = new System.Drawing.Point(579, 157);
            this.CodPlecareSearch.Name = "CodPlecareSearch";
            this.CodPlecareSearch.Size = new System.Drawing.Size(182, 42);
            this.CodPlecareSearch.TabIndex = 34;
            this.CodPlecareSearch.Text = "Căutare cod plecare";
            this.CodPlecareSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CodPlecareSearch.UseVisualStyleBackColor = false;
            this.CodPlecareSearch.Click += new System.EventHandler(this.CodPlecareSearch_Click);
            // 
            // searchAvioane
            // 
            this.searchAvioane.FormattingEnabled = true;
            this.searchAvioane.Items.AddRange(new object[] {
            "Boeing",
            "Airbus",
            "Concorde"});
            this.searchAvioane.Location = new System.Drawing.Point(443, 89);
            this.searchAvioane.Name = "searchAvioane";
            this.searchAvioane.Size = new System.Drawing.Size(121, 21);
            this.searchAvioane.TabIndex = 29;
            // 
            // AeronaveSearch
            // 
            this.AeronaveSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AeronaveSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AeronaveSearch.FlatAppearance.BorderSize = 0;
            this.AeronaveSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AeronaveSearch.Font = new System.Drawing.Font("Constantia", 12F);
            this.AeronaveSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AeronaveSearch.Image = ((System.Drawing.Image)(resources.GetObject("AeronaveSearch.Image")));
            this.AeronaveSearch.Location = new System.Drawing.Point(579, 76);
            this.AeronaveSearch.Name = "AeronaveSearch";
            this.AeronaveSearch.Size = new System.Drawing.Size(182, 42);
            this.AeronaveSearch.TabIndex = 33;
            this.AeronaveSearch.Text = "Căutare aeronave";
            this.AeronaveSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AeronaveSearch.UseVisualStyleBackColor = false;
            this.AeronaveSearch.Click += new System.EventHandler(this.AeronaveSearch_Click);
            // 
            // ticketOptions
            // 
            this.ticketOptions.FormattingEnabled = true;
            this.ticketOptions.Items.AddRange(new object[] {
            "Standard",
            "Comfort",
            "Express"});
            this.ticketOptions.Location = new System.Drawing.Point(443, 319);
            this.ticketOptions.Name = "ticketOptions";
            this.ticketOptions.Size = new System.Drawing.Size(121, 21);
            this.ticketOptions.TabIndex = 32;
            // 
            // PilotID
            // 
            this.PilotID.FormattingEnabled = true;
            this.PilotID.Items.AddRange(new object[] {
            "123200021178",
            "123200021182",
            "123200021190",
            "123200021191",
            "123200021192",
            "123200021200",
            "123200021201",
            "123200021308",
            "123200023000",
            "123200023001"});
            this.PilotID.Location = new System.Drawing.Point(443, 243);
            this.PilotID.Name = "PilotID";
            this.PilotID.Size = new System.Drawing.Size(121, 21);
            this.PilotID.TabIndex = 31;
            // 
            // CxZ
            // 
            this.CxZ.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CxZ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CxZ.FlatAppearance.BorderSize = 0;
            this.CxZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CxZ.Font = new System.Drawing.Font("Constantia", 18F);
            this.CxZ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CxZ.Image = global::Companie_Aeriana.Properties.Resources.ui;
            this.CxZ.Location = new System.Drawing.Point(59, 357);
            this.CxZ.Name = "CxZ";
            this.CxZ.Size = new System.Drawing.Size(258, 68);
            this.CxZ.TabIndex = 28;
            this.CxZ.Text = "Client - Zbor\r\nOra decolare > 9AM";
            this.CxZ.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CxZ.UseVisualStyleBackColor = false;
            this.CxZ.Click += new System.EventHandler(this.CxZ_Click);
            // 
            // ZxAeronava
            // 
            this.ZxAeronava.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ZxAeronava.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ZxAeronava.FlatAppearance.BorderSize = 0;
            this.ZxAeronava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZxAeronava.Font = new System.Drawing.Font("Constantia", 18F);
            this.ZxAeronava.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ZxAeronava.Image = global::Companie_Aeriana.Properties.Resources.ui;
            this.ZxAeronava.Location = new System.Drawing.Point(71, 285);
            this.ZxAeronava.Name = "ZxAeronava";
            this.ZxAeronava.Size = new System.Drawing.Size(246, 66);
            this.ZxAeronava.TabIndex = 27;
            this.ZxAeronava.Text = "Zbor - Aeronava\r\nLocuri > 150";
            this.ZxAeronava.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ZxAeronava.UseVisualStyleBackColor = false;
            this.ZxAeronava.Click += new System.EventHandler(this.ZxAeronava_Click);
            // 
            // BxAeronava
            // 
            this.BxAeronava.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BxAeronava.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BxAeronava.FlatAppearance.BorderSize = 0;
            this.BxAeronava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BxAeronava.Font = new System.Drawing.Font("Constantia", 18F);
            this.BxAeronava.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BxAeronava.Image = global::Companie_Aeriana.Properties.Resources.ui;
            this.BxAeronava.Location = new System.Drawing.Point(71, 212);
            this.BxAeronava.Name = "BxAeronava";
            this.BxAeronava.Size = new System.Drawing.Size(246, 66);
            this.BxAeronava.TabIndex = 26;
            this.BxAeronava.Text = "Bilet - Aeronava\r\nClasa \"Comfort\"";
            this.BxAeronava.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BxAeronava.UseVisualStyleBackColor = false;
            this.BxAeronava.Click += new System.EventHandler(this.BxAeronava_Click);
            // 
            // CxRezervare
            // 
            this.CxRezervare.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CxRezervare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CxRezervare.FlatAppearance.BorderSize = 0;
            this.CxRezervare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CxRezervare.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CxRezervare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CxRezervare.Image = global::Companie_Aeriana.Properties.Resources.ui;
            this.CxRezervare.Location = new System.Drawing.Point(71, 140);
            this.CxRezervare.Name = "CxRezervare";
            this.CxRezervare.Size = new System.Drawing.Size(246, 66);
            this.CxRezervare.TabIndex = 25;
            this.CxRezervare.Text = "Client - Rezervare\r\nPret > 500";
            this.CxRezervare.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CxRezervare.UseVisualStyleBackColor = false;
            this.CxRezervare.Click += new System.EventHandler(this.CxRezervare_Click);
            // 
            // RxZ
            // 
            this.RxZ.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RxZ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RxZ.FlatAppearance.BorderSize = 0;
            this.RxZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RxZ.Font = new System.Drawing.Font("Constantia", 18F);
            this.RxZ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RxZ.Image = global::Companie_Aeriana.Properties.Resources.ui;
            this.RxZ.Location = new System.Drawing.Point(71, 81);
            this.RxZ.Name = "RxZ";
            this.RxZ.Size = new System.Drawing.Size(246, 53);
            this.RxZ.TabIndex = 24;
            this.RxZ.Text = "Ruta - Zboruri";
            this.RxZ.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RxZ.UseVisualStyleBackColor = false;
            this.RxZ.Click += new System.EventHandler(this.RxZ_Click);
            // 
            // PxA
            // 
            this.PxA.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PxA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PxA.FlatAppearance.BorderSize = 0;
            this.PxA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PxA.Font = new System.Drawing.Font("Constantia", 18F);
            this.PxA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PxA.Image = ((System.Drawing.Image)(resources.GetObject("PxA.Image")));
            this.PxA.Location = new System.Drawing.Point(71, 30);
            this.PxA.Name = "PxA";
            this.PxA.Size = new System.Drawing.Size(246, 52);
            this.PxA.TabIndex = 23;
            this.PxA.Text = "Piloti - Aeronave";
            this.PxA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PxA.UseVisualStyleBackColor = false;
            this.PxA.Click += new System.EventHandler(this.PxA_Click);
            // 
            // Select_Interogare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Select_Interogare";
            this.Text = "Select_Interogare";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RxZ;
        private System.Windows.Forms.Button PxA;
        private System.Windows.Forms.Button CxRezervare;
        private System.Windows.Forms.Button BxAeronava;
        private System.Windows.Forms.Button ZxAeronava;
        private System.Windows.Forms.Button CxZ;
        private System.Windows.Forms.ComboBox ticketOptions;
        private System.Windows.Forms.ComboBox PilotID;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox searchAvioane;
        private System.Windows.Forms.Button AeronaveSearch;
        private System.Windows.Forms.Button CodPlecareSearch;
        private System.Windows.Forms.Button PilotsSearch;
        private System.Windows.Forms.Button TicketSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button CloseButton;
    }
}