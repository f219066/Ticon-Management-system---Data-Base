//using Oracle.ManagedDataAccess.Client;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

//namespace Db_project
//{
//    public partial class EventsCreate : Form
//    {
//        public EventsCreate()
//        {
//            InitializeComponent();
//        }

//        private void EventsCreate_Load(object sender, EventArgs e)
//        {



//        }


//        private void menuButton_Click(object sender, EventArgs e)
//        {

//            // Close the current form
//            this.Close();


//        }

//        private void textBox1_TextChanged(object sender, EventArgs e)
//        {

//        }


//        private void textBox2_TextChanged(object sender, EventArgs e)
//        {

//        }

//        private void textBox5_TextChanged(object sender, EventArgs e)
//        {

//        }

//        private void textBox4_TextChanged(object sender, EventArgs e)
//        {

//        }

//        private void textBox8_TextChanged(object sender, EventArgs e)
//        {

//        }

//        private void button1_Click(object sender, EventArgs e)
//        {

//        }

//        private void panel2_Paint(object sender, PaintEventArgs e)
//        {

//        }

//        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
//        {

//        }
//    }
//}

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
    public partial class EventsCreate : Form
    {
        OracleConnection con;

        // Replace this connection string with your actual Oracle database connection string
        private string connectionString = "User Id=TEST;Password=TEST123;Data Source=localhost:1521/xe;";

        public EventsCreate()
        {
            InitializeComponent();
            con = new OracleConnection(connectionString);
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            // Close the current form
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Call a method to insert event data
            InsertEventData();
        }

        private void InsertEventData()
        {
            // Get values from your form controls
            string eventName = textBox1.Text;
            DateTime eventDate = dateTimePicker1.Value;
            string startTime = textBox2.Text;
            string endTime = textBox5.Text;
            string location = textBox4.Text;
            string description = textBox8.Text;

            // Construct the SQL query
            string query = "INSERT INTO Event (EventID, EventName, EventDate, StartTime, EndTime, Location, Description) " +
                           "VALUES (EventSeq.NEXTVAL, :EventName, :EventDate, :StartTime, :EndTime, :Location, :Description)";

            using (OracleCommand command = new OracleCommand(query, con))
            {
                // Add parameters to the query to prevent SQL injection
                command.Parameters.Add(":EventName", OracleDbType.Varchar2).Value = eventName;
                command.Parameters.Add(":EventDate", OracleDbType.Date).Value = eventDate;
                command.Parameters.Add(":StartTime", OracleDbType.Varchar2).Value = startTime;
                command.Parameters.Add(":EndTime", OracleDbType.Varchar2).Value = endTime;
                command.Parameters.Add(":Location", OracleDbType.Varchar2).Value = location;
                command.Parameters.Add(":Description", OracleDbType.Varchar2).Value = description;

                try
                {
                    // Open the connection
                    con.Open();

                    // Execute the query
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Event data inserted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Event data insertion failed!");
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


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}


