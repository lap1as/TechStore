using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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
            string query = @"SELECT O.OrderID, O.CustomerID, O.OrderDate, O.TotalAmount, P.Price
                             FROM Orders O
                             INNER JOIN OrderDetails OD ON O.OrderID = OD.OrderID
                             INNER JOIN Products P ON OD.ProductID = P.ProductID";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                try
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Прив'язка даних до DataGridView
                    dataGridViewOrders.DataSource = dataTable;

                    // Перейменування стовпців
                    dataGridViewOrders.Columns["OrderID"].HeaderText = "Order ID";
                    dataGridViewOrders.Columns["CustomerID"].HeaderText = "Customer ID";
                    dataGridViewOrders.Columns["OrderDate"].HeaderText = "Order Date";
                    dataGridViewOrders.Columns["TotalAmount"].HeaderText = "Total Amount";
                    

                    // Додавання події CellFormatting для підрахунку загальної суми за замовлення
                    dataGridViewOrders.CellFormatting += DataGridViewOrders_CellFormatting;

                    // Автоматичне вирівнювання стовпців
                    dataGridViewOrders.AutoResizeColumns();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading orders: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DataGridViewOrders_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dataGridViewOrders.Columns[e.ColumnIndex].Name == "Price")
                {
                    if (dataGridViewOrders.Rows[e.RowIndex].Cells["Price"].Value != null)
                    {
                        decimal price = Convert.ToDecimal(dataGridViewOrders.Rows[e.RowIndex].Cells["Price"].Value);
                        e.Value = price.ToString("C");
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Отримання пошукового запиту з текстового поля
            string searchQuery = txtSearch.Text.Trim();

            string query = $"SELECT O.OrderID, O.CustomerID, O.OrderDate, O.TotalAmount, P.Price " +
                           $"FROM Orders O " +
                           $"INNER JOIN OrderDetails OD ON O.OrderID = OD.OrderID " +
                           $"INNER JOIN Products P ON OD.ProductID = P.ProductID " +
                           $"WHERE O.CustomerID LIKE '%{searchQuery}%' OR O.OrderID = '{searchQuery}'";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                try
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Прив'язка даних до DataGridView
                    dataGridViewOrders.DataSource = dataTable;
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
            if (dataGridViewOrders.SelectedRows.Count > 0)
            {
                // Отримання ID вибраного замовлення з DataGridView
                int selectedOrderID = (int)dataGridViewOrders.SelectedRows[0].Cells["OrderID"].Value;

                // Ваш код для видалення замовлення
                // ...
            }
            else
            {
                MessageBox.Show("Please select an order to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); // Закриття форми
        }
    }
}
