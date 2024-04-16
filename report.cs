using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Db_project
{
    public partial class report : Form
    {
        public report()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {   // Create an instance of the homematerial form
            ENROLLEDDATA enrolled = new ENROLLEDDATA();

            // Set the size and location of homematerial to cover Form1
            enrolled.Size = this.ClientSize;
            enrolled.Location = new Point(0, 0);

            // Set homematerial as a child form of Form1

            enrolled.FormBorderStyle = FormBorderStyle.None;


            // Show the homematerial form
            enrolled.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Create an instance of the homematerial form
            PRESENTIESDATA present = new PRESENTIESDATA();

            // Set the size and location of homematerial to cover Form1
            present.Size = this.ClientSize;
            present.Location = new Point(0, 0);

            // Set homematerial as a child form of Form1

            present.FormBorderStyle = FormBorderStyle.None;


            // Show the homematerial form
            present.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create an instance of the homematerial form
            ABSENTREPORT absent = new ABSENTREPORT();

            // Set the size and location of homematerial to cover Form1
            absent.Size = this.ClientSize;
            absent.Location = new Point(0, 0);

            // Set homematerial as a child form of Form1

            absent.FormBorderStyle = FormBorderStyle.None;


            // Show the homematerial form
            absent.Show();
        }
    }
}
