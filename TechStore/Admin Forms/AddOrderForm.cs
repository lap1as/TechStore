using System;
using System.Windows.Forms;
using TechStore.Models;

namespace TechStore.Admin_Forms
{
    public partial class AddOrderForm : Form
    {
        private readonly DatabaseService _databaseService;

        public AddOrderForm()
        {
            InitializeComponent();
            _databaseService = new DatabaseService();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Логіка для збереження нового замовлення в базі даних
            try
            {
                string query = $"INSERT INTO Orders (OrderID, CustomerID, OrderDate, TotalAmount) VALUES ({txtOrderID.Text}, {txtCustomerID.Text}, '{txtOrderDate.Text}', {txtTotalAmount.Text})";

                // Виконання SQL-запиту
                _databaseService.ExecuteQuery(query);

                MessageBox.Show("Order added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // Закриття форми
        }
    }
}
