using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using TechStore.Admin_Forms;

namespace TechStore
{
    public partial class MainForm : Form
    {
        private readonly string _connectionString;
        private System.Windows.Forms.Timer _timer;

        public MainForm()
        {
            InitializeComponent();
            _connectionString = @"Data Source=LAPLAS;Initial Catalog=TechStore;Integrated Security=True;User Id=techstore;Password=techstore;Encrypt=False";
            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 15000; // 15 секунд
            _timer.Tick += Timer_Tick;
            _timer.Start();
            UpdateStatistics(); // Оновлення статистики при запуску форми
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateStatistics();
        }

        private void UpdateStatistics()
        {
            int usersCount = GetUsersCount();
            int ordersCount = GetOrdersCount();
            label_Statistics.Text = $"Users Count: {usersCount} Orders Count: {ordersCount}";
        }

        private int GetUsersCount()
        {
            int usersCount = 0;
            string query = "SELECT COUNT(*) FROM Users";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    usersCount = (int)command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error getting users count: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return usersCount;
        }

        private int GetOrdersCount()
        {
            int ordersCount = 0;
            string query = "SELECT COUNT(*) FROM Orders";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    ordersCount = (int)command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error getting orders count: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return ordersCount;
        }

        private void btnCategoryManagement_Click(object sender, EventArgs e)
        {
            CategoryManagementForm categoryManagementForm = new CategoryManagementForm();
            categoryManagementForm.ShowDialog();
        }

        private void btnOrderManagement_Click(object sender, EventArgs e)
        {
            OrderManagementForm orderManagementForm = new OrderManagementForm();
            orderManagementForm.ShowDialog();
        }

        private void btnProductManagement_Click(object sender, EventArgs e)
        {
            ProductManagementForm productManagementForm = new ProductManagementForm();
            productManagementForm.ShowDialog();
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            UserManagementForm userManagementForm = new UserManagementForm();
            userManagementForm.ShowDialog();
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

    }
}
