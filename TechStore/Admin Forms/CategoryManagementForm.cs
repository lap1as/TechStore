using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TechStore.Admin_Forms
{
    public partial class CategoryManagementForm : Form
    {
        private readonly string _connectionString;

        public CategoryManagementForm()
        {
            InitializeComponent();
            _connectionString = @"Data Source=LAPLAS;Initial Catalog=TechStore;Integrated Security=True;User Id=techstore;Password=techstore;Encrypt=False";
            LoadCategories(); // Завантаження списку категорій при завантаженні форми
        }

        private void LoadCategories()
        {
            string query = "SELECT CategoryID, CategoryName FROM Categories";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    // Очищення DataGridView перед завантаженням нових категорій
                    dataGridViewCategories.Rows.Clear();
                    dataGridViewCategories.Columns.Clear();

                    // Додавання стовпців до DataGridView
                    dataGridViewCategories.Columns.Add("CategoryID", "Category ID");
                    dataGridViewCategories.Columns.Add("CategoryName", "CategoryName");

                    // Додавання категорій до DataGridView
                    while (reader.Read())
                    {
                        dataGridViewCategories.Rows.Add(reader["CategoryID"], reader["CategoryName"]);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading categories: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string categoryName = txtCategoryName.Text.Trim();

            if (!string.IsNullOrEmpty(categoryName))
            {
                string insertQuery = "INSERT INTO Categories (CategoryName) VALUES (@CategoryName)";

                using (SqlConnection connection = new SqlConnection(_connectionString))
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@CategoryName", categoryName);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Category added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadCategories(); // Оновлюємо список категорій
                        }
                        else
                        {
                            MessageBox.Show("Failed to add category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error adding category: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a category name.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            // Перевірка, чи вибрано категорію для видалення
            if (dataGridViewCategories.SelectedRows.Count > 0)
            {
                // Отримання ID вибраної категорії з DataGridView
                int selectedCategoryID = (int)dataGridViewCategories.SelectedRows[0].Cells["CategoryID"].Value;

                string deleteQuery = $"DELETE FROM Categories WHERE CategoryID = {selectedCategoryID}";

                using (SqlConnection connection = new SqlConnection(_connectionString))
                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Category deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Після видалення категорії оновлюємо список
                            LoadCategories();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting category: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a category to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); // Закриття форми
        }
    }
}
