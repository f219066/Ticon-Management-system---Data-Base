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
    public partial class homematerial : Form
    {

        private adminLogin adminLoginForm;
        //private UserLoginForm userLoginForm;


        public homematerial()
        {
            InitializeComponent();
            // Set the size of the form to cover the entire client area
            this.Size = new Size(Width, Height);
            // Set the start position to manual
            this.StartPosition = FormStartPosition.Manual;


        }

        private void homematerial_Load(object sender, EventArgs e)
        {
            // Code to be executed when the form loads
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void HomeButton_Click(object sender, EventArgs e) // admin buttton
        {

        }

        private void button1_Click(object sender, EventArgs e) // user button
        {

        }

        private void button1_Click_1(object sender, EventArgs e) //participant 
        {
            // Create an instance of the participantlogin form



        }

        private void button3_Click(object sender, EventArgs e) //admin 
        {
            // Create an instance of the participantlogin form
            adminLogin ADMINLOGIN = new adminLogin();

            // Set the size and location of participantlogin to cover the panel
            ADMINLOGIN.Size = panel1.ClientSize;
            ADMINLOGIN.Location = new Point(0, 0);

            // Set participantlogin as a child form of the panel
            ADMINLOGIN.TopLevel = false;
            ADMINLOGIN.FormBorderStyle = FormBorderStyle.None;

            // Clear existing controls from the panel
            panel1.Controls.Clear();

            // Add participantlogin to the panel
            panel1.Controls.Add(ADMINLOGIN);

            // Show the participantlogin form
            ADMINLOGIN.Show();
        }

        private void button2_Click_1(object sender, EventArgs e) //user
        {
            // Create an instance of the participantlogin form
            User USER = new User();

            // Set the size and location of participantlogin to cover the panel
            USER.Size = panel1.ClientSize;
            USER.Location = new Point(0, 0);

            // Set participantlogin as a child form of the panel
            USER.TopLevel = false;
            USER.FormBorderStyle = FormBorderStyle.None;

            // Clear existing controls from the panel
            panel1.Controls.Clear();

            // Add participantlogin to the panel
            panel1.Controls.Add(USER);

            // Show the participantlogin form
            USER.Show();

        }


        private void btnOpenAdminLogin_Click(object sender, EventArgs e)
        {
            OpenAdminLoginForm();
        }

        private void OpenAdminLoginForm()
        {
            // Store the visibility state of the current form
            bool isCurrentFormVisible = this.Visible;

            // Create an instance of the adminLogin form
            adminLogin adminLoginForm = new adminLogin();

            // Set the previousForm variable to the current form (this form)
            adminLoginForm.previousForm = this;

            // Optionally, hide the current form if needed
            if (isCurrentFormVisible)
            {
                this.Hide();
            }

            // Show the adminLogin form
            adminLoginForm.FormClosed += (sender, e) =>
            {
                // Optionally, show the current form again after the adminLogin form is closed
                if (isCurrentFormVisible)
                {
                    // Ensure that the controls on the homematerial form are visible
                    foreach (Control control in this.Controls)
                    {
                        control.Visible = true;
                    }

                    this.Show();
                }
            };

            adminLoginForm.Show();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}



