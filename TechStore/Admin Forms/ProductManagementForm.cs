using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TechStore.Admin_Forms
{
    public partial class ProductManagementForm : Form
    {
        private readonly string _connectionString;

        public ProductManagementForm()
        {
            InitializeComponent();
            _connectionString = @"Data Source=LAPLAS;Initial Catalog=TechStore;Integrated Security=True;User Id=techstore;Password=techstore;Encrypt=False";
            LoadProducts(); // Завантаження списку продуктів при завантаженні форми
        }

        private void LoadProducts()
        {
            string query = "SELECT * FROM Products";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    // Очищення DataGridView перед завантаженням нових продуктів
                    dataGridViewProducts.Rows.Clear();
                    dataGridViewProducts.Columns.Clear();

                    // Додавання стовпців до DataGridView
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        dataGridViewProducts.Columns.Add(reader.GetName(i), reader.GetName(i));
                    }

                    // Додавання продуктів до DataGridView
                    while (reader.Read())
                    {
                        object[] values = new object[reader.FieldCount];
                        reader.GetValues(values);
                        dataGridViewProducts.Rows.Add(values);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Отримання пошукового запиту з текстового поля
            string searchQuery = txtSearch.Text.Trim();

            string query = $"SELECT * FROM Products WHERE Name LIKE '%{searchQuery}%'";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    // Очищення даних в DataGridView перед завантаженням нових продуктів
                    dataGridViewProducts.Rows.Clear();

                    // Додавання відфільтрованих продуктів до DataGridView
                    while (reader.Read())
                    {
                        object[] values = new object[reader.FieldCount];
                        reader.GetValues(values);
                        dataGridViewProducts.Rows.Add(values);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error searching products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            // Відкриття форми для додавання нового продукту
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ConnectionString = _connectionString;
            addProductForm.ShowDialog();

            // Після закриття форми оновлюємо список продуктів
            LoadProducts();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            // Перевірка, чи вибрано продукт для видалення
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                // Отримання ID вибраного продукту з DataGridView
                int selectedProductID = (int)dataGridViewProducts.SelectedRows[0].Cells["ProductID"].Value;

                string deleteQuery = $"DELETE FROM Products WHERE ProductID = {selectedProductID}";

                using (SqlConnection connection = new SqlConnection(_connectionString))
                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Після видалення продукту оновлюємо список
                            LoadProducts();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a product to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void dataGridViewProducts_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;
            string columnName = dataGridViewProducts.Columns[columnIndex].Name;
            object newValue = dataGridViewProducts.Rows[rowIndex].Cells[columnIndex].Value;

            // Отримуємо ID продукту, який був змінений
            int productID = (int)dataGridViewProducts.Rows[rowIndex].Cells["ProductID"].Value;

            // Змінюємо дані у базі даних
            string updateQuery = $"UPDATE Products SET {columnName} = @Value WHERE ProductID = @ProductID";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand(updateQuery, connection))
            {
                command.Parameters.AddWithValue("@Value", newValue);
                command.Parameters.AddWithValue("@ProductID", productID);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Product updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to update product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); // Закриття форми
        }
    }
}
