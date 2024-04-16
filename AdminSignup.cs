using Oracle.ManagedDataAccess.Client;
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
    public partial class AdminSignup : Form
    {
        private string connectionString = "User Id=TEST;Password=TEST123;Data Source=localhost:1521/xe;";
        OracleConnection con;
        public AdminSignup()
        {
            InitializeComponent();
            con = new OracleConnection(connectionString);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminSignup_Load(object sender, EventArgs e)
        {

        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void InsertDataToDatabase()
        {
            try
            {
                using (OracleConnection con = new OracleConnection(connectionString))
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

                    string city = comboBox2.Text; // Assuming you have a TextBox for city
                    string password = textBox2.Text;
                    string confirmPassword = textBox5.Text;

                    // Check if passwords match
                    if (password != confirmPassword)
                    {
                        MessageBox.Show("Passwords do not match!");
                        return;
                    }

                    // Construct the SQL query with RETURNING INTO clause
                    string query = "INSERT INTO AdminTable (AdminID, FirstName, LastName, Address, Gender, City, Password) " +
                                   "VALUES (AdminTableSeq.NEXTVAL, :FirstName, :LastName, :Address, :Gender, :City, :Password) " +
                                   "RETURNING AdminID INTO :AdminID";

                    using (OracleCommand command = new OracleCommand(query, con))
                    {
                        // Add parameters to the query to prevent SQL injection
                        command.Parameters.Add(":FirstName", OracleDbType.Varchar2).Value = firstName;
                        command.Parameters.Add(":LastName", OracleDbType.Varchar2).Value = lastName;
                        command.Parameters.Add(":Address", OracleDbType.Varchar2).Value = address;
                        command.Parameters.Add(":Gender", OracleDbType.Char).Value = gender;
                        command.Parameters.Add(":City", OracleDbType.Varchar2).Value = city;
                        command.Parameters.Add(":Password", OracleDbType.Varchar2).Value = password;

                        OracleParameter adminIDParam = new OracleParameter(":AdminID", OracleDbType.Varchar2, 50); // Adjust the size accordingly
                        adminIDParam.Direction = ParameterDirection.Output;
                        command.Parameters.Add(adminIDParam);

                        try
                        {
                            con.Open();
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Access the generated User_ID from the output parameter
                                string generatedUserId = adminIDParam.Value.ToString();
                                MessageBox.Show($"Data inserted successfully! AdminID: {generatedUserId}");
                            }
                            else
                            {
                                MessageBox.Show("Data insertion failed!");
                            }
                        }
                        catch (OracleException ex)
                        {
                            MessageBox.Show("Oracle Error: " + ex.Message);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void button1_Click(object sender, EventArgs e) // signup
        {
            try
            {
                InsertDataToDatabase();
                MessageBox.Show("Admin signed up successfully!");
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Oracle Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}