using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Event_Ticketing_System
{
    public partial class AdminForm : Form
    {
        private DB_MY db = new DB_MY(); 

        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // Populate all the DataGrids when the form loads
            LoadAllData();
        }

        private void LoadAllData()
        {
            LoadEvents();
            LoadTickets();
            LoadPurchases();
            
        }

        private void LoadEvents()
        {
            try
            {
                db.OpenConnection();
                string query = "SELECT * FROM events";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.GetConnection());
                DataTable table = new DataTable();
                adapter.Fill(table);

                eventGrid.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading events: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void LoadTickets()
        {
            try
            {
                db.OpenConnection();
                string query = "SELECT * FROM tickets";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.GetConnection());
                DataTable table = new DataTable();
                adapter.Fill(table);

                ticketGrid.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading tickets: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void LoadPurchases()
        {
            try
            {
                db.OpenConnection();
                string query = "SELECT * FROM purchases";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, db.GetConnection());
                DataTable table = new DataTable();
                adapter.Fill(table);

                purchaseGrid.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading purchases: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }

 

    

        private void deleteButton_Click(object sender, EventArgs e)
        {
            // Determine which tab is active
            if (tabControl.SelectedTab == eventTab)
            {
                DeleteEvent();
            }
            else if (tabControl.SelectedTab == ticketTab)
            {
                DeleteTicket();
            }
            else if (tabControl.SelectedTab == purchaseTab)
            {
                DeletePurchase();
            }
            
        }

        private void DeleteEvent()
        {
            if (eventGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an event to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int eventId = Convert.ToInt32(eventGrid.SelectedRows[0].Cells["id"].Value);

            try
            {
                db.OpenConnection();
                string query = "DELETE FROM events WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@id", eventId);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Event deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadEvents(); // Refresh the event grid
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting event: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void DeleteTicket()
        {
            if (ticketGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a ticket to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int ticketId = Convert.ToInt32(ticketGrid.SelectedRows[0].Cells["id"].Value);

            try
            {
                db.OpenConnection();
                string query = "DELETE FROM tickets WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@id", ticketId);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Ticket deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadTickets(); // Refresh the ticket grid
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting ticket: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void DeletePurchase()
        {
            if (purchaseGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a purchase to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int purchaseId = Convert.ToInt32(purchaseGrid.SelectedRows[0].Cells["id"].Value);

            try
            {
                db.OpenConnection();
                string query = "DELETE FROM purchases WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@id", purchaseId);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Purchase deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadPurchases(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting purchase: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        

        private void editButton_Click(object sender, EventArgs e)
        {
           
            if (tabControl.SelectedTab == eventTab)
            {
                EditEvent();
            }
            else if (tabControl.SelectedTab == ticketTab)
            {
                EditTicket();
            }
            else if (tabControl.SelectedTab == purchaseTab)
            {
                EditPurchase();
            }
            
        }

        private void EditEvent()
        {
          
            MessageBox.Show("Edit Event feature not yet implemented.");
        }

        private void EditTicket()
        {
            
            MessageBox.Show("Edit Ticket feature not yet implemented.");
        }

        private void EditPurchase()
        {
           
            MessageBox.Show("Edit Purchase feature not yet implemented.");
        }

        private void EditRegistration()
        {
            
            MessageBox.Show("Edit Registration feature not yet implemented.");
        }

        private void loadButton_Click_1(object sender, EventArgs e)
        {
            
            LoadAllData();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void eventGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}