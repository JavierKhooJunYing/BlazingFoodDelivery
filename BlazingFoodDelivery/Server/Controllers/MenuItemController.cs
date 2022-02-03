using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazingFoodDelivery.Server.Data;
using BlazingFoodDelivery.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazingFoodDelivery.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemController : ControllerBase
    {
        private readonly DataContext _context;

        public MenuItemController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<MenuItem>>> GetMenuItem()
        {
            var menuItems = await _context.MenuItems.ToListAsync();
            return Ok(menuItems);
        }
    }
}
