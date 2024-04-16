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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Db_project
{
    public partial class ManageParticipants : Form
    {
        private readonly string connectionString = "User Id=TEST;Password=TEST123;Data Source=localhost:1521/xe;";

        public ManageParticipants()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get values from your form controls
            int regIdToUpdate;

            if (!int.TryParse(textBox2.Text, out regIdToUpdate))
            {
                MessageBox.Show("Please enter a valid Registration ID.");
                return;
            }

            string registrationStatus = textBox4.Text;
            string paymentStatus = radioButton1.Checked ? "Paid" : (radioButton4.Checked ? "Unpaid" : "Not Paid");
            string attendanceStatus = radioButton5.Checked ? "Present" : (radioButton6.Checked ? "Absent" : "No");

            // Construct the SQL query for update
            string query = "UPDATE Participant " +
                           "SET R_status = :RStatus, Payment_Status = :PaymentStatus, Attendance_Status = :AttendanceStatus " +
                           "WHERE reg_id = :RegId";

            using (OracleConnection con = new OracleConnection(connectionString))
            {
                using (OracleCommand command = new OracleCommand(query, con))
                {
                    // Add parameters to the query to prevent SQL injection
                    command.Parameters.Add(":RStatus", OracleDbType.Varchar2).Value = registrationStatus;
                    command.Parameters.Add(":PaymentStatus", OracleDbType.Varchar2).Value = paymentStatus;
                    command.Parameters.Add(":AttendanceStatus", OracleDbType.Varchar2).Value = attendanceStatus;
                    command.Parameters.Add(":RegId", OracleDbType.Int32).Value = regIdToUpdate;

                    try
                    {
                        // Open the connection
                        con.Open();

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Participant information updated successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Participant information update failed. Please check the provided registration ID.");
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
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            // Close the current form
            this.Close();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        // Other event handlers and methods as needed
    }
}