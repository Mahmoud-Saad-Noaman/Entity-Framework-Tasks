using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project__One_E_commerce_System.Models
{
    public class Order
    {
        #region Properties
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;
        public List<OrderDetail> OrderDetails { get; set; } = new();
        #endregion
    }
}
