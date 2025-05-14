using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Event_Ticketing_System
{
    public partial class TicketForm : Form
    {
        private DB_MY db = new DB_MY();
        private int eventId; // Store the event ID for which tickets are managed

        public TicketForm(int eventId)
        {
            InitializeComponent();
            this.eventId = eventId;
        }

        private void TicketForm_Load(object sender, EventArgs e)
        {
            LoadTickets();
        }

        private void LoadTickets()
        {
            try
            {
                db.OpenConnection();
                string query = "SELECT * FROM tickets WHERE event_id = @eventId";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@eventId", eventId);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
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

        private void addTicketButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(ticketAvailabilityTextBox.Text, out int availability))
                {
                    MessageBox.Show("Please enter a valid number for ticket availability.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(ticketPriceTextBox.Text, out decimal price))
                {
                    MessageBox.Show("Please enter a valid price for the ticket.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                db.OpenConnection();
                string query = "INSERT INTO tickets (event_id, type, price, availability) VALUES (@eventId, @type, @price, @availability)";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@eventId", eventId);
                cmd.Parameters.AddWithValue("@type", ticketTypeTextBox.Text);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@availability", availability);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Ticket added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearInputFields();
                LoadTickets();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void updateTicketButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure the user has selected a ticket
                if (string.IsNullOrEmpty(ticketIdTextBox.Text))
                {
                    MessageBox.Show("Please select a ticket to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                db.OpenConnection();

                // SQL query to updates
                string query = "UPDATE tickets SET type=@type, price=@price, availability=@availability WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@id", ticketIdTextBox.Text);
                cmd.Parameters.AddWithValue("@type", ticketTypeTextBox.Text);
                cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(ticketPriceTextBox.Text));
                cmd.Parameters.AddWithValue("@availability", Convert.ToInt32(ticketAvailabilityTextBox.Text));

                // Execute the query
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Ticket updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No ticket was updated. Please ensure the ticket exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Refresh the DataGridView
                LoadTickets();

             
                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void deleteTicketButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure the user has selected a ticket
                if (string.IsNullOrEmpty(ticketIdTextBox.Text))
                {
                    MessageBox.Show("Please select a ticket to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                db.OpenConnection();
        
                string query = "DELETE FROM tickets WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
                cmd.Parameters.AddWithValue("@id", ticketIdTextBox.Text);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Ticket deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No ticket was deleted. Please ensure the ticket exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                LoadTickets();

                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void ticketGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = ticketGrid.Rows[e.RowIndex];
                ticketIdTextBox.Text = row.Cells["id"].Value.ToString();
                ticketTypeTextBox.Text = row.Cells["type"].Value.ToString();
                ticketPriceTextBox.Text = row.Cells["price"].Value.ToString();
                ticketAvailabilityTextBox.Text = row.Cells["availability"].Value.ToString();
            }
        }

        private void ClearInputFields()
        {
            ticketIdTextBox.Clear();
            ticketTypeTextBox.Clear();
            ticketPriceTextBox.Clear();
            ticketAvailabilityTextBox.Clear();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            if (ticketGrid.Rows.Count == 0)
            {
                LoadTickets(); // Call the existing method to fetch and display tickets from the database
            }
            else
            {
                MessageBox.Show("The data is already loaded!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EventForm joinedForm = new EventForm();
            joinedForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}