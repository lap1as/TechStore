using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechStore.Models
{
    public class Categories
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        // Додайте інші поля, які можуть бути потрібні для категорій
        // Наприклад, опис категорії, інформація про батьківську категорію тощо

        public Categories()
        {
            // Порожній конструктор
        }

        // Додайте інші конструктори, якщо потрібно
    }
}
