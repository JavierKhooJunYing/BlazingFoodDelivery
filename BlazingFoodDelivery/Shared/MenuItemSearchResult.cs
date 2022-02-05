using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazingFoodDelivery.Shared
{
    public class MenuItemSearchResult
    {
        public List<MenuItem> MenuItems { get; set; } = new List<MenuItem>();
        public int Pages { get; set; }
        public int CurrentPage { get; set; }
    }
}
