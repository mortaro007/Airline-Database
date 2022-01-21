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
    public partial class Login : Form
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
        public static string LabelUser;
        public static string LabelPassword;

        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void ContactAdmin_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkMail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:airology@gmail.com");
        }

        private void textBoxUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUser_Click(object sender, EventArgs e)
        {
            if (textBoxUser.Text == "User")
            {
                textBoxUser.Text = "";
            }

            textBoxUser.BackColor = Color.White;
            userBig.BackColor = Color.White;
            textBoxPassword.BackColor = SystemColors.Menu;
            passwordBig.BackColor = SystemColors.Menu;
        }

        private void textBoxPassword_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Password")
            {
                textBoxPassword.Text = "";
            }

            textBoxUser.BackColor = SystemColors.Menu;
            userBig.BackColor = SystemColors.Menu;
            textBoxPassword.BackColor = Color.White;
            passwordBig.BackColor = Color.White;
            textBoxPassword.UseSystemPasswordChar = true;
        }

        private void passwordSee_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = false;
        }

        private void passwordSee_MouseUp(object sender, MouseEventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;
        }

        private void ButtonForgotPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hint: admin");
        }

        private void panel2_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void panel2_Click(object sender, EventArgs e)
        {
            textBoxUser.BackColor = SystemColors.Menu;
            userBig.BackColor = SystemColors.Menu;
            textBoxPassword.BackColor = SystemColors.Menu;
            passwordBig.BackColor = SystemColors.Menu;
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUser.Text;
            string password = textBoxPassword.Text;

            if (textBoxUser.Text == "Geo" && textBoxPassword.Text == "admin")
            {
                String str = $"server=DESKTOP-28Q28T1\\SQLEXPRESS1; database=CompanieAeriana; UID={username}; password={password}";
                SqlConnection con = new SqlConnection(str);
                con.Open();
                LabelUser = username;
                LabelPassword = password;
                Select nextForm = new Select();
                nextForm.Show();
                this.Hide();
            }

            if (textBoxUser.Text != "Geo" || textBoxPassword.Text != "admin")
            {
                MessageBox.Show("Invalid credentials");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            textBoxUser.Text = "User";
            textBoxPassword.Text = "Password";
            textBoxPassword.UseSystemPasswordChar = false;
        }

        private void DevelopedBy_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void DevelopedBy_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void DevelopedBy_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
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

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
