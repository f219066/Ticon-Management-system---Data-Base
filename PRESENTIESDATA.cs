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
    public partial class PRESENTIESDATA : Form
    {
        // Replace this connection string with your actual Oracle database connection string
        private string connectionString = "User Id=TEST;Password=TEST123;Data Source=localhost:1521/xe;";

        public PRESENTIESDATA()
        {
            InitializeComponent();
        }

        private void PRESENTIESDATA_Load(object sender, EventArgs e)
        {
            try
            {
                using (OracleConnection con = new OracleConnection(connectionString))
                {
                    con.Open();

                    // Construct the SQL query to retrieve data from the participant table
                    string query = "SELECT REG_ID, FIRST_NAME, LAST_NAME, ATTENDANCE_STATUS FROM PARTICIPANT WHERE ATTENDANCE_STATUS = 'Present'";

                    OracleCommand cmd = new OracleCommand(query, con);
                    OracleDataAdapter oda = new OracleDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    oda.Fill(dt);

                    // Bind the data to the DataGridView
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Call the PRESENTIESDATA_Load method to refresh the data
            PRESENTIESDATA_Load(sender, e);
        }
    }
}