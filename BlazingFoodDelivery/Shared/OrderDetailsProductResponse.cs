using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazingFoodDelivery.Shared
{
    public class OrderDetailsProductResponse
    {
        public int MenuItemId { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
