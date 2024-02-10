using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechStore
{
    public partial class LoginForm : Form
    {
        private readonly TechStoreContext _context;

        public LoginForm()
        {
            InitializeComponent();
            _context = new TechStoreContext();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            var user = _context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                MessageBox.Show("User Found.", "Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("User Doesent exist", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void CheckDatabaseConnection()
        {
            try
            {
                _context.Database.CanConnect();
                MessageBox.Show("Підключення до бази даних успішне.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не вдалося підключитися до бази даних. Помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Додайте цей метод до події, яка запускає перевірку підключення, наприклад, при завантаженні форми або натисканні кнопки.
        private void CheckConnectionButton_Click(object sender, EventArgs e)
        {
            CheckDatabaseConnection();
        }
    }
}
