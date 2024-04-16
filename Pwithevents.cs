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
    public partial class Pwithevents : Form
    {

        OracleConnection con;

        // Replace this connection string with your actual Oracle database connection string
        private string connectionString = "User Id=TEST;Password=TEST123;Data Source=localhost:1521/xe;";
        public Pwithevents()
        {

            InitializeComponent();
            con = new OracleConnection(connectionString);
        }


        private void Pwithevents_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                // Construct the SQL query with a join operation
                string query = "SELECT PARTICIPANT.REG_ID, PARTICIPANT.FIRST_NAME, PARTICIPANT.LAST_NAME, EVENT.EVENTNAME " +
                               "FROM PARTICIPANT " +
                               "JOIN EVENT ON PARTICIPANT.EVENTNAME = EVENT.EVENTNAME";

                OracleCommand cmd = new OracleCommand(query, con);
                OracleDataAdapter oda = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                oda.Fill(dt);

                // Bind the data to the DataGridView
                dataGridView1.DataSource = dt;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void menuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
