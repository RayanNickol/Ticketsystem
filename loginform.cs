using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Event_Ticketing_System
{
    public partial class loginform : Form
    {
        public string UserRole { get; private set; }
        public loginform()
        {
            InitializeComponent();
        }

        private void loginform_Load(object sender, EventArgs e)
        {

        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            DB_MY db = new DB_MY();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

     
            MySqlCommand command = new MySqlCommand("SELECT `role` FROM `users` WHERE `username` = @username AND `password` = @password", db.GetConnection());

        
            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = login_username.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = login_password.Text;

            try
            {
                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                
                    UserRole = table.Rows[0]["role"].ToString().ToLower();

                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid username or password!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

