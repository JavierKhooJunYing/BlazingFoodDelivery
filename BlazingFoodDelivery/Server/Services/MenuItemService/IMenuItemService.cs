using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazingFoodDelivery.Shared;

namespace BlazingFoodDelivery.Server.Services.MenuItemService
{
    public interface IMenuItemService
    {
        Task<ServiceResponse<List<MenuItem>>> GetMenuItemsAsync();
        Task<ServiceResponse<MenuItem>> GetMenuItemAsync(int menuItemId);
        Task<ServiceResponse<List<MenuItem>>> GetMenuItemsByCategory(string categoryUrl);
        Task<ServiceResponse<MenuItemSearchResult>> SearchMenuItems(string searchText, int page);
        Task<ServiceResponse<List<string>>> GetMenuItemSearchSuggestions(string searchText);
        Task<ServiceResponse<List<MenuItem>>> GetFeaturedMenuItems();
    }
}
