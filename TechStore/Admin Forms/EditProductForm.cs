using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using TechStore.Models;

namespace TechStore.Admin_Forms
{
    public partial class EditProductForm : Form
    {
        private readonly string _connectionString;
        private readonly Product _product;

        public EditProductForm(Product product)
        {
            InitializeComponent();
            _connectionString = @"Data Source=LAPLAS;Initial Catalog=TechStore;Integrated Security=True;User Id=techstore;Password=techstore;Encrypt=False";
            _product = product;

            // Встановлення початкових значень у текстові поля форми
            txtName.Text = _product.Name;
            txtDescription.Text = _product.Description;
            txtPrice.Text = _product.Price.ToString();
            txtQuantity.Text = _product.StockQuantity.ToString();
            txtCategory.Text = _product.CategoryID.ToString(); // Відповідно до вашої логіки
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // SQL-запит для оновлення існуючого товару
            string query = @"UPDATE Products 
                             SET Name = @Name, Description = @Description, Price = @Price, StockQuantity = @StockQuantity, CategoryID = @CategoryID 
                             WHERE ProductID = @ProductID";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Додавання параметрів до запиту
                command.Parameters.AddWithValue("@Name", txtName.Text);
                command.Parameters.AddWithValue("@Description", txtDescription.Text);
                command.Parameters.AddWithValue("@Price", decimal.Parse(txtPrice.Text));
                command.Parameters.AddWithValue("@StockQuantity", int.Parse(txtQuantity.Text));
                command.Parameters.AddWithValue("@CategoryID", int.Parse(txtCategory.Text));
                command.Parameters.AddWithValue("@ProductID", _product.ProductID); // ID оновлюваного товару

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Product updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // Закриття форми
        }
    }
}
