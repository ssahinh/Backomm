using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Backomm.Contracts.V1;
using Backomm.Contracts.V1.Requests;
using Backomm.Contracts.V1.Responses;
using Backomm.Models;
using Backomm.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http;

namespace Backomm.Controllers.V1
{
    public class WebServiceController : Controller
    {
        private readonly IWebServicesService _service;
        private readonly UserManager<ApplicationUser> _userManager;

        public WebServiceController(IWebServicesService service, UserManager<ApplicationUser> userManager)
        {
            _service = service;
            _userManager = userManager;
        }

        [HttpGet(ApiRoutes.WebServices.Get)]
        public async Task<IActionResult> GetAllServices()
        {
            var model = await _service.GetAllServicesAsync();

            var response = new WebServiceGetResponse
            {
                Code = "success",
                Message = "get.services.success",
                Data = model
            };
            
            return Ok(response);
        }

        [HttpPost(ApiRoutes.WebServices.CreateService)]
        public async Task<IActionResult> CreateService([FromBody] CreateServiceRequest serviceRequest)
        {
            var user = this.GetUser();
            
            var service = new Api
            {
                Title = serviceRequest.Title,
                Description = serviceRequest.Description,
            };
            var model = await _service.CreateServiceAsync(service, await user);

            var response = new WebServiceResponse
            {
                Code = "success",
                Message = "service.create.success",
                Data = service
            };

            return Ok(response);
        }
        
        private async Task<ApplicationUser> GetUser()
        {
            ClaimsPrincipal currentUser = this.User;
            var currentUserName = currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;
            ApplicationUser user = await _userManager.FindByNameAsync(currentUserName);

            return user;
        }
        
    }
}