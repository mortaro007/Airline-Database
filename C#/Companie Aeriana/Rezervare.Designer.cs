namespace Companie_Aeriana
{
    partial class Rezervare
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label_ID;
            System.Windows.Forms.Label numeLabel;
            System.Windows.Forms.Label prenumeLabel;
            System.Windows.Forms.Label genLabel1;
            System.Windows.Forms.Label cNPLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ButtonRefresh = new System.Windows.Forms.Button();
            this.ButtonInsert = new System.Windows.Forms.Button();
            this.zborBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companieAerianaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companieAerianaDataSet = new Companie_Aeriana.CompanieAerianaDataSet();
            this.zborTableAdapter = new Companie_Aeriana.CompanieAerianaDataSetTableAdapters.ZborTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metodaTextBox = new System.Windows.Forms.ComboBox();
            this.dataTextBox = new System.Windows.Forms.DateTimePicker();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ID_TextBox = new System.Windows.Forms.TextBox();
            this.pretTextBox = new System.Windows.Forms.TextBox();
            this.IDClientTextBox1 = new System.Windows.Forms.TextBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.clientTableAdapter = new Companie_Aeriana.CompanieAerianaDataSetTableAdapters.ClientTableAdapter();
            this.rutaTableAdapter = new Companie_Aeriana.CompanieAerianaDataSetTableAdapters.RutaTableAdapter();
            this.rutaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aeronavaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aeronavaTableAdapter = new Companie_Aeriana.CompanieAerianaDataSetTableAdapters.AeronavaTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idrezervareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataachizitieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metodaachizitieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezervareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rezervareTableAdapter = new Companie_Aeriana.CompanieAerianaDataSetTableAdapters.RezervareTableAdapter();
            this.UpdateButton = new System.Windows.Forms.Button();
            label_ID = new System.Windows.Forms.Label();
            numeLabel = new System.Windows.Forms.Label();
            prenumeLabel = new System.Windows.Forms.Label();
            genLabel1 = new System.Windows.Forms.Label();
            cNPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zborBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companieAerianaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companieAerianaDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rutaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeronavaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervareBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label_ID
            // 
            label_ID.AutoSize = true;
            label_ID.BackColor = System.Drawing.Color.Transparent;
            label_ID.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_ID.Location = new System.Drawing.Point(6, 60);
            label_ID.Name = "label_ID";
            label_ID.Size = new System.Drawing.Size(100, 19);
            label_ID.TabIndex = 64;
            label_ID.Text = "ID rezervare:";
            // 
            // numeLabel
            // 
            numeLabel.AutoSize = true;
            numeLabel.BackColor = System.Drawing.Color.Transparent;
            numeLabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numeLabel.Location = new System.Drawing.Point(6, 95);
            numeLabel.Name = "numeLabel";
            numeLabel.Size = new System.Drawing.Size(71, 19);
            numeLabel.TabIndex = 30;
            numeLabel.Text = "Id_client";
            // 
            // prenumeLabel
            // 
            prenumeLabel.AutoSize = true;
            prenumeLabel.BackColor = System.Drawing.Color.Transparent;
            prenumeLabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prenumeLabel.Location = new System.Drawing.Point(6, 133);
            prenumeLabel.Name = "prenumeLabel";
            prenumeLabel.Size = new System.Drawing.Size(108, 19);
            prenumeLabel.TabIndex = 32;
            prenumeLabel.Text = "Data achizitie";
            // 
            // genLabel1
            // 
            genLabel1.AutoSize = true;
            genLabel1.BackColor = System.Drawing.Color.Transparent;
            genLabel1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            genLabel1.Location = new System.Drawing.Point(6, 174);
            genLabel1.Name = "genLabel1";
            genLabel1.Size = new System.Drawing.Size(128, 19);
            genLabel1.TabIndex = 53;
            genLabel1.Text = "Metoda achizitie";
            // 
            // cNPLabel
            // 
            cNPLabel.AutoSize = true;
            cNPLabel.BackColor = System.Drawing.Color.Transparent;
            cNPLabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cNPLabel.Location = new System.Drawing.Point(6, 211);
            cNPLabel.Name = "cNPLabel";
            cNPLabel.Size = new System.Drawing.Size(38, 19);
            cNPLabel.TabIndex = 36;
            cNPLabel.Text = "Pret";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(339, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(577, 13);
            this.panel3.TabIndex = 71;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // ButtonRefresh
            // 
            this.ButtonRefresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonRefresh.FlatAppearance.BorderSize = 0;
            this.ButtonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRefresh.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRefresh.ForeColor = System.Drawing.Color.Black;
            this.ButtonRefresh.Location = new System.Drawing.Point(786, 249);
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.Size = new System.Drawing.Size(119, 33);
            this.ButtonRefresh.TabIndex = 70;
            this.ButtonRefresh.Text = "Refresh";
            this.ButtonRefresh.UseVisualStyleBackColor = false;
            this.ButtonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // ButtonInsert
            // 
            this.ButtonInsert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonInsert.FlatAppearance.BorderSize = 0;
            this.ButtonInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonInsert.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonInsert.ForeColor = System.Drawing.Color.Black;
            this.ButtonInsert.Location = new System.Drawing.Point(365, 249);
            this.ButtonInsert.Name = "ButtonInsert";
            this.ButtonInsert.Size = new System.Drawing.Size(119, 33);
            this.ButtonInsert.TabIndex = 69;
            this.ButtonInsert.Text = "Insert";
            this.ButtonInsert.UseVisualStyleBackColor = false;
            this.ButtonInsert.Click += new System.EventHandler(this.ButtonInsert_Click);
            // 
            // zborBindingSource
            // 
            this.zborBindingSource.DataMember = "Zbor";
            this.zborBindingSource.DataSource = this.companieAerianaDataSetBindingSource;
            // 
            // companieAerianaDataSetBindingSource
            // 
            this.companieAerianaDataSetBindingSource.DataSource = this.companieAerianaDataSet;
            this.companieAerianaDataSetBindingSource.Position = 0;
            // 
            // companieAerianaDataSet
            // 
            this.companieAerianaDataSet.DataSetName = "CompanieAerianaDataSet";
            this.companieAerianaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zborTableAdapter
            // 
            this.zborTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.metodaTextBox);
            this.panel1.Controls.Add(this.dataTextBox);
            this.panel1.Controls.Add(this.ID_TextBox);
            this.panel1.Controls.Add(label_ID);
            this.panel1.Controls.Add(numeLabel);
            this.panel1.Controls.Add(this.pretTextBox);
            this.panel1.Controls.Add(this.IDClientTextBox1);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Controls.Add(prenumeLabel);
            this.panel1.Controls.Add(genLabel1);
            this.panel1.Controls.Add(cNPLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 309);
            this.panel1.TabIndex = 68;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 13);
            this.panel2.TabIndex = 63;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // metodaTextBox
            // 
            this.metodaTextBox.FormattingEnabled = true;
            this.metodaTextBox.Items.AddRange(new object[] {
            "Cash",
            "Online",
            "Ordin plata"});
            this.metodaTextBox.Location = new System.Drawing.Point(140, 174);
            this.metodaTextBox.Name = "metodaTextBox";
            this.metodaTextBox.Size = new System.Drawing.Size(184, 21);
            this.metodaTextBox.TabIndex = 75;
            this.metodaTextBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataTextBox
            // 
            this.dataTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientBindingSource, "Data_nasterii", true));
            this.dataTextBox.Location = new System.Drawing.Point(124, 132);
            this.dataTextBox.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dataTextBox.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.Size = new System.Drawing.Size(200, 20);
            this.dataTextBox.TabIndex = 66;
            this.dataTextBox.Value = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.companieAerianaDataSetBindingSource;
            // 
            // ID_TextBox
            // 
            this.ID_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Nume", true));
            this.ID_TextBox.Location = new System.Drawing.Point(124, 59);
            this.ID_TextBox.Name = "ID_TextBox";
            this.ID_TextBox.Size = new System.Drawing.Size(200, 20);
            this.ID_TextBox.TabIndex = 65;
            this.ID_TextBox.TextChanged += new System.EventHandler(this.ID_TextBox_TextChanged);
            // 
            // pretTextBox
            // 
            this.pretTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "CNP", true));
            this.pretTextBox.Location = new System.Drawing.Point(124, 210);
            this.pretTextBox.Name = "pretTextBox";
            this.pretTextBox.Size = new System.Drawing.Size(200, 20);
            this.pretTextBox.TabIndex = 37;
            // 
            // IDClientTextBox1
            // 
            this.IDClientTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Nume", true));
            this.IDClientTextBox1.Location = new System.Drawing.Point(124, 94);
            this.IDClientTextBox1.Name = "IDClientTextBox1";
            this.IDClientTextBox1.Size = new System.Drawing.Size(200, 20);
            this.IDClientTextBox1.TabIndex = 31;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CloseButton.BackgroundImage = global::Companie_Aeriana.Properties.Resources.arrow_right__1_;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Location = new System.Drawing.Point(18, 19);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(24, 24);
            this.CloseButton.TabIndex = 58;
            this.CloseButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.Black;
            this.buttonDelete.Location = new System.Drawing.Point(646, 249);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(119, 33);
            this.buttonDelete.TabIndex = 72;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // rutaTableAdapter
            // 
            this.rutaTableAdapter.ClearBeforeFill = true;
            // 
            // rutaBindingSource
            // 
            this.rutaBindingSource.DataMember = "Ruta";
            this.rutaBindingSource.DataSource = this.companieAerianaDataSetBindingSource;
            // 
            // aeronavaBindingSource
            // 
            this.aeronavaBindingSource.DataMember = "Aeronava";
            this.aeronavaBindingSource.DataSource = this.companieAerianaDataSetBindingSource;
            // 
            // aeronavaTableAdapter
            // 
            this.aeronavaTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Sienna;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idrezervareDataGridViewTextBoxColumn,
            this.idclientDataGridViewTextBoxColumn,
            this.dataachizitieDataGridViewTextBoxColumn,
            this.metodaachizitieDataGridViewTextBoxColumn,
            this.pretDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rezervareBindingSource;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridView1.Location = new System.Drawing.Point(365, 59);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView1.Size = new System.Drawing.Size(540, 171);
            this.dataGridView1.TabIndex = 73;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idrezervareDataGridViewTextBoxColumn
            // 
            this.idrezervareDataGridViewTextBoxColumn.DataPropertyName = "Id_rezervare";
            this.idrezervareDataGridViewTextBoxColumn.HeaderText = "Id_rezervare";
            this.idrezervareDataGridViewTextBoxColumn.Name = "idrezervareDataGridViewTextBoxColumn";
            // 
            // idclientDataGridViewTextBoxColumn
            // 
            this.idclientDataGridViewTextBoxColumn.DataPropertyName = "Id_client";
            this.idclientDataGridViewTextBoxColumn.HeaderText = "Id_client";
            this.idclientDataGridViewTextBoxColumn.Name = "idclientDataGridViewTextBoxColumn";
            // 
            // dataachizitieDataGridViewTextBoxColumn
            // 
            this.dataachizitieDataGridViewTextBoxColumn.DataPropertyName = "Data_achizitie";
            this.dataachizitieDataGridViewTextBoxColumn.HeaderText = "Data_achizitie";
            this.dataachizitieDataGridViewTextBoxColumn.Name = "dataachizitieDataGridViewTextBoxColumn";
            // 
            // metodaachizitieDataGridViewTextBoxColumn
            // 
            this.metodaachizitieDataGridViewTextBoxColumn.DataPropertyName = "Metoda_achizitie";
            this.metodaachizitieDataGridViewTextBoxColumn.HeaderText = "Metoda_achizitie";
            this.metodaachizitieDataGridViewTextBoxColumn.Name = "metodaachizitieDataGridViewTextBoxColumn";
            // 
            // pretDataGridViewTextBoxColumn
            // 
            this.pretDataGridViewTextBoxColumn.DataPropertyName = "Pret";
            this.pretDataGridViewTextBoxColumn.HeaderText = "Pret";
            this.pretDataGridViewTextBoxColumn.Name = "pretDataGridViewTextBoxColumn";
            // 
            // rezervareBindingSource
            // 
            this.rezervareBindingSource.DataMember = "Rezervare";
            this.rezervareBindingSource.DataSource = this.companieAerianaDataSetBindingSource;
            // 
            // rezervareTableAdapter
            // 
            this.rezervareTableAdapter.ClearBeforeFill = true;
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UpdateButton.FlatAppearance.BorderSize = 0;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.ForeColor = System.Drawing.Color.Black;
            this.UpdateButton.Location = new System.Drawing.Point(508, 249);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(119, 33);
            this.UpdateButton.TabIndex = 74;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // Rezervare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 309);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ButtonRefresh);
            this.Controls.Add(this.ButtonInsert);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rezervare";
            this.Text = "Rezervare";
            this.Load += new System.EventHandler(this.Rezervare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zborBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companieAerianaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companieAerianaDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rutaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeronavaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervareBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ButtonRefresh;
        private System.Windows.Forms.Button ButtonInsert;
        private System.Windows.Forms.BindingSource zborBindingSource;
        private System.Windows.Forms.BindingSource companieAerianaDataSetBindingSource;
        private CompanieAerianaDataSet companieAerianaDataSet;
        private CompanieAerianaDataSetTableAdapters.ZborTableAdapter zborTableAdapter;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ID_TextBox;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox pretTextBox;
        private System.Windows.Forms.TextBox IDClientTextBox1;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button buttonDelete;
        private CompanieAerianaDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private CompanieAerianaDataSetTableAdapters.RutaTableAdapter rutaTableAdapter;
        private System.Windows.Forms.BindingSource rutaBindingSource;
        private System.Windows.Forms.BindingSource aeronavaBindingSource;
        private CompanieAerianaDataSetTableAdapters.AeronavaTableAdapter aeronavaTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource rezervareBindingSource;
        private CompanieAerianaDataSetTableAdapters.RezervareTableAdapter rezervareTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idrezervareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataachizitieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn metodaachizitieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dataTextBox;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.ComboBox metodaTextBox;
    }
}