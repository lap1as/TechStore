using System;
using System.Data;
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
            string query = @"SELECT Users.UserID, Users.Username, Users.Email, UserRoles.RoleName
                     FROM Users
                     INNER JOIN UserInRoles ON Users.UserID = UserInRoles.UserID
                     INNER JOIN UserRoles ON UserInRoles.UserRoleID = UserRoles.UserRoleID";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                try
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Прив'язка даних до DataGridView
                    dataGridViewUsers.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }






        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Отримання пошукового запиту з текстового поля
            string searchQuery = txtSearch.Text.Trim();

            string query = $@"SELECT U.UserID, U.Username, U.Email, UR.RoleName 
                              FROM Users U 
                              INNER JOIN UserInRoles UR ON U.UserID = UR.UserID
                              INNER JOIN UserRoles R ON UR.UserRoleID = R.UserRoleID
                              WHERE U.Username LIKE '%{searchQuery}%'";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Прив'язка даних до DataGridView
                    dataGridViewUsers.DataSource = dataTable;

                    // Перейменування стовпців
                    dataGridViewUsers.Columns["UserID"].HeaderText = "User ID";
                    dataGridViewUsers.Columns["Username"].HeaderText = "Username";
                    dataGridViewUsers.Columns["Email"].HeaderText = "Email";
                    dataGridViewUsers.Columns["RoleName"].HeaderText = "Role";

                    // Автоматичне вирівнювання стовпців
                    dataGridViewUsers.AutoResizeColumns();
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
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                // Отримання ID вибраного користувача з DataGridView
                int selectedUserID = (int)dataGridViewUsers.SelectedRows[0].Cells["UserID"].Value;

                // Видалення запису про користувача з таблиці UserInRoles
                string deleteUserRoleQuery = $"DELETE FROM UserInRoles WHERE UserID = {selectedUserID}";
                using (SqlConnection connection = new SqlConnection(_connectionString))
                using (SqlCommand command = new SqlCommand(deleteUserRoleQuery, connection))
                {
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting user roles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Видалення користувача з таблиці Users
                string deleteUserQuery = $"DELETE FROM Users WHERE UserID = {selectedUserID}";
                using (SqlConnection connection = new SqlConnection(_connectionString))
                using (SqlCommand command = new SqlCommand(deleteUserQuery, connection))
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
                MessageBox.Show("Please select a user to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); // Закриття форми
        }
    }
}
