using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TechStore.Admin_Forms
{
    public partial class UserManagementForm : Form
    {
        private readonly string _connectionString;

        public UserManagementForm()
        {
            InitializeComponent();
            _connectionString = @"Data Source=LAPLAS;Initial Catalog=TechStore;Integrated Security=True;User Id=techstore;Password=techstore;Encrypt=False";
            LoadUsers(); // Завантаження списку користувачів при завантаженні форми
        }

        private void LoadUsers()
        {
            string query = "SELECT UserID, Username, Email FROM Users";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    // Очищення списку перед завантаженням нових користувачів
                    listBoxUsers.Items.Clear();

                    // Додавання користувачів до списку
                    while (reader.Read())
                    {
                        listBoxUsers.Items.Add($"User ID: {reader["UserID"]}, Username: {reader["Username"]}, Email: {reader["Email"]}");
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading users: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Отримання пошукового запиту з текстового поля
            string searchQuery = txtSearch.Text.Trim();

            string query = $"SELECT UserID, Username, Email FROM Users WHERE Username LIKE '%{searchQuery}%'";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    // Очищення списку перед завантаженням нових користувачів
                    listBoxUsers.Items.Clear();

                    // Додавання відфільтрованих користувачів до списку
                    while (reader.Read())
                    {
                        listBoxUsers.Items.Add($"User ID: {reader["UserID"]}, Username: {reader["Username"]}, Email: {reader["Email"]}");
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error searching users: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            // Відкриття форми для додавання нового користувача
            AddUserForm addUserForm = new AddUserForm(_connectionString);
            addUserForm.ShowDialog();

            // Після закриття форми оновлюємо список користувачів
            LoadUsers();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            // Перевірка, чи вибрано користувача для видалення
            if (listBoxUsers.SelectedItem != null)
            {
                // Отримання ID вибраного користувача з тексту в ListBox
                string selectedUserIDText = listBoxUsers.SelectedItem.ToString();
                int index = selectedUserIDText.IndexOf("User ID:") + "User ID:".Length;
                int endIndex = selectedUserIDText.IndexOf(",", index);
                string userIDSubstring = selectedUserIDText.Substring(index, endIndex - index).Trim();
                int selectedUserID;
                if (int.TryParse(userIDSubstring, out selectedUserID))
                {
                    string deleteQuery = $"DELETE FROM Users WHERE UserID = {selectedUserID}";

                    using (SqlConnection connection = new SqlConnection(_connectionString))
                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        try
                        {
                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Після видалення користувача оновлюємо список
                                LoadUsers();
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error deleting user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error parsing user ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a user to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); // Закриття форми
        }
    }
}
