using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Db_project
{
    public partial class Mainform : Form
    {
        OracleConnection con;
        bool sidebarExpand;

        public Mainform()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }
        private void HomeButton_Click(object sender, EventArgs e)
        {
            // Create an instance of the homematerial form
            homematerial homeMaterialForm = new homematerial();

            // Set the size and location of homematerial to cover Form1
            homeMaterialForm.Size = this.ClientSize;
            homeMaterialForm.Location = new Point(0, 0);

            // Set homematerial as a child form of Form1
            homeMaterialForm.TopLevel = false;
            homeMaterialForm.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(homeMaterialForm);

            // Show the homematerial form
            homeMaterialForm.Show();
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Add code for linkLabel1 click event if needed
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Add code for button3 click event if needed
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Add code for label1 click event if needed
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Add code for panel1 paint event if needed
        }

        private void button2_Click(object sender, EventArgs e) //scheduling
        {


            Scheduling sh = new Scheduling();
            sh.Size = this.ClientSize;
            sh.Location = new Point(0, 0);
            sh.TopLevel = false;
            sh.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(sh);
            sh.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)// about 
        {
            // Create an instance of the homematerial form
            AboutUs aboutus = new AboutUs();

            // Set the size and location of homematerial to cover Form1
            aboutus.Size = this.ClientSize;
            aboutus.Location = new Point(0, 0);

            // Set homematerial as a child form of Form1
            aboutus.TopLevel = false;
            aboutus.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(aboutus);

            // Show the homematerial form
            aboutus.Show();
        }
    }
}
