using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project__One_E_commerce_System.Models
{
    public class Product
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
        public List<OrderDetail> OrderDetails { get; set; } = new();
        #endregion
    }
}
