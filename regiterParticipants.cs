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
    public partial class regiterParticipants : Form
    {
        OracleConnection con;
        private string connectionString = "User Id=TEST;Password=TEST123;Data Source=localhost:1521/xe;";

        public regiterParticipants()
        {
            InitializeComponent();
            con = new OracleConnection(connectionString);
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            // Close the current form
            this.Close();
        }


        private void RegisterParticipants()
        {
            // Get values from your form controls
            string firstName = textBox1.Text;
            string lastName = textBox4.Text;
            string email = textBox3.Text;
            string contact = textBox2.Text;
            string city = comboBox2.Text;
            string eventName = textBox5.Text;
            string registrationStatus = textBox6.Text;

            // Determine payment status based on radio buttons
            string paymentStatus = radioButton1.Checked ? "Paid" : (radioButton4.Checked ? "Unpaid" : "Not Paid");

            // Determine attendance status based on radio buttons
            string attendanceStatus = radioButton5.Checked ? "Present" : (radioButton6.Checked ? "Absent" : "No");

            // Construct the SQL query
            string query = "INSERT INTO Participant (reg_id, First_Name, Last_Name, Email, Contact, city, EventName, R_status, Payment_Status, Attendance_Status) " +
                           "VALUES (ParticipantSeq.NEXTVAL, :FirstName, :LastName, :Email, :Contact, :City, :EventName, :RStatus, :PaymentStatus, :AttendanceStatus)";

            using (OracleCommand command = new OracleCommand(query, con))
            {
                // Add parameters to the query to prevent SQL injection
                command.Parameters.Add(":FirstName", OracleDbType.Varchar2).Value = firstName;
                command.Parameters.Add(":LastName", OracleDbType.Varchar2).Value = lastName;
                command.Parameters.Add(":Email", OracleDbType.Varchar2).Value = email;
                command.Parameters.Add(":Contact", OracleDbType.Varchar2).Value = contact;
                command.Parameters.Add(":City", OracleDbType.Varchar2).Value = city;
                command.Parameters.Add(":EventName", OracleDbType.Varchar2).Value = eventName;
                command.Parameters.Add(":RStatus", OracleDbType.Varchar2).Value = registrationStatus;
                command.Parameters.Add(":PaymentStatus", OracleDbType.Varchar2).Value = paymentStatus;
                command.Parameters.Add(":AttendanceStatus", OracleDbType.Varchar2).Value = attendanceStatus;

                try
                {
                    // Open the connection
                    con.Open();

                    // Execute the query
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Retrieve the registration ID
                        string regIdQuery = "SELECT ParticipantSeq.CURRVAL FROM dual";
                        using (OracleCommand regIdCommand = new OracleCommand(regIdQuery, con))
                        {
                            object regIdObj = regIdCommand.ExecuteScalar();

                            if (regIdObj != null)
                            {
                                int registrationId = Convert.ToInt32(regIdObj);

                                // Display the registration ID to the user
                                MessageBox.Show($"Participant registered successfully!\nRegistration ID: {registrationId}");
                            }
                            else
                            {
                                MessageBox.Show("Failed to retrieve registration ID.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Participant registration failed!");
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterParticipants();
        }

        private void regiterParticipants_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) //paid radio button
        {

        }


        private void radioButton4_CheckedChanged(object sender, EventArgs e) //unpaidradio button
        {

        }


        private void radioButton5_CheckedChanged(object sender, EventArgs e) //present
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e) //absent
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}