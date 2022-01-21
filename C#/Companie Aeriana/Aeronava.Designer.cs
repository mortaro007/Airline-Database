namespace Companie_Aeriana
{
    partial class Aeronava
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
            System.Windows.Forms.Label numeLabel;
            System.Windows.Forms.Label prenumeLabel;
            System.Windows.Forms.Label genLabel1;
            System.Windows.Forms.Label data_nasteriiLabel;
            System.Windows.Forms.Label cNPLabel;
            System.Windows.Forms.Label nume_insotitorLabel;
            System.Windows.Forms.Label taraLabel;
            System.Windows.Forms.Label regiuneLabel;
            System.Windows.Forms.Label localitateLabel;
            System.Windows.Forms.Label stradaLabel;
            System.Windows.Forms.Label numarLabel;
            System.Windows.Forms.Label nr_telefonLabel;
            System.Windows.Forms.Label adresa_mailLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.clientTableAdapter = new Companie_Aeriana.CompanieAerianaDataSetTableAdapters.ClientTableAdapter();
            this.rutaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companieAerianaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companieAerianaDataSet = new Companie_Aeriana.CompanieAerianaDataSet();
            this.aeronavaTableAdapter = new Companie_Aeriana.CompanieAerianaDataSetTableAdapters.AeronavaTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rutaTableAdapter = new Companie_Aeriana.CompanieAerianaDataSetTableAdapters.RutaTableAdapter();
            this.adresa_mailTextBox = new System.Windows.Forms.TextBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nr_telefonTextBox = new System.Windows.Forms.TextBox();
            this.numarTextBox = new System.Windows.Forms.TextBox();
            this.stradaTextBox = new System.Windows.Forms.TextBox();
            this.localitateTextBox = new System.Windows.Forms.TextBox();
            this.regiuneTextBox = new System.Windows.Forms.TextBox();
            this.taraTextBox = new System.Windows.Forms.TextBox();
            this.nume_insotitorTextBox = new System.Windows.Forms.TextBox();
            this.aeronavaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ButtonRefresh = new System.Windows.Forms.Button();
            this.cNPTextBox = new System.Windows.Forms.TextBox();
            this.numeTextBox1 = new System.Windows.Forms.TextBox();
            this.prenumeTextBox = new System.Windows.Forms.TextBox();
            this.data_nasteriiDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.genTextBox = new System.Windows.Forms.TextBox();
            this.ButtonInsert = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.adresamailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrtelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datanasteriiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeinsotitorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regiuneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CloseButton = new System.Windows.Forms.Button();
            numeLabel = new System.Windows.Forms.Label();
            prenumeLabel = new System.Windows.Forms.Label();
            genLabel1 = new System.Windows.Forms.Label();
            data_nasteriiLabel = new System.Windows.Forms.Label();
            cNPLabel = new System.Windows.Forms.Label();
            nume_insotitorLabel = new System.Windows.Forms.Label();
            taraLabel = new System.Windows.Forms.Label();
            regiuneLabel = new System.Windows.Forms.Label();
            localitateLabel = new System.Windows.Forms.Label();
            stradaLabel = new System.Windows.Forms.Label();
            numarLabel = new System.Windows.Forms.Label();
            nr_telefonLabel = new System.Windows.Forms.Label();
            adresa_mailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rutaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companieAerianaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companieAerianaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeronavaBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // rutaBindingSource
            // 
            this.rutaBindingSource.DataMember = "Ruta";
            this.rutaBindingSource.DataSource = this.companieAerianaDataSetBindingSource;
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
            // aeronavaTableAdapter
            // 
            this.aeronavaTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 13);
            this.panel2.TabIndex = 63;
            // 
            // rutaTableAdapter
            // 
            this.rutaTableAdapter.ClearBeforeFill = true;
            // 
            // adresa_mailTextBox
            // 
            this.adresa_mailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Adresa_mail", true));
            this.adresa_mailTextBox.Location = new System.Drawing.Point(124, 384);
            this.adresa_mailTextBox.Name = "adresa_mailTextBox";
            this.adresa_mailTextBox.Size = new System.Drawing.Size(200, 20);
            this.adresa_mailTextBox.TabIndex = 54;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.companieAerianaDataSetBindingSource;
            // 
            // nr_telefonTextBox
            // 
            this.nr_telefonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Nr_telefon", true));
            this.nr_telefonTextBox.Location = new System.Drawing.Point(124, 356);
            this.nr_telefonTextBox.Name = "nr_telefonTextBox";
            this.nr_telefonTextBox.Size = new System.Drawing.Size(200, 20);
            this.nr_telefonTextBox.TabIndex = 51;
            // 
            // numarTextBox
            // 
            this.numarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Numar", true));
            this.numarTextBox.Location = new System.Drawing.Point(124, 330);
            this.numarTextBox.Name = "numarTextBox";
            this.numarTextBox.Size = new System.Drawing.Size(200, 20);
            this.numarTextBox.TabIndex = 49;
            // 
            // stradaTextBox
            // 
            this.stradaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Strada", true));
            this.stradaTextBox.Location = new System.Drawing.Point(124, 303);
            this.stradaTextBox.Name = "stradaTextBox";
            this.stradaTextBox.Size = new System.Drawing.Size(200, 20);
            this.stradaTextBox.TabIndex = 47;
            // 
            // localitateTextBox
            // 
            this.localitateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Localitate", true));
            this.localitateTextBox.Location = new System.Drawing.Point(124, 277);
            this.localitateTextBox.Name = "localitateTextBox";
            this.localitateTextBox.Size = new System.Drawing.Size(200, 20);
            this.localitateTextBox.TabIndex = 45;
            // 
            // regiuneTextBox
            // 
            this.regiuneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Regiune", true));
            this.regiuneTextBox.Location = new System.Drawing.Point(124, 248);
            this.regiuneTextBox.Name = "regiuneTextBox";
            this.regiuneTextBox.Size = new System.Drawing.Size(200, 20);
            this.regiuneTextBox.TabIndex = 43;
            // 
            // taraTextBox
            // 
            this.taraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Tara", true));
            this.taraTextBox.Location = new System.Drawing.Point(124, 223);
            this.taraTextBox.Name = "taraTextBox";
            this.taraTextBox.Size = new System.Drawing.Size(200, 20);
            this.taraTextBox.TabIndex = 41;
            // 
            // nume_insotitorTextBox
            // 
            this.nume_insotitorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Nume_insotitor", true));
            this.nume_insotitorTextBox.Location = new System.Drawing.Point(124, 194);
            this.nume_insotitorTextBox.Name = "nume_insotitorTextBox";
            this.nume_insotitorTextBox.Size = new System.Drawing.Size(200, 20);
            this.nume_insotitorTextBox.TabIndex = 39;
            // 
            // aeronavaBindingSource
            // 
            this.aeronavaBindingSource.DataMember = "Aeronava";
            this.aeronavaBindingSource.DataSource = this.companieAerianaDataSetBindingSource;
            // 
            // ButtonRefresh
            // 
            this.ButtonRefresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonRefresh.FlatAppearance.BorderSize = 0;
            this.ButtonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRefresh.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRefresh.ForeColor = System.Drawing.Color.Black;
            this.ButtonRefresh.Location = new System.Drawing.Point(766, 371);
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.Size = new System.Drawing.Size(119, 33);
            this.ButtonRefresh.TabIndex = 68;
            this.ButtonRefresh.Text = "Refresh";
            this.ButtonRefresh.UseVisualStyleBackColor = false;
            // 
            // cNPTextBox
            // 
            this.cNPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "CNP", true));
            this.cNPTextBox.Location = new System.Drawing.Point(124, 168);
            this.cNPTextBox.Name = "cNPTextBox";
            this.cNPTextBox.Size = new System.Drawing.Size(200, 20);
            this.cNPTextBox.TabIndex = 37;
            // 
            // numeTextBox1
            // 
            this.numeTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Nume", true));
            this.numeTextBox1.Location = new System.Drawing.Point(124, 51);
            this.numeTextBox1.Name = "numeTextBox1";
            this.numeTextBox1.Size = new System.Drawing.Size(200, 20);
            this.numeTextBox1.TabIndex = 31;
            // 
            // prenumeTextBox
            // 
            this.prenumeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Prenume", true));
            this.prenumeTextBox.Location = new System.Drawing.Point(124, 79);
            this.prenumeTextBox.Name = "prenumeTextBox";
            this.prenumeTextBox.Size = new System.Drawing.Size(200, 20);
            this.prenumeTextBox.TabIndex = 33;
            // 
            // data_nasteriiDateTimePicker
            // 
            this.data_nasteriiDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientBindingSource, "Data_nasterii", true));
            this.data_nasteriiDateTimePicker.Location = new System.Drawing.Point(124, 139);
            this.data_nasteriiDateTimePicker.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.data_nasteriiDateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.data_nasteriiDateTimePicker.Name = "data_nasteriiDateTimePicker";
            this.data_nasteriiDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.data_nasteriiDateTimePicker.TabIndex = 35;
            this.data_nasteriiDateTimePicker.Value = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.adresa_mailTextBox);
            this.panel1.Controls.Add(numeLabel);
            this.panel1.Controls.Add(this.nr_telefonTextBox);
            this.panel1.Controls.Add(this.numarTextBox);
            this.panel1.Controls.Add(this.stradaTextBox);
            this.panel1.Controls.Add(this.localitateTextBox);
            this.panel1.Controls.Add(this.regiuneTextBox);
            this.panel1.Controls.Add(this.taraTextBox);
            this.panel1.Controls.Add(this.nume_insotitorTextBox);
            this.panel1.Controls.Add(this.cNPTextBox);
            this.panel1.Controls.Add(this.numeTextBox1);
            this.panel1.Controls.Add(this.genTextBox);
            this.panel1.Controls.Add(this.prenumeTextBox);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Controls.Add(prenumeLabel);
            this.panel1.Controls.Add(genLabel1);
            this.panel1.Controls.Add(this.data_nasteriiDateTimePicker);
            this.panel1.Controls.Add(data_nasteriiLabel);
            this.panel1.Controls.Add(cNPLabel);
            this.panel1.Controls.Add(nume_insotitorLabel);
            this.panel1.Controls.Add(taraLabel);
            this.panel1.Controls.Add(regiuneLabel);
            this.panel1.Controls.Add(localitateLabel);
            this.panel1.Controls.Add(stradaLabel);
            this.panel1.Controls.Add(numarLabel);
            this.panel1.Controls.Add(nr_telefonLabel);
            this.panel1.Controls.Add(adresa_mailLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 472);
            this.panel1.TabIndex = 66;
            // 
            // numeLabel
            // 
            numeLabel.AutoSize = true;
            numeLabel.BackColor = System.Drawing.Color.Transparent;
            numeLabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numeLabel.Location = new System.Drawing.Point(14, 52);
            numeLabel.Name = "numeLabel";
            numeLabel.Size = new System.Drawing.Size(56, 19);
            numeLabel.TabIndex = 30;
            numeLabel.Text = "Nume:";
            // 
            // genTextBox
            // 
            this.genTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "Gen", true));
            this.genTextBox.ForeColor = System.Drawing.Color.Black;
            this.genTextBox.Location = new System.Drawing.Point(124, 107);
            this.genTextBox.Name = "genTextBox";
            this.genTextBox.Size = new System.Drawing.Size(200, 20);
            this.genTextBox.TabIndex = 55;
            // 
            // prenumeLabel
            // 
            prenumeLabel.AutoSize = true;
            prenumeLabel.BackColor = System.Drawing.Color.Transparent;
            prenumeLabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prenumeLabel.Location = new System.Drawing.Point(14, 80);
            prenumeLabel.Name = "prenumeLabel";
            prenumeLabel.Size = new System.Drawing.Size(76, 19);
            prenumeLabel.TabIndex = 32;
            prenumeLabel.Text = "Prenume:";
            // 
            // genLabel1
            // 
            genLabel1.AutoSize = true;
            genLabel1.BackColor = System.Drawing.Color.Transparent;
            genLabel1.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            genLabel1.Location = new System.Drawing.Point(14, 108);
            genLabel1.Name = "genLabel1";
            genLabel1.Size = new System.Drawing.Size(41, 19);
            genLabel1.TabIndex = 53;
            genLabel1.Text = "Gen:";
            // 
            // data_nasteriiLabel
            // 
            data_nasteriiLabel.AutoSize = true;
            data_nasteriiLabel.BackColor = System.Drawing.Color.Transparent;
            data_nasteriiLabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            data_nasteriiLabel.Location = new System.Drawing.Point(14, 140);
            data_nasteriiLabel.Name = "data_nasteriiLabel";
            data_nasteriiLabel.Size = new System.Drawing.Size(104, 19);
            data_nasteriiLabel.TabIndex = 34;
            data_nasteriiLabel.Text = "Data nasterii:";
            // 
            // cNPLabel
            // 
            cNPLabel.AutoSize = true;
            cNPLabel.BackColor = System.Drawing.Color.Transparent;
            cNPLabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cNPLabel.Location = new System.Drawing.Point(14, 169);
            cNPLabel.Name = "cNPLabel";
            cNPLabel.Size = new System.Drawing.Size(44, 19);
            cNPLabel.TabIndex = 36;
            cNPLabel.Text = "CNP:";
            // 
            // nume_insotitorLabel
            // 
            nume_insotitorLabel.AutoSize = true;
            nume_insotitorLabel.BackColor = System.Drawing.Color.Transparent;
            nume_insotitorLabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nume_insotitorLabel.Location = new System.Drawing.Point(14, 195);
            nume_insotitorLabel.Name = "nume_insotitorLabel";
            nume_insotitorLabel.Size = new System.Drawing.Size(74, 19);
            nume_insotitorLabel.TabIndex = 38;
            nume_insotitorLabel.Text = "Insotitor:";
            // 
            // taraLabel
            // 
            taraLabel.AutoSize = true;
            taraLabel.BackColor = System.Drawing.Color.Transparent;
            taraLabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            taraLabel.Location = new System.Drawing.Point(14, 222);
            taraLabel.Name = "taraLabel";
            taraLabel.Size = new System.Drawing.Size(44, 19);
            taraLabel.TabIndex = 40;
            taraLabel.Text = "Tara:";
            // 
            // regiuneLabel
            // 
            regiuneLabel.AutoSize = true;
            regiuneLabel.BackColor = System.Drawing.Color.Transparent;
            regiuneLabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            regiuneLabel.Location = new System.Drawing.Point(14, 247);
            regiuneLabel.Name = "regiuneLabel";
            regiuneLabel.Size = new System.Drawing.Size(70, 19);
            regiuneLabel.TabIndex = 42;
            regiuneLabel.Text = "Regiune:";
            // 
            // localitateLabel
            // 
            localitateLabel.AutoSize = true;
            localitateLabel.BackColor = System.Drawing.Color.Transparent;
            localitateLabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            localitateLabel.Location = new System.Drawing.Point(14, 277);
            localitateLabel.Name = "localitateLabel";
            localitateLabel.Size = new System.Drawing.Size(84, 19);
            localitateLabel.TabIndex = 44;
            localitateLabel.Text = "Localitate:";
            // 
            // stradaLabel
            // 
            stradaLabel.AutoSize = true;
            stradaLabel.BackColor = System.Drawing.Color.Transparent;
            stradaLabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stradaLabel.Location = new System.Drawing.Point(14, 304);
            stradaLabel.Name = "stradaLabel";
            stradaLabel.Size = new System.Drawing.Size(58, 19);
            stradaLabel.TabIndex = 46;
            stradaLabel.Text = "Strada:";
            // 
            // numarLabel
            // 
            numarLabel.AutoSize = true;
            numarLabel.BackColor = System.Drawing.Color.Transparent;
            numarLabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numarLabel.Location = new System.Drawing.Point(14, 330);
            numarLabel.Name = "numarLabel";
            numarLabel.Size = new System.Drawing.Size(62, 19);
            numarLabel.TabIndex = 48;
            numarLabel.Text = "Numar:";
            // 
            // nr_telefonLabel
            // 
            nr_telefonLabel.AutoSize = true;
            nr_telefonLabel.BackColor = System.Drawing.Color.Transparent;
            nr_telefonLabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nr_telefonLabel.Location = new System.Drawing.Point(14, 357);
            nr_telefonLabel.Name = "nr_telefonLabel";
            nr_telefonLabel.Size = new System.Drawing.Size(84, 19);
            nr_telefonLabel.TabIndex = 50;
            nr_telefonLabel.Text = "Nr telefon:";
            // 
            // adresa_mailLabel
            // 
            adresa_mailLabel.AutoSize = true;
            adresa_mailLabel.BackColor = System.Drawing.Color.Transparent;
            adresa_mailLabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            adresa_mailLabel.Location = new System.Drawing.Point(14, 385);
            adresa_mailLabel.Name = "adresa_mailLabel";
            adresa_mailLabel.Size = new System.Drawing.Size(54, 19);
            adresa_mailLabel.TabIndex = 52;
            adresa_mailLabel.Text = "Email:";
            // 
            // ButtonInsert
            // 
            this.ButtonInsert.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonInsert.FlatAppearance.BorderSize = 0;
            this.ButtonInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonInsert.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonInsert.ForeColor = System.Drawing.Color.Black;
            this.ButtonInsert.Location = new System.Drawing.Point(345, 371);
            this.ButtonInsert.Name = "ButtonInsert";
            this.ButtonInsert.Size = new System.Drawing.Size(119, 33);
            this.ButtonInsert.TabIndex = 67;
            this.ButtonInsert.Text = "Insert";
            this.ButtonInsert.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(337, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(558, 13);
            this.panel3.TabIndex = 69;
            // 
            // adresamailDataGridViewTextBoxColumn
            // 
            this.adresamailDataGridViewTextBoxColumn.DataPropertyName = "Adresa_mail";
            this.adresamailDataGridViewTextBoxColumn.HeaderText = "Adresa_mail";
            this.adresamailDataGridViewTextBoxColumn.Name = "adresamailDataGridViewTextBoxColumn";
            // 
            // nrtelefonDataGridViewTextBoxColumn
            // 
            this.nrtelefonDataGridViewTextBoxColumn.DataPropertyName = "Nr_telefon";
            this.nrtelefonDataGridViewTextBoxColumn.HeaderText = "Nr_telefon";
            this.nrtelefonDataGridViewTextBoxColumn.Name = "nrtelefonDataGridViewTextBoxColumn";
            // 
            // idclientDataGridViewTextBoxColumn
            // 
            this.idclientDataGridViewTextBoxColumn.DataPropertyName = "Id_client";
            this.idclientDataGridViewTextBoxColumn.HeaderText = "Id_client";
            this.idclientDataGridViewTextBoxColumn.Name = "idclientDataGridViewTextBoxColumn";
            // 
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "Nume";
            this.numeDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            // 
            // prenumeDataGridViewTextBoxColumn
            // 
            this.prenumeDataGridViewTextBoxColumn.DataPropertyName = "Prenume";
            this.prenumeDataGridViewTextBoxColumn.HeaderText = "Prenume";
            this.prenumeDataGridViewTextBoxColumn.Name = "prenumeDataGridViewTextBoxColumn";
            // 
            // genDataGridViewTextBoxColumn
            // 
            this.genDataGridViewTextBoxColumn.DataPropertyName = "Gen";
            this.genDataGridViewTextBoxColumn.HeaderText = "Gen";
            this.genDataGridViewTextBoxColumn.Name = "genDataGridViewTextBoxColumn";
            // 
            // datanasteriiDataGridViewTextBoxColumn
            // 
            this.datanasteriiDataGridViewTextBoxColumn.DataPropertyName = "Data_nasterii";
            this.datanasteriiDataGridViewTextBoxColumn.HeaderText = "Data_nasterii";
            this.datanasteriiDataGridViewTextBoxColumn.Name = "datanasteriiDataGridViewTextBoxColumn";
            // 
            // cNPDataGridViewTextBoxColumn
            // 
            this.cNPDataGridViewTextBoxColumn.DataPropertyName = "CNP";
            this.cNPDataGridViewTextBoxColumn.HeaderText = "CNP";
            this.cNPDataGridViewTextBoxColumn.Name = "cNPDataGridViewTextBoxColumn";
            // 
            // numeinsotitorDataGridViewTextBoxColumn
            // 
            this.numeinsotitorDataGridViewTextBoxColumn.DataPropertyName = "Nume_insotitor";
            this.numeinsotitorDataGridViewTextBoxColumn.HeaderText = "Nume_insotitor";
            this.numeinsotitorDataGridViewTextBoxColumn.Name = "numeinsotitorDataGridViewTextBoxColumn";
            // 
            // taraDataGridViewTextBoxColumn
            // 
            this.taraDataGridViewTextBoxColumn.DataPropertyName = "Tara";
            this.taraDataGridViewTextBoxColumn.HeaderText = "Tara";
            this.taraDataGridViewTextBoxColumn.Name = "taraDataGridViewTextBoxColumn";
            // 
            // regiuneDataGridViewTextBoxColumn
            // 
            this.regiuneDataGridViewTextBoxColumn.DataPropertyName = "Regiune";
            this.regiuneDataGridViewTextBoxColumn.HeaderText = "Regiune";
            this.regiuneDataGridViewTextBoxColumn.Name = "regiuneDataGridViewTextBoxColumn";
            // 
            // localitateDataGridViewTextBoxColumn
            // 
            this.localitateDataGridViewTextBoxColumn.DataPropertyName = "Localitate";
            this.localitateDataGridViewTextBoxColumn.HeaderText = "Localitate";
            this.localitateDataGridViewTextBoxColumn.Name = "localitateDataGridViewTextBoxColumn";
            // 
            // stradaDataGridViewTextBoxColumn
            // 
            this.stradaDataGridViewTextBoxColumn.DataPropertyName = "Strada";
            this.stradaDataGridViewTextBoxColumn.HeaderText = "Strada";
            this.stradaDataGridViewTextBoxColumn.Name = "stradaDataGridViewTextBoxColumn";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Sienna;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idclientDataGridViewTextBoxColumn,
            this.numeDataGridViewTextBoxColumn,
            this.prenumeDataGridViewTextBoxColumn,
            this.genDataGridViewTextBoxColumn,
            this.datanasteriiDataGridViewTextBoxColumn,
            this.cNPDataGridViewTextBoxColumn,
            this.numeinsotitorDataGridViewTextBoxColumn,
            this.taraDataGridViewTextBoxColumn,
            this.regiuneDataGridViewTextBoxColumn,
            this.localitateDataGridViewTextBoxColumn,
            this.stradaDataGridViewTextBoxColumn,
            this.numarDataGridViewTextBoxColumn,
            this.nrtelefonDataGridViewTextBoxColumn,
            this.adresamailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridView1.Location = new System.Drawing.Point(345, 51);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(540, 297);
            this.dataGridView1.TabIndex = 65;
            // 
            // numarDataGridViewTextBoxColumn
            // 
            this.numarDataGridViewTextBoxColumn.DataPropertyName = "Numar";
            this.numarDataGridViewTextBoxColumn.HeaderText = "Numar";
            this.numarDataGridViewTextBoxColumn.Name = "numarDataGridViewTextBoxColumn";
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
            // Aeronava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 472);
            this.Controls.Add(this.ButtonRefresh);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonInsert);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Aeronava";
            this.Text = "Aeronava";
            ((System.ComponentModel.ISupportInitialize)(this.rutaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companieAerianaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companieAerianaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeronavaBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CompanieAerianaDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.BindingSource rutaBindingSource;
        private System.Windows.Forms.BindingSource companieAerianaDataSetBindingSource;
        private CompanieAerianaDataSet companieAerianaDataSet;
        private CompanieAerianaDataSetTableAdapters.AeronavaTableAdapter aeronavaTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private CompanieAerianaDataSetTableAdapters.RutaTableAdapter rutaTableAdapter;
        private System.Windows.Forms.TextBox adresa_mailTextBox;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.TextBox nr_telefonTextBox;
        private System.Windows.Forms.TextBox numarTextBox;
        private System.Windows.Forms.TextBox stradaTextBox;
        private System.Windows.Forms.TextBox localitateTextBox;
        private System.Windows.Forms.TextBox regiuneTextBox;
        private System.Windows.Forms.TextBox taraTextBox;
        private System.Windows.Forms.TextBox nume_insotitorTextBox;
        private System.Windows.Forms.BindingSource aeronavaBindingSource;
        private System.Windows.Forms.Button ButtonRefresh;
        private System.Windows.Forms.TextBox cNPTextBox;
        private System.Windows.Forms.TextBox numeTextBox1;
        private System.Windows.Forms.TextBox prenumeTextBox;
        private System.Windows.Forms.DateTimePicker data_nasteriiDateTimePicker;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox genTextBox;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button ButtonInsert;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresamailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrtelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datanasteriiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeinsotitorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regiuneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numarDataGridViewTextBoxColumn;
    }
}