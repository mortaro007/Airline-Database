using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Companie_Aeriana
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // width of ellipse
           int nHeightEllipse // height of ellipse
       );
        public object CompanieAerianaDataSet { get; private set; }
        private bool mouseDown;
        private Point lastLocation;

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'companieAerianaDataSet.Zbor' table. You can move, or remove it, as needed.
            this.zborTableAdapter.Fill(this.companieAerianaDataSet.Zbor);
            // TODO: This line of code loads data into the 'companieAerianaDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.companieAerianaDataSet.Client);
            // TODO: This line of code loads data into the 'companieAerianaDataSet.Ruta' table. You can move, or remove it, as needed.
            this.rutaTableAdapter.Fill(this.companieAerianaDataSet.Ruta);
            // TODO: This line of code loads data into the 'companieAerianaDataSet.Aeronava' table. You can move, or remove it, as needed.
            this.aeronavaTableAdapter.Fill(this.companieAerianaDataSet.Aeronava);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void numeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void regiuneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void ButtonInsert_Click(object sender, EventArgs e)
        {
            string username = Login.LabelUser;
            string password = Login.LabelPassword;
            String str = $"Data Source = DESKTOP-28Q28T1\\SQLEXPRESS1; database=CompanieAeriana; UID={username}; password={password}";
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("insert into Client values(NEXT VALUE FOR Id_client_seq, @Nume, @Prenume, @Gen, @DataNasterii, @CNP, @Insotitor, @Tara, @Regiune, @Localitate, @Strada, @Numar, @NrTelefon, @Mail); Select * from Client", con);

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Nume", numeTextBox1.Text);
            cmd.Parameters.AddWithValue("@Prenume", prenumeTextBox.Text);
            cmd.Parameters.AddWithValue("@Gen", genTextBox.Text);
            cmd.Parameters.AddWithValue("@DataNasterii", Convert.ToDateTime(data_nasteriiTextBox.Text));
            cmd.Parameters.AddWithValue("@CNP", cNPTextBox.Text);
            cmd.Parameters.AddWithValue("@Insotitor", nume_insotitorTextBox.Text);
            cmd.Parameters.AddWithValue("@Tara", taraTextBox.Text);
            cmd.Parameters.AddWithValue("@Regiune", regiuneTextBox.Text);
            cmd.Parameters.AddWithValue("@Localitate", localitateTextBox.Text);
            cmd.Parameters.AddWithValue("@Strada", stradaTextBox.Text);
            cmd.Parameters.AddWithValue("@Numar", numarTextBox.Text);
            cmd.Parameters.AddWithValue("@NrTelefon", nr_telefonTextBox.Text);
            cmd.Parameters.AddWithValue("@Mail", adresa_mailTextBox.Text);
            con.Open();

            cmd.ExecuteNonQuery();
            MessageBox.Show("Client inserted successfully");
            SqlCommand cmx = new SqlCommand("Select * from Client", con);
            SqlDataAdapter da = new SqlDataAdapter(cmx);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            string username = Login.LabelUser;
            string password = Login.LabelPassword;
            String str = $"Data Source = DESKTOP-28Q28T1\\SQLEXPRESS1; database=CompanieAeriana; UID={username}; password={password}";
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("insert into Client values(NEXT VALUE FOR Id_client_seq, @Nume, @Prenume, @Gen, @DataNasterii, @CNP, @Insotitor, @Tara, @Regiune, @Localitate, @Strada, @Numar, @NrTelefon, @Mail)", con);
            con.Open();
            SqlCommand cmx = new SqlCommand("Select * from Client", con);
            SqlDataAdapter da = new SqlDataAdapter(cmx);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void nume_insotitorLabel_Click(object sender, EventArgs e)
        {

        }

        private void nr_telefonTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void genLabel1_Click(object sender, EventArgs e)
        {

        }

        private void numeLabel_Click(object sender, EventArgs e)
        {

        }

        private void prenumeLabel_Click(object sender, EventArgs e)
        {

        }

        private void data_nasteriiLabel_Click(object sender, EventArgs e)
        {

        }

        private void cNPLabel_Click(object sender, EventArgs e)
        {

        }

        private void taraLabel_Click(object sender, EventArgs e)
        {

        }

        private void regiuneLabel_Click(object sender, EventArgs e)
        {

        }

        private void localitateLabel_Click(object sender, EventArgs e)
        {

        }

        private void stradaLabel_Click(object sender, EventArgs e)
        {

        }

        private void numarLabel_Click(object sender, EventArgs e)
        {

        }

        private void nr_telefonLabel_Click(object sender, EventArgs e)
        {

        }

        private void adresa_mailLabel_Click(object sender, EventArgs e)
        {

        }

        private void clientBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void companieAerianaDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void aeronavaBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void rutaBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void genTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void prenumeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void data_nasteriiDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cNPTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nume_insotitorTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void taraTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void localitateTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void stradaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void numarTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void adresa_mailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string username = Login.LabelUser;
            string password = Login.LabelPassword;
            String str = $"Data Source = DESKTOP-28Q28T1\\SQLEXPRESS1; database=CompanieAeriana; UID={username}; password={password}";
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlCommand cmx = new SqlCommand("DELETE FROM Client WHERE Id_client='" + ID_TextBox.Text + "'; Select * from Client", con);
            SqlDataAdapter da = new SqlDataAdapter(cmx);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string username = Login.LabelUser;
            string password = Login.LabelPassword;
            String str = $"Data Source = DESKTOP-28Q28T1\\SQLEXPRESS1; database=CompanieAeriana; UID={username}; password={password}";
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlCommand cmx = new SqlCommand("UPDATE Client SET Nume='" + numeTextBox1.Text + "' AND Prenume='" + prenumeTextBox.Text +
                "' AND Gen='" + genTextBox.Text + "' AND Data_nasterii='" + data_nasteriiTextBox.Value + "' AND CNP='" + cNPTextBox.Text +
                "' AND Nume_insotitor='" + nume_insotitorTextBox.Text + "' AND Tara='" + taraTextBox.Text + "' AND Regiune='" + regiuneTextBox.Text +
                "' AND Localitate='" + localitateTextBox.Text + "' AND Strada='" + stradaTextBox.Text + "' AND Numar='" + numarTextBox.Text +
                "' AND Nr_telefon='" + nr_telefonTextBox.Text + "' AND Adresa_mail='" + adresa_mailTextBox.Text +
                "' WHERE Id_client ='" + ID_TextBox.Text + "'; Select * from Client", con);
            SqlDataAdapter da = new SqlDataAdapter(cmx);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
