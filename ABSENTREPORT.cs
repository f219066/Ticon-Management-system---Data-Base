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
    public partial class ABSENTREPORT : Form
    {
        private string connectionString = "User Id=TEST;Password=TEST123;Data Source=localhost:1521/xe;";

        public ABSENTREPORT()
        {
            InitializeComponent();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Retrieve_Click(object sender, EventArgs e)
        {
            try
            {
                using (OracleConnection con = new OracleConnection(connectionString))
                {
                    con.Open();

                    string query = "SELECT REG_ID, FIRST_NAME, LAST_NAME, EMAIL, CONTACT, CITY, EVENTNAME, R_STATUS, PAYMENT_STATUS " +
                                   "FROM PARTICIPANT " +
                                   "WHERE ATTENDANCE_STATUS = 'Absent'";

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
    }
}
