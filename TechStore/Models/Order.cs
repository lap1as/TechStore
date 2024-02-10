using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechStore.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }  // Ідентифікатор покупця, який зробив замовлення
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        // Інші властивості, які можуть бути додані, наприклад, статус замовлення
    }

}
