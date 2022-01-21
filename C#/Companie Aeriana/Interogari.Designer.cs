namespace Companie_Aeriana
{
    partial class Interogari
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.all = new Companie_Aeriana.All();
            this.allBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aeronavaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aeronavaTableAdapter = new Companie_Aeriana.AllTableAdapters.AeronavaTableAdapter();
            this.companieAerianaDataSet = new Companie_Aeriana.CompanieAerianaDataSet();
            this.companieAerianaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companieAerianaDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pilotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pilotTableAdapter = new Companie_Aeriana.AllTableAdapters.PilotTableAdapter();
            this.aeronavaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aeronavaTableAdapter1 = new Companie_Aeriana.CompanieAerianaDataSetTableAdapters.AeronavaTableAdapter();
            this.aeroportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aeroportTableAdapter = new Companie_Aeriana.CompanieAerianaDataSetTableAdapters.AeroportTableAdapter();
            this.biletBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.biletTableAdapter = new Companie_Aeriana.CompanieAerianaDataSetTableAdapters.BiletTableAdapter();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new Companie_Aeriana.CompanieAerianaDataSetTableAdapters.ClientTableAdapter();
            this.rezervareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rezervareTableAdapter = new Companie_Aeriana.CompanieAerianaDataSetTableAdapters.RezervareTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.all)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeronavaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companieAerianaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companieAerianaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companieAerianaDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeronavaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biletBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervareBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(621, 284);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // all
            // 
            this.all.DataSetName = "All";
            this.all.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // allBindingSource
            // 
            this.allBindingSource.DataSource = this.all;
            this.allBindingSource.Position = 0;
            // 
            // aeronavaBindingSource
            // 
            this.aeronavaBindingSource.DataMember = "Aeronava";
            this.aeronavaBindingSource.DataSource = this.allBindingSource;
            // 
            // aeronavaTableAdapter
            // 
            this.aeronavaTableAdapter.ClearBeforeFill = true;
            // 
            // companieAerianaDataSet
            // 
            this.companieAerianaDataSet.DataSetName = "CompanieAerianaDataSet";
            this.companieAerianaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // companieAerianaDataSetBindingSource
            // 
            this.companieAerianaDataSetBindingSource.DataSource = this.companieAerianaDataSet;
            this.companieAerianaDataSetBindingSource.Position = 0;
            // 
            // companieAerianaDataSetBindingSource1
            // 
            this.companieAerianaDataSetBindingSource1.DataSource = this.companieAerianaDataSet;
            this.companieAerianaDataSetBindingSource1.Position = 0;
            // 
            // pilotBindingSource
            // 
            this.pilotBindingSource.DataMember = "Pilot";
            this.pilotBindingSource.DataSource = this.allBindingSource;
            // 
            // pilotTableAdapter
            // 
            this.pilotTableAdapter.ClearBeforeFill = true;
            // 
            // aeronavaBindingSource1
            // 
            this.aeronavaBindingSource1.DataMember = "Aeronava";
            this.aeronavaBindingSource1.DataSource = this.companieAerianaDataSetBindingSource;
            // 
            // aeronavaTableAdapter1
            // 
            this.aeronavaTableAdapter1.ClearBeforeFill = true;
            // 
            // aeroportBindingSource
            // 
            this.aeroportBindingSource.DataMember = "Aeroport";
            this.aeroportBindingSource.DataSource = this.companieAerianaDataSetBindingSource;
            // 
            // aeroportTableAdapter
            // 
            this.aeroportTableAdapter.ClearBeforeFill = true;
            // 
            // biletBindingSource
            // 
            this.biletBindingSource.DataMember = "Bilet";
            this.biletBindingSource.DataSource = this.companieAerianaDataSetBindingSource;
            // 
            // biletTableAdapter
            // 
            this.biletTableAdapter.ClearBeforeFill = true;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.companieAerianaDataSetBindingSource;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
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
            // Interogari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 305);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Interogari";
            this.Text = "Interogari";
            this.Load += new System.EventHandler(this.Interogari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.all)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeronavaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companieAerianaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companieAerianaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companieAerianaDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeronavaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aeroportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biletBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervareBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource allBindingSource;
        private All all;
        private System.Windows.Forms.BindingSource aeronavaBindingSource;
        private AllTableAdapters.AeronavaTableAdapter aeronavaTableAdapter;
        private System.Windows.Forms.BindingSource companieAerianaDataSetBindingSource;
        private CompanieAerianaDataSet companieAerianaDataSet;
        private System.Windows.Forms.BindingSource companieAerianaDataSetBindingSource1;
        private System.Windows.Forms.BindingSource pilotBindingSource;
        private AllTableAdapters.PilotTableAdapter pilotTableAdapter;
        private System.Windows.Forms.BindingSource aeronavaBindingSource1;
        private CompanieAerianaDataSetTableAdapters.AeronavaTableAdapter aeronavaTableAdapter1;
        private System.Windows.Forms.BindingSource aeroportBindingSource;
        private CompanieAerianaDataSetTableAdapters.AeroportTableAdapter aeroportTableAdapter;
        private System.Windows.Forms.BindingSource biletBindingSource;
        private CompanieAerianaDataSetTableAdapters.BiletTableAdapter biletTableAdapter;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private CompanieAerianaDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.BindingSource rezervareBindingSource;
        private CompanieAerianaDataSetTableAdapters.RezervareTableAdapter rezervareTableAdapter;
    }
}