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
    public partial class ManageRoles : Form
    {
        private string connectionString = "User Id=TEST;Password=TEST123;Data Source=localhost:1521/xe;";

        public ManageRoles()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Event handler for DataGridView cell click
        }

        private void ManageRoles_Load(object sender, EventArgs e)
        {
            // Any initialization code you may have
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Event handler for USER_ID TextBox
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Event handler for PERMISSION TextBox
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e) // save 
        {
            try
            {
                using (OracleConnection con = new OracleConnection(connectionString))
                {
                    con.Open();

                    // Get the USER_ID and PERMISSION from the TextBoxes
                    string userId = textBox1.Text;
                    string newPermission = textBox2.Text;

                    // Construct the SQL query to update the permission of the user
                    string updateQuery = $"UPDATE USER_TABLE SET PERMISSION = '{newPermission}' WHERE USER_ID = {userId}";

                    OracleCommand updateCmd = new OracleCommand(updateQuery, con);
                    int rowsAffected = updateCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User permission updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("User not found or update failed.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click_1(object sender, EventArgs e) //view
        {
            try
            {
                using (OracleConnection con = new OracleConnection(connectionString))
                {
                    con.Open();

                    // Get the USER_ID from the TextBox
                    string userId = textBox1.Text;

                    // Retrieve all updated data from the USER_TABLE
                    string selectQuery = $"SELECT * FROM USER_TABLE ";
                    OracleCommand selectCmd = new OracleCommand(selectQuery, con);
                    OracleDataAdapter oda = new OracleDataAdapter(selectCmd);
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

        private void textBox1_TextChanged_1(object sender, EventArgs e) //user id 
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e) //permissions
        {

        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}