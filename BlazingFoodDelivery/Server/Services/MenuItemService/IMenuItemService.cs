﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazingFoodDelivery.Shared;

namespace BlazingFoodDelivery.Server.Services.MenuItemService
{
    public interface IMenuItemService
    {
        Task<ServiceResponse<List<MenuItem>>> GetMenuItemsAsync();
    }
}