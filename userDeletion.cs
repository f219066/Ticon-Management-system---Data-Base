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
    public partial class userDeletion : Form
    {
        OracleConnection con;

        // Replace this connection string with your actual Oracle database connection string
        private string connectionString = "User Id=TEST;Password=TEST123;Data Source=localhost:1521/xe;";

        public userDeletion()
        {
            InitializeComponent();
            con = new OracleConnection(connectionString);
        }

        private void userDeletion_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                // Construct the SQL query to retrieve all users
                string query = "SELECT * FROM USER_TABLE";

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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                // Get the USER_ID from the TextBox
                string userId = textBox1.Text;

                // Construct the SQL query to delete the user with the specified USER_ID
                string deleteQuery = $"DELETE FROM USER_TABLE WHERE USER_ID = '{userId}'";

                OracleCommand deleteCmd = new OracleCommand(deleteQuery, con);
                int rowsAffected = deleteCmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("User deleted successfully.");
                }
                else
                {
                    MessageBox.Show("User not found or deletion failed.");
                }

                // Refresh the DataGridView after deletion
                string refreshQuery = "SELECT * FROM USER_TABLE";
                OracleDataAdapter refreshOda = new OracleDataAdapter(new OracleCommand(refreshQuery, con));
                DataTable refreshDt = new DataTable();
                refreshOda.Fill(refreshDt);
                dataGridView1.DataSource = refreshDt;
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

        private void button2_Click(object sender, EventArgs e)
        {
            // Call the userDeletion_Load method to refresh the data
            userDeletion_Load(sender, e);
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void userDeletion_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)// 
        {

        }
    }
}
