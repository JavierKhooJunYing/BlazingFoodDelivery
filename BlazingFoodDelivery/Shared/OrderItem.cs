using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazingFoodDelivery.Shared
{
    public class OrderItem
    {
        public Order Order { get; set; }
        public int OrderId { get; set; }
        public MenuItem MenuItem { get; set; }
        public int MenuItemId { get; set; }
        public int Quantity { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalPrice { get; set; }
    }
}
