using System.Collections.Generic;
using System.Threading.Tasks;
using Backomm.Contracts.V1;
using Backomm.Contracts.V1.Requests;
using Backomm.Contracts.V1.Responses;
using Backomm.Models;
using Backomm.Services;
using Microsoft.AspNetCore.Mvc;

namespace Backomm.Controllers.V1
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet(ApiRoutes.Category.Get)]
        public async Task<IActionResult> GetAllCategories()
        {

            var model = await _categoryService.GetAllCategoriesAsync();

            if (model == null)
            {    
                return NotFound();
            }

            var response = new CategoryResponse
            {
                Code = "success",
                Message = "categories.get.success",
                Data = model
            };
            
            return Ok(response);
        }

        [HttpGet(ApiRoutes.Category.GetById)]
        public async Task<IActionResult> GetCategoryById([FromRoute] CategoryRequest request)
        {
            var model = await _categoryService.GetCategoryByIdAsync(request.CategoryId);

            if (model == null)
            {
                return NotFound();
            }

            var response = new CategoryGetByIdResponse
            {
                Code = "success",
                Message = "get.category.success",
                Data = model
            };

            return Ok(response);
        }
    }
}