using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace TechStore.Admin_Forms
{
    public partial class AddProductForm : Form
    {
        private readonly string _connectionString;

        public AddProductForm()
        {
            InitializeComponent();
            // Рядок підключення до бази даних
            _connectionString = @"Data Source=LAPLAS;Initial Catalog=TechStore;Integrated Security=True;User Id=techstore;Password=techstore;Encrypt=False";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Параметри для нового товару
            string name = txtName.Text;
            string description = txtDescription.Text;
            decimal price = decimal.Parse(txtPrice.Text);
            int stockQuantity = int.Parse(txtQuantity.Text);
            int categoryID = int.Parse(txtCategory.Text); // Відповідно до вашої логіки

            // SQL-запит для вставки нового товару
            string query = @"INSERT INTO Products (Name, Description, Price, StockQuantity, CategoryID) 
                         VALUES (@Name, @Description, @Price, @StockQuantity, @CategoryID)";

            // Виконання SQL-запиту
            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Додавання параметрів до запиту
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Description", description);
                command.Parameters.AddWithValue("@Price", price);
                command.Parameters.AddWithValue("@StockQuantity", stockQuantity);
                command.Parameters.AddWithValue("@CategoryID", categoryID);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Product added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
