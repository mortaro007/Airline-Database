using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Companie_Aeriana
{
    public partial class Select_Interogare : Form
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

        public Select_Interogare()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void PxA_Click(object sender, EventArgs e)
        {
            Interogari nextForm = new Interogari("PxA", "");
            nextForm.Show();
        }

        private void RxZ_Click(object sender, EventArgs e)
        {
            Interogari nextForm = new Interogari("RxZ", "");
            nextForm.Show();
        }

        private void CxRezervare_Click(object sender, EventArgs e)
        {
            Interogari nextForm = new Interogari("CxRezervare", "");
            nextForm.Show();
        }

        private void BxAeronava_Click(object sender, EventArgs e)
        {
            Interogari nextForm = new Interogari("BxAeronava", "");
            nextForm.Show();
        }

        private void ZxAeronava_Click(object sender, EventArgs e)
        {
            Interogari nextForm = new Interogari("ZxAeronava", "");
            nextForm.Show();
        }

        private void CxZ_Click(object sender, EventArgs e)
        {
            Interogari nextForm = new Interogari("CxZ", "");
            nextForm.Show();
        }

        private void AeronaveSearch_Click(object sender, EventArgs e)
        {
            Interogari nextForm = new Interogari("SearchAeronave", searchAvioane.Text);
            nextForm.Show();
        }

        private void CodPlecareSearch_Click(object sender, EventArgs e)
        {
            Interogari nextForm = new Interogari("SearchCod", comboBox2.Text);
            nextForm.Show();
        }

        private void PilotsSearch_Click(object sender, EventArgs e)
        {
            Interogari nextForm = new Interogari("SearchPilotID", PilotID.Text);
            nextForm.Show();
        }

        private void TicketSearch_Click(object sender, EventArgs e)
        {
            Interogari nextForm = new Interogari("SearchTicketType", ticketOptions.Text);
            nextForm.Show();
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
