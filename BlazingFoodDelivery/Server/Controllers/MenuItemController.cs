﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazingFoodDelivery.Server.Data;
using BlazingFoodDelivery.Server.Services.MenuItemService;
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
        private readonly IMenuItemService _menuItemService;

        public MenuItemController(IMenuItemService menuItemService)
        {
            _menuItemService = menuItemService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<MenuItem>>>> GetMenuItems()
        {
            var result = await _menuItemService.GetMenuItemsAsync();
            return Ok(result);
        }

        [HttpGet("{menuItemId}")]
        public async Task<ActionResult<ServiceResponse<MenuItem>>> GetMenuItem(int menuItemId)
        {
            var result = await _menuItemService.GetMenuItemAsync(menuItemId);
            return Ok(result);
        }

        [HttpGet("category/{categoryUrl}")]
        public async Task<ActionResult<ServiceResponse<List<MenuItem>>>> GetMenuItemsByCategory(string categoryUrl)
        {
            var result = await _menuItemService.GetMenuItemsByCategory(categoryUrl);
            return Ok(result);
        }

        [HttpGet("search/{searchText}/{page}")]
        public async Task<ActionResult<ServiceResponse<MenuItemSearchResult>>> SearchMenuItems(string searchText, int page = 1)
        {
            var result = await _menuItemService.SearchMenuItems(searchText, page);
            return Ok(result);
        }

        [HttpGet("searchsuggestions/{searchText}")]
        public async Task<ActionResult<ServiceResponse<List<MenuItem>>>> GetMenuItemSearchSuggestions(string searchText)
        {
            var result = await _menuItemService.GetMenuItemSearchSuggestions(searchText);
            return Ok(result);
        }

        [HttpGet("featured")]
        public async Task<ActionResult<ServiceResponse<List<MenuItem>>>> GetFeaturedMenuItems()
        {
            var result = await _menuItemService.GetFeaturedMenuItems();
            return Ok(result);
        }
    }
}
