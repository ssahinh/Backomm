using System.Collections.Generic;
using System.Threading.Tasks;
using Backomm.Data;
using Backomm.Models;
using Microsoft.EntityFrameworkCore;

namespace Backomm.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly DataContext _dataContext;

        public CategoryService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<Category>> GetAllCategoriesAsync()
        {
            return await _dataContext.Categories.ToListAsync();
        }

        public async Task<Category> GetCategoryByIdAsync(int CategoryId)
        {
            return await _dataContext.Categories
                .Include(category => category.Groups)
                .SingleOrDefaultAsync(x => x.Id == CategoryId);
        }
    }
}