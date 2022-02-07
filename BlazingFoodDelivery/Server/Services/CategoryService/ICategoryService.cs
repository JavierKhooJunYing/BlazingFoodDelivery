using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazingFoodDelivery.Shared;

namespace BlazingFoodDelivery.Server.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<ServiceResponse<List<Category>>> GetCategories();
        Task<ServiceResponse<List<Category>>> GetAdminCategories();
        Task<ServiceResponse<List<Category>>> AddCategory(Category category);
        Task<ServiceResponse<List<Category>>> UpdateCategory(Category category);
        Task<ServiceResponse<List<Category>>> DeleteCategory(int id);
    }
}
