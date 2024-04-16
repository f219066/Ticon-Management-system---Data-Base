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
    public partial class usersignup : Form
    {
        OracleConnection con;

        // Replace this connection string with your actual Oracle database connection string
        private string connectionString = "User Id=TEST;Password=TEST123;Data Source=localhost:1521/xe;";

        public usersignup()
        {
            InitializeComponent();
            con = new OracleConnection(connectionString);
        }

        private void usersignup_Load(object sender, EventArgs e)
        {
            // Initialize your form
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Call a method to insert data
            InsertData();







        }

        private void InsertData()
        {
            // Get values from your form controls
            string firstName = textBox1.Text;
            string lastName = textBox3.Text;
            string address = textBox4.Text;

            // Determine the selected gender
            string gender = "";
            if (radioButton1.Checked)
                gender = "M";
            else if (radioButton2.Checked)
                gender = "F";
            else if (radioButton3.Checked)
                gender = "O";

            string city = comboBox2.Text; // Assuming you have a ComboBox for city
            string password = textBox2.Text;
            string confirmPassword = textBox5.Text;

            // Check if passwords match
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            // Construct the SQL query
            string query = "INSERT INTO User_table (First_Name, Last_Name, Address, Gender, City, Password) " +
                           "VALUES (:FirstName, :LastName, :Address, :Gender, :City, :Password) " +
                           "RETURNING User_ID INTO :UserID";

            using (OracleCommand command = new OracleCommand(query, con))
            {
                // Add parameters to the query to prevent SQL injection
                command.Parameters.Add(":FirstName", OracleDbType.Varchar2).Value = firstName;
                command.Parameters.Add(":LastName", OracleDbType.Varchar2).Value = lastName;
                command.Parameters.Add(":Address", OracleDbType.Varchar2).Value = address;
                command.Parameters.Add(":Gender", OracleDbType.Varchar2).Value = gender;
                command.Parameters.Add(":City", OracleDbType.Varchar2).Value = city;
                command.Parameters.Add(":Password", OracleDbType.Varchar2).Value = password;

                // Add an output parameter for the generated User_ID
                OracleParameter userIdParameter = new OracleParameter(":UserID", OracleDbType.Varchar2, 50); // Adjust the size accordingly
                userIdParameter.Direction = ParameterDirection.Output;
                command.Parameters.Add(userIdParameter);

                try
                {
                    con.Open();

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Access the generated User_ID from the output parameter
                        string generatedUserId = userIdParameter.Value.ToString();

                        MessageBox.Show($"Data inserted successfully! User ID: {generatedUserId}");
                    }
                    else
                    {
                        MessageBox.Show("Data insertion failed!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
