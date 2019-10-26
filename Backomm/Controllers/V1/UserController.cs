using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Backomm.Contracts.V1;
using Backomm.Contracts.V1.Responses;
using Backomm.Data;
using Backomm.Models;
using Backomm.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backomm.Controllers.V1
{
    public class UserController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUserService _userService;
        private readonly DataContext _dataContext;

        public UserController(UserManager<ApplicationUser> userManager, IUserService userService, DataContext dataContext)
        {
            _userManager = userManager;
            _userService = userService;
            _dataContext = dataContext;
        }

        [HttpGet(ApiRoutes.User.Me)]
        public async Task<IActionResult> GetUserMe()
        {
            var user = await GetUser();

            var response = new UserResponse
            {
                Code = "success",
                Message = "success.user.me",
                Data = user
            };

            return Ok(response);
        }

        [HttpGet(ApiRoutes.User.UserEvents)]
        public async Task<IActionResult> GetUserEvents()
        {
            var user = await GetUser();

            if (user == null)
            {
                return NotFound();
            }

            var model = await _userService.GetUserEventsAsync(user);

            var response = new UserResponse
            {
                Code = "success",
                Message = "user.events.success",
                Data = model
            };
            return Ok(response);
        }

        [HttpGet(ApiRoutes.User.UserGroups)]
        public async Task<IActionResult> GetUserGroups()
        {
            var user = await GetUser();

            if (user == null)
            {
                return NotFound();
            }
            
            var model = await _userService.GetUserGroupAsync(user);

            var response = new UserResponse
            {
                Code = "success",
                Message = "user.groups.success",
                Data = model
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