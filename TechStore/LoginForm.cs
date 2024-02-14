using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TechStore
{
    public partial class LoginForm : Form
    {
        private readonly string _connectionString;

        public LoginForm()
        {
            InitializeComponent();
            _connectionString = @"Data Source=LAPLAS;Initial Catalog=TechStore;Integrated Security=True;User Id=techstore;Password=techstore;Encrypt=False";
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            string query = @"SELECT COUNT(*) 
                             FROM Users 
                             INNER JOIN UserInRoles ON Users.UserID = UserInRoles.UserID
                             INNER JOIN UserRoles ON UserInRoles.UserRoleID = UserRoles.UserRoleID
                             WHERE Username = @Username AND Password = @Password AND RoleName = 'Admin'";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                try
                {
                    connection.Open();
                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("User Found.", "Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        // Відкриття головної форми для адміністратора, якщо він залогінений успішно
                        MainForm mainPage = new MainForm();
                        mainPage.ShowDialog();
                        
                    }
                    else
                    {
                        MessageBox.Show("User Doesn't Exist or Doesn't Have Admin Privileges", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CheckDatabaseConnection()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Connection to the database successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to connect to the database. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Додайте цей метод до події, яка запускає перевірку підключення, наприклад, при завантаженні форми або натисканні кнопки.
        private void CheckConnectionButton_Click(object sender, EventArgs e)
        {
            CheckDatabaseConnection();
        }
    }
}
