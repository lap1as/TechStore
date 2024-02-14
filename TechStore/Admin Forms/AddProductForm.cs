using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TechStore.Admin_Forms
{
    public partial class AddProductForm : Form
    {
        private string _connectionString;

        public string ConnectionString
        {
            get { return _connectionString; }
            set { _connectionString = value; }
        }

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
            decimal price = 0;
            int stockQuantity = 0;
            int categoryID = 0;

            // Перевірка та конвертація значень
            if (!decimal.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("Invalid input for price. Please enter a valid decimal value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out stockQuantity))
            {
                MessageBox.Show("Invalid input for stock quantity. Please enter a valid integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtCategory.Text, out categoryID))
            {
                MessageBox.Show("Invalid input for category ID. Please enter a valid integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
