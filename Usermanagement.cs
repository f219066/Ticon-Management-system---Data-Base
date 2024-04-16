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
    public partial class Usermanagement : Form
    {
        OracleConnection con;

        // Replace this connection string with your actual Oracle database connection string
        private string connectionString = "User Id=TEST;Password=TEST123;Data Source=localhost:1521/xe;";

        public Usermanagement()
        {
            InitializeComponent();
            con = new OracleConnection(connectionString);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Your code for label1 click event
        }

        // Other event handlers...

        private void button2_Click(object sender, EventArgs e) // event details
        {
            // Check user permission before proceeding
            if (CheckUserPermission())
            {
                EVENT_DETAILS OBJ = new EVENT_DETAILS();

                // Set the size and location of homematerial to cover Form1
                OBJ.Size = this.ClientSize;
                OBJ.Location = new System.Drawing.Point(0, 0);

                // Set homematerial as a child form of Form1
                OBJ.FormBorderStyle = FormBorderStyle.None;

                // Show the homematerial form
                OBJ.Show();
            }
            else
            {
                MessageBox.Show("You do not have permission to access this feature.");
            }
        }

        // Other methods...

        private bool CheckUserPermission()
        {
            try
            {
                con.Open();

                // Get the USER_ID from your session or however it's stored
                string userId = "123"; // Replace with your actual logic to get the user ID

                // Construct the SQL query to check the user's permission
                string permissionQuery = $"SELECT PERMISSION FROM USER_TABLE WHERE USER_ID = {userId}";

                OracleCommand cmd = new OracleCommand(permissionQuery, con);
                string permission = cmd.ExecuteScalar() as string;

                return permission == "YES";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking user permission: " + ex.Message);
                return false;
            }
            finally
            {
                con.Close();
            }
        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e) // register participants
        {
            // Create an instance of the homematerial form
            regiterParticipants PART = new regiterParticipants();

            // Set the size and location of homematerial to cover Form1
            PART.Size = this.ClientSize;
            PART.Location = new Point(0, 0);

            // Set homematerial as a child form of Form1

            PART.FormBorderStyle = FormBorderStyle.None;


            // Show the homematerial form
            PART.Show();
        }

        private void button4_Click(object sender, EventArgs e) // MANAGE PARTICIPANTS 
        {


            // Create an instance of the homematerial form
            ManageParticipants manage = new ManageParticipants();

            // Set the size and location of homematerial to cover Form1
            manage.Size = this.ClientSize;
            manage.Location = new Point(0, 0);

            // Set homematerial as a child form of Form1
            manage.FormBorderStyle = FormBorderStyle.None;

            // Show the homematerial form
            manage.Show();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) // event details
        {

            EVENT_DETAILS OBJ = new EVENT_DETAILS();

            // Set the size and location of homematerial to cover Form1
            OBJ.Size = this.ClientSize;
            OBJ.Location = new Point(0, 0);

            // Set homematerial as a child form of Form1

            OBJ.FormBorderStyle = FormBorderStyle.None;


            // Show the homematerial form
            OBJ.Show();
        }

    }
}
