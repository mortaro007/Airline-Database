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
    public partial class Select : Form
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
        public static string username;
        public static string password;

        public Select()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Select_Load(object sender, EventArgs e)
        {
        }

        private void ButtonLogout_MouseDown(object sender, MouseEventArgs e)
        {
            ButtonLogout.BackColor = Color.FromArgb(128, 193, 255);
        }

        private void ButtonLogout_MouseUp(object sender, MouseEventArgs e)
        {
            ButtonLogout.BackColor = Color.FromArgb(24, 30, 53);
        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            var Login = new Login();
            Login.Show();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Move1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Move1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Move1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Move2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Move2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Move2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Left_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonClient_Click(object sender, EventArgs e)
        {
            Form1 nextForm = new Form1();
            nextForm.Show();
            //this.Hide();
        }

        private void ButtonClient_MouseHover(object sender, EventArgs e)
        {
        }

        private void ButtonClient_MouseLeave(object sender, EventArgs e)
        {
        }

        private void ButtonClient_MouseDown(object sender, MouseEventArgs e)
        {
            ButtonClient.BackColor = Color.FromArgb(128, 193, 255);
        }

        private void ButtonClient_MouseUp(object sender, MouseEventArgs e)
        {
            ButtonClient.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Interogari nextForm = new Interogari("Zboruri", "");
            nextForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Interogari nextForm = new Interogari("Zboruri", "");
            nextForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Select_Interogare nextForm = new Select_Interogare();
            nextForm.Show();
        }

        private void ButtonRezervare_Click(object sender, EventArgs e)
        {
            Rezervare nextForm = new Rezervare();
            nextForm.Show();
        }

        private void ButtonBilet_Click(object sender, EventArgs e)
        {
            Interogari nextForm = new Interogari("Bilet", "");
            nextForm.Show();
        }

        private void ButtonAeroport_Click(object sender, EventArgs e)
        {
            Interogari nextForm = new Interogari("Aeroport", "");
            nextForm.Show();
        }

        private void ButtonPilot_Click(object sender, EventArgs e)
        {
            Interogari nextForm = new Interogari("Pilot", "");
            nextForm.Show();
        }

        private void ButtonRuta_Click(object sender, EventArgs e)
        {
            Interogari nextForm = new Interogari("Ruta", "");
            nextForm.Show();
        }

        private void ButtonAeronava_Click(object sender, EventArgs e)
        {
            Interogari nextForm = new Interogari("Aeronava", "");
            nextForm.Show();
        }

        private void ButtonZboruri_Click(object sender, EventArgs e)
        {
            Interogari nextForm = new Interogari("Zboruri", "");
            nextForm.Show();
        }
    }
}
