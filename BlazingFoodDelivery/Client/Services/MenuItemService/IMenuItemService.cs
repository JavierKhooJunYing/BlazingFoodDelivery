using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazingFoodDelivery.Shared;

namespace BlazingFoodDelivery.Client.Services.MenuItemService
{
    public interface IMenuItemService
    {
        List<MenuItem> MenuItems { get; set; }
        Task GetMenuItems();
    }
}
