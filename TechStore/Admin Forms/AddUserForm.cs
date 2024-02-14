using System;
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
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Зчитайте дані з текстових полів форми
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string email = txtEmail.Text;

            try
            {
                // Створіть SQL-запит для додавання користувача з параметрами
                string query = "INSERT INTO Users (Username, Password, Email) VALUES (@Username, @Password, @Email)";

                // Встановіть з'єднання з базою даних
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    // Відкрийте з'єднання
                    connection.Open();

                    // Створіть команду для виконання SQL-запиту
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Додайте параметри до команди
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@Email", email);

                        // Виконайте SQL-запит
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
}
