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
    public partial class User : Form
    {
        OracleConnection con;

        // Replace this connection string with your actual Oracle database connection string
        private string connectionString = "User Id=TEST;Password=TEST123;Data Source=localhost:1521/xe;";
        public User()
        {
            InitializeComponent();
            con = new OracleConnection(connectionString);
        }

        private void button1_Click(object sender, EventArgs e) // user signup
        {

            //Create an instance of the homematerial form
            usersignup us = new usersignup();

            // Set the size and location of homematerial to cover Form1
            us.Size = this.ClientSize;
            us.Location = new Point(0, 0);

            // Set homematerial as a child form of Form1

            us.FormBorderStyle = FormBorderStyle.None;


            // Show the homematerial form
            us.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void User_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)//sign in 
        {
            // Get input values from the form
            string username = textBox1.Text;
            string password = textBox2.Text;

            // Check if the username and password are not empty
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both userID and password.");
                return;
            }

            // Construct the SQL query to check user credentials
            string query = "SELECT COUNT(*) FROM User_Table WHERE USER_ID = :USER_ID AND Password = :Password";

            using (OracleCommand command = new OracleCommand(query, con))
            {
                // Add parameters to the query to prevent SQL injection
                command.Parameters.Add(":UserName", OracleDbType.Varchar2).Value = username;
                command.Parameters.Add(":Password", OracleDbType.Varchar2).Value = password;

                try
                {
                    // Open the connection
                    con.Open();

                    // Execute the query
                    int userCount = Convert.ToInt32(command.ExecuteScalar());

                    if (userCount > 0)
                    {
                        // Authentication successful
                        MessageBox.Show("Login successful!");


                        // Create an instance of the AdminSignup form
                        Usermanagement umanage = new Usermanagement();

                        // Set the size and location of AdminSignup to cover Form1
                        umanage.Size = this.ClientSize;
                        umanage.Location = new Point(0, 0);

                        // Set AdminSignup as a child form of Form1
                        umanage.TopLevel = false;
                        umanage.FormBorderStyle = FormBorderStyle.None;
                        this.Controls.Add(umanage);

                        // Hide the panel on the admin login page
                        panel1.Visible = false; // Replace "panel1" with the actual name of your panel

                        // Show the AdminSignup form
                        umanage.Show();

                        // Bring the AdminSignup form to the front
                        umanage.BringToFront();

                    }
                    else
                    {
                        MessageBox.Show("Invalid userID or password. Please try again.");
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



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void menuButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}