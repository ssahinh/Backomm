using System.Threading.Tasks;
using Backomm.Contracts.V1;
using Backomm.Contracts.V1.Requests;
using Backomm.Contracts.V1.Responses;
using Backomm.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Backomm.Controllers.V1
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class CityController : Controller
    {
        private readonly ICityService _cityService;

        public CityController(ICityService cityService)
        {
            _cityService = cityService;
        }

        [HttpGet(ApiRoutes.City.Get)]
        public async Task<IActionResult> GetCities()
        {
            var model = await _cityService.GetAllCitiesAsync();

            var response = new CityResponse
            {
                Code = "success",
                Message = "cities.get.success",
                Data = model,
            };

            return Ok(response);
        }

        [HttpGet(ApiRoutes.City.GetById)]
        public async Task<IActionResult> GetCityById([FromRoute] CityRequest request)
        {
            var model = await _cityService.GetCityByIdAsync(request.CityId);

            if (model == null)
            {
                return BadRequest();
            }

            var response = new CityGetByIdResponse
            {
                Code = "success",
                Message = "city.get.success",
                Data = model
            };

            return Ok(model);
        }
        
    }
}