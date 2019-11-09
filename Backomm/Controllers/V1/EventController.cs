using System;
using System.Reflection.Metadata.Ecma335;
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
    public class EventController : Controller
    {
        private readonly IEventService _eventService;
        private readonly UserManager<ApplicationUser> _userManager;

        public EventController(IEventService eventService, UserManager<ApplicationUser> userManager)
        {
            _eventService = eventService;
            _userManager = userManager;
        }

        [HttpGet(ApiRoutes.Event.Get)]
        public async Task<IActionResult> GetEvents()
        {
            var model = await _eventService.GetAllEventsAsync();

            var response = new EventResponse
            {
                Code = "success",
                Message = "get.events.success",
                Data = model
            };

            return Ok(response);
        }

        [HttpPost(ApiRoutes.Event.CreateEvent)]
        public async Task<IActionResult> CreatEvent(CreateEventRequest  request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new
                {
                    Code = "error",
                    Message = "error.create.event",
                    Error = "empty name"
                });
            }
            
            var Event = new Event
            {
                About = request.About,
                //AddedDate = DateTime.Now
            };

            await _eventService.CreateEventAsync(Event);

            var response = new EventResponse
            {
                Code = "success",
                Message = "create.event.success"
            };

            return Ok(response);
        }

        [HttpGet(ApiRoutes.Event.GetById)]
        public async Task<IActionResult> GetEventById([FromRoute] EventRequest request)
        {
            var model = await _eventService.GetEventByIdAsync(request.EventId);

            if (model == null)
            {
                return NotFound();
            }

            var response = new EventGetByIdResponse
            {
                Code = "success",
                Message = "event.get.success",
                Data = model
            };

            return Ok(response);
        }

        [HttpPost(ApiRoutes.Event.JoinEvent)]
        public async Task<IActionResult> JoinEvent([FromBody] JoinEventRequest request)
        {
            var user = await GetUser();

            if (user == null)
            {
                return BadRequest(new
                {
                    Code = "error",
                    Message = "auth.user.not-found",
                    Error = "User Not Found"
                });
            }
            
            if (!ModelState.IsValid)
            {    
                return BadRequest(new
                {
                    Code = "error",
                    Message = "error.create.event",
                    Error = "Empty EventId"
                });
            }
            var model = await _eventService.JoinEventAsync(request.EventId, user);

            var response = new EventGetByIdResponse
            {
                Code = "success",
                Message = "event.join.success",
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