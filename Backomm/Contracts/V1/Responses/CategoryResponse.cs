using System.Collections.Generic;
using Backomm.Models;

namespace Backomm.Contracts.V1.Responses
{
    public class CategoryResponse : BaseResponse<List<Category>> { }
    
    public class CategoryGetByIdResponse : BaseResponse<Category> {}
}