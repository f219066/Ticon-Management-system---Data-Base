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
    public partial class AdminFunctionality : Form
    {
        public AdminFunctionality()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e) // PARTCIPANTS WITH EVENTS
        {
            // Create an instance of the homematerial form
            Pwithevents pe = new Pwithevents();

            // Set the size and location of homematerial to cover Form1
            pe.Size = this.ClientSize;
            pe.Location = new Point(0, 0);

            // Set homematerial as a child form of Form1

            pe.FormBorderStyle = FormBorderStyle.None;


            // Show the homematerial form
            pe.Show();

        }

        private void menuButton_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void button2_Click(object sender, EventArgs e) // delete user 
        {



            // Create an instance of the homematerial form
            userDeletion udd = new userDeletion();

            // Set the size and location of homematerial to cover Form1
            udd.Size = this.ClientSize;
            udd.Location = new Point(0, 0);

            // Set homematerial as a child form of Form1

            udd.FormBorderStyle = FormBorderStyle.None;


            // Show the homematerial form
            udd.Show();

        }

        private void button4_Click(object sender, EventArgs e) //report
        {


            // Create an instance of the homematerial form
            report re = new report();

            // Set the size and location of homematerial to cover Form1
            re.Size = this.ClientSize;
            re.Location = new Point(0, 0);

            // Set homematerial as a child form of Form1

            re.FormBorderStyle = FormBorderStyle.None;


            // Show the homematerial form
            re.Show();



        }

        private void AdminFunctionality_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create an instance of the homematerial form
            ManageRoles OK  = new ManageRoles();

            // Set the size and location of homematerial to cover Form1
            OK.Size = this.ClientSize;
            OK.Location = new Point(0, 0);

            // Set homematerial as a child form of Form1

            OK.FormBorderStyle = FormBorderStyle.None;


            // Show the homematerial form
            OK.Show();
        }
    }
}
