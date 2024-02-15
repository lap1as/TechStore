using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TechStore.Admin_Forms
{
    public partial class AddUserForm : Form
    {
        private readonly string _connectionString;

        public AddUserForm(string connectionString)
        {
            InitializeComponent();
            _connectionString = connectionString;

            // При завантаженні форми заповнюємо випадаючий список ролями
            LoadRoles();
        }

        private void LoadRoles()
        {
            string query = "SELECT UserRoleID, RoleName FROM UserRoles";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    // Очищаємо список ролей перед додаванням нових
                    cmbRoles.Items.Clear();

                    // Додавання ролей до випадаючого списку
                    while (reader.Read())
                    {
                        int roleId = (int)reader["UserRoleID"];
                        string roleName = (string)reader["RoleName"];
                        cmbRoles.Items.Add(new UserRole(roleId, roleName));
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading roles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Зчитуємо дані з текстових полів форми
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string email = txtEmail.Text;

            // Перевірка, чи вибрана роль випадаючим списком
            if (cmbRoles.SelectedItem == null)
            {
                MessageBox.Show("Please select a role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int roleId = ((UserRole)cmbRoles.SelectedItem).Id;

            try
            {
                // Створюємо SQL-запит для додавання користувача з параметрами
                string query = "INSERT INTO Users (Username, Password, Email) VALUES (@Username, @Password, @Email); " +
                               "INSERT INTO UserInRoles (UserID, UserRoleID) VALUES (SCOPE_IDENTITY(), @UserRoleID)";

                // Встановлюємо з'єднання з базою даних
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    // Відкриваємо з'єднання
                    connection.Open();

                    // Створюємо команду для виконання SQL-запиту
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Додаємо параметри до команди
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@UserRoleID", roleId);

                        // Виконуємо SQL-запит
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DialogResult = DialogResult.OK;
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    public class UserRole
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public UserRole(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
