using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace Companie_Aeriana
{
    public partial class Rezervare : Form
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

        private bool mouseDown;
        private Point lastLocation;

        public Rezervare()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
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
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Rezervare_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'companieAerianaDataSet.Rezervare' table. You can move, or remove it, as needed.
            this.rezervareTableAdapter.Fill(this.companieAerianaDataSet.Rezervare);


        }

        private void ButtonInsert_Click(object sender, EventArgs e)
        {
            string username = "Geo";
            string password = "admin";
            String str = $"Data Source = DESKTOP-28Q28T1\\SQLEXPRESS1; database=CompanieAeriana; UID={username}; password={password}";
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("insert into Rezervare values(NEXT VALUE FOR Id_rezervare_seq, @Id_client, @Data_achizitie, @Metoda_achizitie, @Pret); Select * from Rezervare", con);

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Id_rezervare", ID_TextBox.Text);
            cmd.Parameters.AddWithValue("@Id_client", IDClientTextBox1.Text);
            cmd.Parameters.AddWithValue("@Data_achizitie", Convert.ToDateTime(dataTextBox.Text));
            cmd.Parameters.AddWithValue("@Metoda_achizitie", metodaTextBox.Text);
            cmd.Parameters.AddWithValue("@Pret", pretTextBox.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Reservation inserted successfully");
            SqlCommand cmx = new SqlCommand("Select * from Rezervare", con);
            SqlDataAdapter da = new SqlDataAdapter(cmx);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string username = "Geo";
            string password = "admin";
            String str = $"Data Source = DESKTOP-28Q28T1\\SQLEXPRESS1; database=CompanieAeriana; UID={username}; password={password}";
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlCommand cmx = new SqlCommand("DELETE FROM Rezervare WHERE Id_rezervare='" + ID_TextBox.Text + "'; Select * from Rezervare", con);
            SqlDataAdapter da = new SqlDataAdapter(cmx);
            MessageBox.Show("Reservation deleted successfully");
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            string username = "Geo";
            string password = "admin";
            String str = $"Data Source = DESKTOP-28Q28T1\\SQLEXPRESS1; database=CompanieAeriana; UID={username}; password={password}";
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlCommand cmx = new SqlCommand("Select * from Rezervare", con);
            SqlDataAdapter da = new SqlDataAdapter(cmx);
            MessageBox.Show("Reservations refreshed successfully");
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string username = "Geo";
            string password = "admin";
            String str = $"Data Source = DESKTOP-28Q28T1\\SQLEXPRESS1; database=CompanieAeriana; UID={username}; password={password}";
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlCommand cmx = new SqlCommand("UPDATE Rezervare SET Data_achizitie='" + dataTextBox.Value + "',Metoda_achizitie='" + metodaTextBox.Text + "',Pret='" + pretTextBox.Text + "' WHERE Id_rezervare ='" + ID_TextBox.Text + "';Select * from Rezervare", con);
            SqlDataAdapter da = new SqlDataAdapter(cmx);
            MessageBox.Show("Reservation updated successfully");
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ID_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
