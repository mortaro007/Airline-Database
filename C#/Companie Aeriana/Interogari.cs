using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Companie_Aeriana
{
    public partial class Interogari : Form
    {
        private string select_case, option;
        public Interogari(string select_case, string option)
        {
            this.select_case = select_case;
            this.option = option;
            InitializeComponent();
        }

        private void cNPLabel_Click(object sender, EventArgs e)
        {

        }

        private void Interogari_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'companieAerianaDataSet.Rezervare' table. You can move, or remove it, as needed.
            this.rezervareTableAdapter.Fill(this.companieAerianaDataSet.Rezervare);
            // TODO: This line of code loads data into the 'companieAerianaDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.companieAerianaDataSet.Client);
            // TODO: This line of code loads data into the 'companieAerianaDataSet.Bilet' table. You can move, or remove it, as needed.
            this.biletTableAdapter.Fill(this.companieAerianaDataSet.Bilet);
            // TODO: This line of code loads data into the 'companieAerianaDataSet.Aeroport' table. You can move, or remove it, as needed.
            this.aeroportTableAdapter.Fill(this.companieAerianaDataSet.Aeroport);
            // TODO: This line of code loads data into the 'companieAerianaDataSet.Aeronava' table. You can move, or remove it, as needed.
            this.aeronavaTableAdapter1.Fill(this.companieAerianaDataSet.Aeronava);
            // TODO: This line of code loads data into the 'all.Pilot' table. You can move, or remove it, as needed.
            this.pilotTableAdapter.Fill(this.all.Pilot);
            // TODO: This line of code loads data into the 'all.Aeronava' table. You can move, or remove it, as needed.
            this.aeronavaTableAdapter.Fill(this.all.Aeronava);

            string username = Login.LabelUser;
            string password = Login.LabelPassword;
            String str = $"Data Source = DESKTOP-28Q28T1\\SQLEXPRESS1; database=CompanieAeriana; UID={username}; password={password}";
            SqlConnection con = new SqlConnection(str);
            con.Open();

            SqlCommand cmd = new SqlCommand("", con);
            DataTable dt = new DataTable();

            switch(select_case)
            {
            case ("PxA"):
            cmd.CommandText = $"select p.Id_pilot, a.Id_aeronava, p.Nume, p.Prenume, a.Nume_aeronava, a.Nr_locuri From Pilot p " +
                              $"Join Aeronava a on a.Id_aeronava = p.Id_aeronava order by Nr_locuri asc";
                     
                dt.Load(cmd.ExecuteReader());
                dataGridView1.DataSource = dt;
                break;

            case ("RxZ"):
            cmd.CommandText = $"select a.Cod_aeroport, a.Nume_aeroport, a.Tara, r.Id_ruta, r.Cod_plecare, r.Cod_destinatie from Aeroport a " +
                              $"Join Ruta_Aeroport ra on a.Cod_aeroport = ra.Cod_aeroport " +
                              $"Join Ruta r on r.Id_ruta = ra.Id_ruta";

                dt.Load(cmd.ExecuteReader());
                dataGridView1.DataSource = dt;
                break;

            case ("CxRezervare"):
            cmd.CommandText = $"select c.Nume, c.Prenume, c.CNP, r.Metoda_achizitie, r.Pret from Client c " +
                              $"Join Rezervare r on c.Id_client = r.Id_client " +
                              $"where r.Pret > 500 " +
                              $"order by r.Pret asc";

                dt.Load(cmd.ExecuteReader());
                dataGridView1.DataSource = dt;
                break;

            case ("BxAeronava"):
            cmd.CommandText = $"select b.Id_zbor,b.Tip_bilet, a.Id_aeronava, a.Nume_aeronava from Bilet b " +
                              $"Join Zbor z on b.Id_zbor = z.Id_zbor " +
                              $"Join Aeronava a on z.Id_aeronava = a.Id_aeronava " +
                              $"where b.Tip_bilet = 'Comfort'";

                dt.Load(cmd.ExecuteReader());
                dataGridView1.DataSource = dt;
                break;

            case ("ZxAeronava"):
            cmd.CommandText = $"select a.Nume_aeronava, z.Id_ruta, z.Data_zbor, a.Nr_locuri from Zbor z " +
                              $"Join Aeronava a on z.Id_aeronava = a.Id_aeronava " +
                              $"where a.Nr_locuri > 150 " +
                              $"order by Nr_locuri asc";

                dt.Load(cmd.ExecuteReader());
                dataGridView1.DataSource = dt;
                break;

            case ("CxZ"):
            cmd.CommandText = $"Select c.Nume, c.Prenume, r.Pret, b.Nr_loc, z.Data_zbor, z.Ora_decolare from Client c " +
                              $"Join Rezervare r on c.Id_client = r.Id_client " +
                              $"Join Bilet b on r.Id_rezervare = b.Id_rezervare " +
                              $"Join Zbor z on b.Id_zbor = z.Id_zbor " +
                              $"Where z.Ora_decolare > '09:00' " +
                              $"Order by Ora_decolare asc";

                dt.Load(cmd.ExecuteReader());
                dataGridView1.DataSource = dt;
                break;

            case ("SearchAeronave"):
            cmd.CommandText = $"Select a.Nume_aeronava, a.Id_aeronava, p.Id_pilot from Aeronava a " +
                              $"Join Pilot p on p.Id_aeronava = a.Id_aeronava " +
                              $"Where a.Id_aeronava in " +
                              $"(Select a.Id_aeronava from Aeronava " +
                              $"Where a.Nume_aeronava Like '%{option}%')";

                dt.Load(cmd.ExecuteReader());
                dataGridView1.DataSource = dt;
                break;

            case ("SearchCod"):
            cmd.CommandText = $"Select r.Cod_plecare, a.Nume_aeroport, z.Data_zbor from Aeroport a " +
                              $"join Ruta_Aeroport ra on ra.Cod_aeroport = a.Cod_aeroport " +
                              $"join Ruta r on r.Id_ruta = ra.Id_ruta " +
                              $"join Zbor z on z.Id_ruta = r.Id_ruta " +
                              $"where r.Cod_plecare = " +
                              $"(Select Cod_aeroport from Aeroport where Aeroport.Cod_aeroport = '{option}') " +
                              $"order by a.Cod_aeroport asc";

                dt.Load(cmd.ExecuteReader());
                dataGridView1.DataSource = dt;
                break;

            case ("SearchPilotID"):
            cmd.CommandText = $"Select p.Id_pilot, p.Nume, p.Prenume, a.Nume_aeronava from Pilot p " +
                              $"join Aeronava a on a.Id_aeronava = p.Id_aeronava " +
                              $"where p.Id_aeronava in " +
                              $"(Select Id_aeronava from Pilot where Pilot.Id_aeronava = {option}) " +
                              $"order by p.Nume asc";

                dt.Load(cmd.ExecuteReader());
                dataGridView1.DataSource = dt;
                break;

            case ("SearchTicketType"):
            cmd.CommandText = $"Select distinct b.Nr_loc, c.Nume, c.Prenume, r.Metoda_achizitie from Bilet b " +
                              $"join Rezervare r on b.Id_rezervare = r.Id_rezervare " +
                              $"join Client c on r.Id_client = c.Id_client " +
                              $"where b.Tip_bilet in " +
                              $"(Select Tip_bilet from Bilet where Bilet.Tip_bilet = '{option}') " +
                              $"order by Nr_loc desc ";

                dt.Load(cmd.ExecuteReader());
                dataGridView1.DataSource = dt;
                break;

            case ("Bilet"):
                    cmd.CommandText = $"Select * from Bilet";
                dt.Load(cmd.ExecuteReader());
                dataGridView1.DataSource = dt;
                break;

            case ("Aeroport"):
                cmd.CommandText = $"Select * from Aeroport";
                dt.Load(cmd.ExecuteReader());
                dataGridView1.DataSource = dt;
                break;

            case ("Pilot"):
                cmd.CommandText = $"Select * from Pilot";
                dt.Load(cmd.ExecuteReader());
                dataGridView1.DataSource = dt;
                break;

            case ("Ruta"):
                cmd.CommandText = $"Select * from Ruta";
                dt.Load(cmd.ExecuteReader());
                dataGridView1.DataSource = dt;
                break;

            case ("Aeronava"):
                cmd.CommandText = $"Select * from Aeronava";
                dt.Load(cmd.ExecuteReader());
                dataGridView1.DataSource = dt;
                break;

            case ("Zboruri"):
                cmd.CommandText = $"Select * from Zbor";
                dt.Load(cmd.ExecuteReader());
                dataGridView1.DataSource = dt;
                break;
            }
            con.Close();   
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
