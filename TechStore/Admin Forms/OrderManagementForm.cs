using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace TechStore.Admin_Forms
{
    public partial class OrderManagementForm : Form
    {
        private readonly string _connectionString;

        public OrderManagementForm()
        {
            InitializeComponent();
            _connectionString = @"Data Source=LAPLAS;Initial Catalog=TechStore;Integrated Security=True;User Id=techstore;Password=techstore;Encrypt=False";
            LoadOrders(); // Завантаження списку замовлень при завантаженні форми
        }

        private void LoadOrders()
        {
            string query = "SELECT OrderID, CustomerID, OrderDate, TotalAmount FROM Orders";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    // Очищення списку перед завантаженням нових замовлень
                    listBoxOrders.Items.Clear();

                    // Додавання замовлень до списку
                    while (reader.Read())
                    {
                        listBoxOrders.Items.Add($"Order ID: {reader["OrderID"]}, Customer ID: {reader["CustomerID"]}, Order Date: {reader["OrderDate"]}, Total Amount: {(decimal)reader["TotalAmount"]:C}");
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading orders: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Отримання пошукового запиту з текстового поля
            string searchQuery = txtSearch.Text.Trim();

            string query = $"SELECT OrderID, CustomerID, OrderDate, TotalAmount FROM Orders WHERE CustomerID LIKE '%{searchQuery}%' OR OrderID = '{searchQuery}'";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    // Очищення списку перед завантаженням нових замовлень
                    listBoxOrders.Items.Clear();

                    // Додавання відфільтрованих замовлень до списку
                    while (reader.Read())
                    {
                        listBoxOrders.Items.Add($"Order ID: {reader["OrderID"]}, Customer ID: {reader["CustomerID"]}, Order Date: {reader["OrderDate"]}, Total Amount: {(decimal)reader["TotalAmount"]:C}");
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error searching orders: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            // Відкриття форми для додавання нового замовлення
            AddOrderForm addOrderForm = new AddOrderForm();
            addOrderForm.ShowDialog();

            // Після закриття форми оновлюємо список замовлень
            LoadOrders();
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            // Перевірка, чи вибрано замовлення для видалення
            if (listBoxOrders.SelectedItem != null)
            {
                // Отримання ID вибраного замовлення з тексту в ListBox
                string selectedOrderIDText = listBoxOrders.SelectedItem.ToString();
                int index = selectedOrderIDText.IndexOf("Order ID:");
                if (index != -1)
                {
                    index += "Order ID:".Length;
                }
                int endIndex = selectedOrderIDText.IndexOf(",", index);
                string orderIDSubstring = selectedOrderIDText.Substring(index, endIndex - index).Trim();
                int selectedOrderID;
                if (int.TryParse(orderIDSubstring, out selectedOrderID))
                {
                    // Перевірка наявності зв'язаних записів деталей замовлення
                    string checkOrderDetailsQuery = $"SELECT COUNT(*) FROM OrderDetails WHERE OrderID = {selectedOrderID}";

                    using (SqlConnection connection = new SqlConnection(_connectionString))
                    using (SqlCommand command = new SqlCommand(checkOrderDetailsQuery, connection))
                    {
                        try
                        {
                            connection.Open();
                            int orderDetailsCount = (int)command.ExecuteScalar();

                            if (orderDetailsCount > 0)
                            {
                                MessageBox.Show("Cannot delete order because there are associated order details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error checking order details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Видалення самого замовлення
                    string deleteOrderQuery = $"DELETE FROM Orders WHERE OrderID = {selectedOrderID}";

                    using (SqlConnection connection = new SqlConnection(_connectionString))
                    using (SqlCommand command = new SqlCommand(deleteOrderQuery, connection))
                    {
                        try
                        {
                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Order deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Після видалення замовлення оновлюємо список
                                LoadOrders();
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error deleting order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error parsing order ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); // Закриття форми
        }
    }
}
