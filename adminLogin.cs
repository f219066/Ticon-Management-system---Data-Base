using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    public partial class adminLogin : Form
    {
        internal Form previousForm { get; set; }

        OracleConnection con;

        // Replace this connection string with your actual Oracle database connection string
        private string connectionString = "User Id=TEST;Password=TEST123;Data Source=localhost:1521/xe;";

        public adminLogin()
        {
            InitializeComponent();
            con = new OracleConnection(connectionString);
        }

        private void button1_Click(object sender, EventArgs e) // Sign up button
        {
            // Create an instance of the AdminSignup form
            AdminSignup adminsignup = new AdminSignup();

            // Set the size and location of AdminSignup to cover Form1
            adminsignup.Size = this.ClientSize;
            adminsignup.Location = new Point(0, 0);

            // Set AdminSignup as a child form of Form1
            adminsignup.TopLevel = false;
            adminsignup.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(adminsignup);

            // Hide the panel on the admin login page
            panel1.Visible = false; // Replace "panel1" with the actual name of your panel

            // Show the AdminSignup form
            adminsignup.Show();

            // Bring the AdminSignup form to the front
            adminsignup.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e) // Sign in button
        {
            // Get input values from the form
            string username = textBox1.Text;
            string password = textBox2.Text;

            // Check if the username and password are not empty
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            // Construct the SQL query to check admin credentials
            string query = "SELECT COUNT(*) FROM AdminTable WHERE AdminID = :AdminID AND Password = :Password";

            using (OracleCommand command = new OracleCommand(query, con))
            {
                // Add parameters to the query to prevent SQL injection
                command.Parameters.Add(":AdminID", OracleDbType.Varchar2).Value = username;
                command.Parameters.Add(":Password", OracleDbType.Varchar2).Value = password;

                try
                {
                    // Open the connection
                    con.Open();

                    // Execute the query
                    int adminCount = Convert.ToInt32(command.ExecuteScalar());

                    if (adminCount > 0)
                    {
                        // Authentication successful
                        MessageBox.Show("Login successful!");

                        // Create an instance of the homematerial form
                        AdminFunctionality admin = new AdminFunctionality();

                        // Set the size and location of homematerial to cover Form1
                        admin.Size = this.ClientSize;
                        admin.Location = new Point(0, 0);

                        // Set homematerial as a child form of Form1

                        admin.FormBorderStyle = FormBorderStyle.None;


                        // Show the homematerial form
                        admin.Show();
                        // Add your logic for what to do after successful admin login

                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password. Please try again.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    // Close the connection
                    con.Close();
                }




            }
        }

        private void button4_Click(object sender, EventArgs e) // back button
        {
            // Close the current form
            this.Close();

            // Show the previous form
            if (previousForm != null)
            {
                previousForm.Show();
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void adminLogin_Load(object sender, EventArgs e)
        {

        }

    }
}