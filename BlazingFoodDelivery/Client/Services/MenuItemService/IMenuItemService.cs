using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazingFoodDelivery.Shared;

namespace BlazingFoodDelivery.Client.Services.MenuItemService
{
    public interface IMenuItemService
    {
        event Action MenuItemsChanged;
        List<MenuItem> MenuItems { get; set; }
        string Message { get; set; }
        int CurrentPage { get; set; }
        int PageCount { get; set; }
        string LastSearchText { get; set; }
        Task GetMenuItems(string categoryUrl = null);
        Task<ServiceResponse<MenuItem>> GetMenuItem(int menuItemId);
        Task SearchMenuItems(string searchText, int page);
        Task<List<string>> GetMenuItemSearchSuggestions(string searchText);
    }
}
