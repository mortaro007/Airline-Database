namespace Companie_Aeriana
{
    partial class Select
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Select));
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Move1 = new System.Windows.Forms.Panel();
            this.ButtonLogout = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.ButtonAeroport = new System.Windows.Forms.Button();
            this.ButtonRuta = new System.Windows.Forms.Button();
            this.ButtonPilot = new System.Windows.Forms.Button();
            this.ButtonAeronava = new System.Windows.Forms.Button();
            this.ButtonZboruri = new System.Windows.Forms.Button();
            this.ButtonBilet = new System.Windows.Forms.Button();
            this.ButtonRezervare = new System.Windows.Forms.Button();
            this.ButtonClient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Move2 = new System.Windows.Forms.Panel();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.RightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(53)))));
            this.LeftPanel.Controls.Add(this.button1);
            this.LeftPanel.Controls.Add(this.Move1);
            this.LeftPanel.Controls.Add(this.ButtonLogout);
            this.LeftPanel.Controls.Add(this.user);
            this.LeftPanel.Controls.Add(this.UserName);
            this.LeftPanel.Controls.Add(this.pictureBoxUser);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(279, 450);
            this.LeftPanel.TabIndex = 0;
            this.LeftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Left_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(53)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Constantia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(42, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 71);
            this.button1.TabIndex = 25;
            this.button1.Text = "Interogări";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Move1
            // 
            this.Move1.BackColor = System.Drawing.Color.Transparent;
            this.Move1.Location = new System.Drawing.Point(0, 0);
            this.Move1.Name = "Move1";
            this.Move1.Size = new System.Drawing.Size(279, 34);
            this.Move1.TabIndex = 6;
            this.Move1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move1_MouseDown);
            this.Move1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Move1_MouseMove);
            this.Move1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Move1_MouseUp);
            // 
            // ButtonLogout
            // 
            this.ButtonLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonLogout.FlatAppearance.BorderSize = 0;
            this.ButtonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLogout.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ButtonLogout.Image = global::Companie_Aeriana.Properties.Resources.sign_out__1_;
            this.ButtonLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonLogout.Location = new System.Drawing.Point(12, 404);
            this.ButtonLogout.Name = "ButtonLogout";
            this.ButtonLogout.Size = new System.Drawing.Size(98, 34);
            this.ButtonLogout.TabIndex = 3;
            this.ButtonLogout.Text = "Sign out";
            this.ButtonLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ButtonLogout.UseVisualStyleBackColor = true;
            this.ButtonLogout.Click += new System.EventHandler(this.ButtonLogout_Click);
            this.ButtonLogout.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonLogout_MouseDown);
            this.ButtonLogout.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonLogout_MouseUp);
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.user.Location = new System.Drawing.Point(155, 142);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(0, 20);
            this.user.TabIndex = 2;
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.UserName.Location = new System.Drawing.Point(47, 142);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(108, 20);
            this.UserName.TabIndex = 1;
            this.UserName.Text = "User Name: ";
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.Image = global::Companie_Aeriana.Properties.Resources.user__3_;
            this.pictureBoxUser.Location = new System.Drawing.Point(106, 57);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(63, 68);
            this.pictureBoxUser.TabIndex = 0;
            this.pictureBoxUser.TabStop = false;
            // 
            // RightPanel
            // 
            this.RightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.RightPanel.Controls.Add(this.ButtonAeroport);
            this.RightPanel.Controls.Add(this.ButtonRuta);
            this.RightPanel.Controls.Add(this.ButtonPilot);
            this.RightPanel.Controls.Add(this.ButtonAeronava);
            this.RightPanel.Controls.Add(this.ButtonZboruri);
            this.RightPanel.Controls.Add(this.ButtonBilet);
            this.RightPanel.Controls.Add(this.ButtonRezervare);
            this.RightPanel.Controls.Add(this.ButtonClient);
            this.RightPanel.Controls.Add(this.label1);
            this.RightPanel.Controls.Add(this.pictureBox1);
            this.RightPanel.Controls.Add(this.Move2);
            this.RightPanel.Controls.Add(this.MinimizeButton);
            this.RightPanel.Controls.Add(this.CloseButton);
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanel.Location = new System.Drawing.Point(277, 0);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(523, 450);
            this.RightPanel.TabIndex = 1;
            // 
            // ButtonAeroport
            // 
            this.ButtonAeroport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ButtonAeroport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAeroport.FlatAppearance.BorderSize = 0;
            this.ButtonAeroport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAeroport.Font = new System.Drawing.Font("Constantia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAeroport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.ButtonAeroport.Image = global::Companie_Aeriana.Properties.Resources._3127386;
            this.ButtonAeroport.Location = new System.Drawing.Point(288, 205);
            this.ButtonAeroport.Name = "ButtonAeroport";
            this.ButtonAeroport.Size = new System.Drawing.Size(185, 71);
            this.ButtonAeroport.TabIndex = 26;
            this.ButtonAeroport.Text = "Aeroport";
            this.ButtonAeroport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonAeroport.UseVisualStyleBackColor = false;
            this.ButtonAeroport.Click += new System.EventHandler(this.ButtonAeroport_Click);
            // 
            // ButtonRuta
            // 
            this.ButtonRuta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ButtonRuta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonRuta.FlatAppearance.BorderSize = 0;
            this.ButtonRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRuta.Font = new System.Drawing.Font("Constantia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRuta.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ButtonRuta.Image = global::Companie_Aeriana.Properties.Resources._1271827;
            this.ButtonRuta.Location = new System.Drawing.Point(311, 282);
            this.ButtonRuta.Name = "ButtonRuta";
            this.ButtonRuta.Size = new System.Drawing.Size(130, 71);
            this.ButtonRuta.TabIndex = 25;
            this.ButtonRuta.Text = "Ruta";
            this.ButtonRuta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonRuta.UseVisualStyleBackColor = false;
            this.ButtonRuta.Click += new System.EventHandler(this.ButtonRuta_Click);
            // 
            // ButtonPilot
            // 
            this.ButtonPilot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ButtonPilot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonPilot.FlatAppearance.BorderSize = 0;
            this.ButtonPilot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPilot.Font = new System.Drawing.Font("Constantia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPilot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.ButtonPilot.Image = global::Companie_Aeriana.Properties.Resources._996270;
            this.ButtonPilot.Location = new System.Drawing.Point(29, 282);
            this.ButtonPilot.Name = "ButtonPilot";
            this.ButtonPilot.Size = new System.Drawing.Size(137, 71);
            this.ButtonPilot.TabIndex = 24;
            this.ButtonPilot.Text = "Pilot";
            this.ButtonPilot.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonPilot.UseVisualStyleBackColor = false;
            this.ButtonPilot.Click += new System.EventHandler(this.ButtonPilot_Click);
            // 
            // ButtonAeronava
            // 
            this.ButtonAeronava.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ButtonAeronava.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAeronava.FlatAppearance.BorderSize = 0;
            this.ButtonAeronava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAeronava.Font = new System.Drawing.Font("Constantia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAeronava.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ButtonAeronava.Image = global::Companie_Aeriana.Properties.Resources._2376774_air_aircraft_airplane_flight_transportation_icon;
            this.ButtonAeronava.Location = new System.Drawing.Point(29, 359);
            this.ButtonAeronava.Name = "ButtonAeronava";
            this.ButtonAeronava.Size = new System.Drawing.Size(194, 71);
            this.ButtonAeronava.TabIndex = 23;
            this.ButtonAeronava.Text = "Aeronava";
            this.ButtonAeronava.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonAeronava.UseVisualStyleBackColor = false;
            this.ButtonAeronava.Click += new System.EventHandler(this.ButtonAeronava_Click);
            // 
            // ButtonZboruri
            // 
            this.ButtonZboruri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ButtonZboruri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonZboruri.FlatAppearance.BorderSize = 0;
            this.ButtonZboruri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonZboruri.Font = new System.Drawing.Font("Constantia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonZboruri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.ButtonZboruri.Image = global::Companie_Aeriana.Properties.Resources._3383442_flight_return_round_travel_trip_icon;
            this.ButtonZboruri.Location = new System.Drawing.Point(288, 359);
            this.ButtonZboruri.Name = "ButtonZboruri";
            this.ButtonZboruri.Size = new System.Drawing.Size(170, 71);
            this.ButtonZboruri.TabIndex = 22;
            this.ButtonZboruri.Text = "Zboruri";
            this.ButtonZboruri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonZboruri.UseVisualStyleBackColor = false;
            this.ButtonZboruri.Click += new System.EventHandler(this.ButtonZboruri_Click);
            // 
            // ButtonBilet
            // 
            this.ButtonBilet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ButtonBilet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonBilet.FlatAppearance.BorderSize = 0;
            this.ButtonBilet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBilet.Font = new System.Drawing.Font("Constantia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBilet.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ButtonBilet.Image = global::Companie_Aeriana.Properties.Resources._3938188_airplane_holiday_ticket_travel_icon;
            this.ButtonBilet.Location = new System.Drawing.Point(29, 205);
            this.ButtonBilet.Name = "ButtonBilet";
            this.ButtonBilet.Size = new System.Drawing.Size(129, 71);
            this.ButtonBilet.TabIndex = 21;
            this.ButtonBilet.Text = "Bilet";
            this.ButtonBilet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonBilet.UseVisualStyleBackColor = false;
            this.ButtonBilet.Click += new System.EventHandler(this.ButtonBilet_Click);
            // 
            // ButtonRezervare
            // 
            this.ButtonRezervare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ButtonRezervare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonRezervare.FlatAppearance.BorderSize = 0;
            this.ButtonRezervare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRezervare.Font = new System.Drawing.Font("Constantia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRezervare.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ButtonRezervare.Image = global::Companie_Aeriana.Properties.Resources._5094666_calendar_date_schedule_time_icon;
            this.ButtonRezervare.Location = new System.Drawing.Point(288, 128);
            this.ButtonRezervare.Name = "ButtonRezervare";
            this.ButtonRezervare.Size = new System.Drawing.Size(198, 65);
            this.ButtonRezervare.TabIndex = 20;
            this.ButtonRezervare.Text = "Rezervare";
            this.ButtonRezervare.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonRezervare.UseVisualStyleBackColor = false;
            this.ButtonRezervare.Click += new System.EventHandler(this.ButtonRezervare_Click);
            // 
            // ButtonClient
            // 
            this.ButtonClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ButtonClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonClient.FlatAppearance.BorderSize = 0;
            this.ButtonClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClient.Font = new System.Drawing.Font("Constantia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.ButtonClient.Image = global::Companie_Aeriana.Properties.Resources._2305630_account_id_man_person_profile_icon;
            this.ButtonClient.Location = new System.Drawing.Point(29, 128);
            this.ButtonClient.Name = "ButtonClient";
            this.ButtonClient.Size = new System.Drawing.Size(149, 65);
            this.ButtonClient.TabIndex = 19;
            this.ButtonClient.Text = "Client";
            this.ButtonClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonClient.UseVisualStyleBackColor = false;
            this.ButtonClient.Click += new System.EventHandler(this.ButtonClient_Click);
            this.ButtonClient.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonClient_MouseDown);
            this.ButtonClient.MouseLeave += new System.EventHandler(this.ButtonClient_MouseLeave);
            this.ButtonClient.MouseHover += new System.EventHandler(this.ButtonClient_MouseHover);
            this.ButtonClient.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonClient_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(178, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 33);
            this.label1.TabIndex = 18;
            this.label1.Text = "Dashboard";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Companie_Aeriana.Properties.Resources._6623003_airplane_fly_holidays_plane_summer_icon;
            this.pictureBox1.Location = new System.Drawing.Point(483, 412);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 26);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Move2
            // 
            this.Move2.BackColor = System.Drawing.Color.Transparent;
            this.Move2.Location = new System.Drawing.Point(0, 0);
            this.Move2.Name = "Move2";
            this.Move2.Size = new System.Drawing.Size(440, 34);
            this.Move2.TabIndex = 17;
            this.Move2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move2_MouseDown);
            this.Move2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Move2_MouseMove);
            this.Move2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Move2_MouseUp);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeButton.Location = new System.Drawing.Point(442, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(40, 34);
            this.MinimizeButton.TabIndex = 16;
            this.MinimizeButton.Text = "-";
            this.MinimizeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Location = new System.Drawing.Point(483, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(40, 34);
            this.CloseButton.TabIndex = 15;
            this.CloseButton.Text = "X";
            this.CloseButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.LeftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Select";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select";
            this.Load += new System.EventHandler(this.Select_Load);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.RightPanel.ResumeLayout(false);
            this.RightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        public System.Windows.Forms.Label user;
        public System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Button ButtonLogout;
        private System.Windows.Forms.Panel Move1;
        private System.Windows.Forms.Panel Move2;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonClient;
        private System.Windows.Forms.Button ButtonRezervare;
        private System.Windows.Forms.Button ButtonBilet;
        private System.Windows.Forms.Button ButtonZboruri;
        private System.Windows.Forms.Button ButtonAeronava;
        private System.Windows.Forms.Button ButtonPilot;
        private System.Windows.Forms.Button ButtonRuta;
        private System.Windows.Forms.Button ButtonAeroport;
        private System.Windows.Forms.Button button1;
    }
}