using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BlazingFoodDelivery.Shared;

namespace BlazingFoodDelivery.Client.Services.MenuItemService
{
    public class MenuItemService : IMenuItemService
    {
        private readonly HttpClient _http;

        public MenuItemService(HttpClient http)
        {
            _http = http;
        }
        public List<MenuItem> MenuItems { get; set; } = new List<MenuItem>();

        public async Task GetMenuItems()
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<MenuItem>>>("api/menuitem");
            if (result != null && result.Data != null)
            {
                MenuItems = result.Data;
            }       
        }
    }
}
