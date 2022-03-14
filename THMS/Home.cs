using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace THMS
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            staff newForm = new staff();
            newForm.Hide();
            newForm.ShowDialog();
            this.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            expenses newForm = new expenses();
            newForm.Hide();
            newForm.ShowDialog();
            this.Show();
        }

        private void employmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                staff newForm = new staff();
                newForm.Hide();
                newForm.ShowDialog();
                this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Landlords newForm = new Landlords();
            newForm.Hide();
            newForm.ShowDialog();
            this.Show();
        }
        /*  private void monthCalendar1_DateSelected(object sender, System.Windows.Forms.DateRangeEventArgs e)
          {
              DateTime startDate = e.Start;
              startDate = startDate.AddDays(-(double)startDate.DayOfWeek);
              Calendar.SelectionStart = startDate;
              Calendar.SelectionEnd = startDate.AddDays(6);
          }*/

        private void Home_Load(object sender, EventArgs e)
        {
            if (Variables.usertype == "STAFF")
            {
                servicesToolStripMenuItem.Visible = false;
            }
            else if (Variables.usertype == "ADMINISTRATOR")
            {
                servicesToolStripMenuItem.Visible = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Payments newForm = new Payments();
            newForm.Hide();
            newForm.ShowDialog();
            this.Show();
        }

        private void addHostelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Hostels newForm = new Add_Hostels();
            newForm.Hide();
            newForm.ShowDialog();
            this.Show();
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Booking newForm = new Booking();
            newForm.Hide();
            newForm.ShowDialog();
            this.Show();

        }

        private void agentregistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgentRegistration newForm = new AgentRegistration();
            newForm.Hide();
            newForm.ShowDialog();
            this.Show();

        }

        private void ageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agency newForm = new Agency();
            newForm.Hide();
            newForm.ShowDialog();
            this.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void paymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployStaff newForm = new EmployStaff();
            newForm.Hide();
            newForm.ShowDialog();
            this.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            HostelPic.Image = imageList1.Images[5];
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            HostelPic.Image = imageList1.Images[6];
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            HostelPic.Image = imageList1.Images[7];
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            HostelPic.Image = imageList1.Images[8];
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            HostelPic.Image = imageList1.Images[9];
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            HostelPic.Image = imageList1.Images[10];
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            HostelPic.Image = imageList1.Images[11];
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            HostelPic.Image = imageList1.Images[12];
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            HostelPic.Image = imageList1.Images[13];
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            HostelPic.Image = imageList1.Images[14];
        }
        private int imageNumber = 0;

        private void loadNextImage()
        {
            if (imageNumber == 3)
            {
                imageNumber = 0;
            }
            HostelPic.ImageLocation = string.Format(@"C:\Users\FELIX\Documents\c#project\logo{0}.jpg", imageNumber);
            imageNumber++;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            loadNextImage();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int img;

            for (img = 0; img < 6; img++) ;
            HostelPic.Image = imageList1.Images[0];
            

        }

        private void HostelPic_Click(object sender, EventArgs e)
        {

        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            login change = new login();
            change.Show();
            this.Hide();
        }

        private void allLandlordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rptLandlord landlord = new rptLandlord();
            landlord.Show();
        }

        private void allHostelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HOSTELS hostel = new HOSTELS();
            hostel.Show();
        }

    }
}