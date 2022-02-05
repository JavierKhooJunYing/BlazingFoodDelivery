using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazingFoodDelivery.Server.Data;
using BlazingFoodDelivery.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazingFoodDelivery.Server.Services.CartService
{
    public class CartService : ICartService
    {
        private readonly DataContext _context;

        public CartService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<CartProductResponse>>> GetCartProducts(List<CartItem> cartItems)
        {
            var result = new ServiceResponse<List<CartProductResponse>>
            {
                Data = new List<CartProductResponse>()
            };

            foreach (var item in cartItems)
            {
                var menuItem = await _context.MenuItems
                        .Where(p => p.Id == item.MenuItemId)
                        .FirstOrDefaultAsync();
                
                if (menuItem == null)
                {
                    continue;
                }

                var cartProduct = new CartProductResponse
                {
                    MenuItemId = menuItem.Id,
                    Title = menuItem.Title,
                    ImageUrl = menuItem.ImageUrl,
                    Price = menuItem.Price,
                    Quantity = item.Quantity
                };

                result.Data.Add(cartProduct);                           
            }

            return result;
        }
    }
}
