using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazingFoodDelivery.Server.Data;
using BlazingFoodDelivery.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazingFoodDelivery.Server.Services.MenuItemService
{
    public class MenuItemService : IMenuItemService
    {
        private readonly DataContext _context;

        public MenuItemService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<MenuItem>>> GetMenuItemsAsync()
        {
            var response = new ServiceResponse<List<MenuItem>>
            {
                Data = await _context.MenuItems.ToListAsync()
            };

            return response;
        }
    }
}
