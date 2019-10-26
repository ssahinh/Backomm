using System.Collections.Generic;
using System.Threading.Tasks;
using Backomm.Models;

namespace Backomm.Services
{
    public interface ICategoryService
    {
        Task<List<Category>> GetAllCategoriesAsync();

        Task<Category> GetCategoryByIdAsync(int CategoryId);
    }
}