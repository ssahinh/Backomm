using System.Security.Claims;
using System.Threading.Tasks;
using Backomm.Contracts.V1;
using Backomm.Contracts.V1.Requests;
using Backomm.Contracts.V1.Responses;
using Backomm.Models;
using Backomm.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Backomm.Controllers.V1
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class GroupController : Controller
    {
        private readonly IGroupService _groupService;
        private readonly UserManager<ApplicationUser> _userManager;
        
        public GroupController(IGroupService groupService, UserManager<ApplicationUser> userManager)
        {
            _groupService = groupService;
            _userManager = userManager;
        }

        [HttpGet(ApiRoutes.Group.Get)]
        public async Task<IActionResult> GetAllGroups()
        {
            
            return Ok(await _groupService.GetGroupsAsync());
        }

        // Must use same name FromRoute int GroupId and Route GroupId
        [HttpGet(ApiRoutes.Group.GetById)]    
        public async Task<IActionResult> GetGroupById([FromRoute] int GroupId)
        {
            var model = await _groupService.GetGroupByIdAsync(GroupId);

            if (model == null)
            {    
                return NotFound();
            }

            var response = new GroupResponse
            {
                Code = "success",
                Message = "group.get.success",
                Data = model
            };

            return Ok(response);
        }

        [HttpPost(ApiRoutes.Group.JoinGroup)]
        public async Task<IActionResult> JoinGroup([FromBody] UserJoinGroupRequest request)
        {
            var user = await GetUser();

            if (!ModelState.IsValid)
            {
                return BadRequest(    new
                {
                    Code = "error",
                    Message = "group.join.error",
                    Error = "Can't joined group"
                });
            }    
            
            if (user == null)
            {
                return BadRequest(new
                {
                    Code = "error",
                    Message = "auth.user.not-found",
                    Error = "User Not Found"
                });
            }
            
            var model = await _groupService.JoinGroup(user, request.GroupId);
            
            var response = new GroupResponse
            {
                Code = "success",
                Message = "group.join.success",
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