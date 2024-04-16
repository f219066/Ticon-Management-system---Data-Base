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
    public partial class EVENT_DETAILS : Form
    {
        OracleConnection con;
        private string connectionString = "User Id=TEST;Password=TEST123;Data Source=localhost:1521/xe;";

        public EVENT_DETAILS()
        {
            InitializeComponent();
            con = new OracleConnection(connectionString);
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadEventData()
        {
            try
            {
                con.Open();

                // Construct the SQL query
                string query = "SELECT EventID, EventName, EventDate, StartTime, EndTime, Location, Description FROM Event";

                using (OracleDataAdapter adapter = new OracleDataAdapter(query, con))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Clear existing columns and data
                    dataGridView1.Columns.Clear();
                    dataGridView1.DataSource = null;

                    // Bind the data to the DataGridView
                    dataGridView1.DataSource = dataTable;

                    // If AutoGenerateColumns is set to false, manually add columns
                    // Example for manual column addition:
                    // dataGridView1.Columns.Add("EventID", "Event ID");
                    // dataGridView1.Columns.Add("EventName", "Event Name");
                    // ...

                    // Optional: Auto-resize columns for better visibility
                    dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
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

        private void EVENT_DETAILS_Load(object sender, EventArgs e)
        {
            // Call the method to load event data when the form is loaded
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadEventData();
        }
    }
}