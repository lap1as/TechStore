using System;
using System.Windows.Forms;
using TechStore.Models;
using Microsoft.Data.SqlClient;

namespace TechStore.Admin_Forms
{
    public partial class AddOrderForm : Form
    {
        private readonly DatabaseService _databaseService;

        public AddOrderForm()
        {
            InitializeComponent();
            _databaseService = new DatabaseService();
            LoadProducts(); // Завантаження списку товарів при ініціалізації форми
        }

        private void LoadProducts()
        {
            string query = "SELECT Name FROM Products";

            try
            {
                using (SqlDataReader reader = _databaseService.ExecuteReader(query))
                {
                    while (reader.Read())
                    {
                        comboBoxProducts.Items.Add(reader["Name"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Вставка нового замовлення в таблицю Orders
                string orderInsertQuery = $"INSERT INTO Orders (CustomerID, OrderDate, TotalAmount) VALUES ({txtCustomerID.Text}, '{txtOrderDate.Text}', {txtTotalAmount.Text}); SELECT SCOPE_IDENTITY();";
                int orderID = Convert.ToInt32(_databaseService.ExecuteScalar(orderInsertQuery));

                // Отримання інформації про товар за назвою
                string selectedProduct = comboBoxProducts.SelectedItem.ToString();
                string productQuery = $"SELECT ProductID, Price FROM Products WHERE Name = '{selectedProduct}'";

                using (SqlDataReader reader = _databaseService.ExecuteReader(productQuery))
                {
                    if (reader.Read())
                    {
                        int productID = Convert.ToInt32(reader["ProductID"]);
                        decimal unitPrice = Convert.ToDecimal(reader["Price"]);

                        // Вставка товару до замовлення в таблицю OrderDetails
                        string orderDetailInsertQuery = $"INSERT INTO OrderDetails (OrderID, ProductID, Quantity, UnitPrice) VALUES ({orderID}, {productID}, {txtQuantity.Text}, {unitPrice})";
                        _databaseService.ExecuteQuery(orderDetailInsertQuery);

                        MessageBox.Show("Order added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
