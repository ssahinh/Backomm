using System.Linq;
using System.Threading.Tasks;
using Backomm.Contracts.V1;
using Backomm.Contracts.V1.Requests;
using Backomm.Contracts.V1.Responses;
using Backomm.Services;
using Microsoft.AspNetCore.Mvc;

namespace Backomm.Controllers.V1
{
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost(ApiRoutes.Auth.Register)]
        public async Task<IActionResult> Register([FromBody] UserRegistrationRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new AuthFailedResponse
                {
                    //Errors = ModelState.Values.SelectMany(x => x.Errors.Select(xx => xx.ErrorMessage))
                });
            }

            var authResponse = await _authService.RegisterAsync(request.Email, request.Password);

            if (!authResponse.Success)
            {
                return BadRequest(new AuthFailedResponse
                {
                    //Errors = authResponse.Errors
                });
            }

            return Ok(new AuthSuccessResponse
            {
                Code = "success",
                Message = "auth.success",
                Token = authResponse.Token
            });
        }

        [HttpPost(ApiRoutes.Auth.Login)]
        public async Task<IActionResult> Login([FromBody] UserLoginRequest request)
        {
            var authResponse = await _authService.LoginAsync(request.Email, request.Password);
            
            if (!authResponse.Success)
            {
                return BadRequest(new AuthFailedResponse
                {
                    Code = "error",
                    Message = "auth.login.error",
                    Error = authResponse.Error
                });
            }

            return Ok(new AuthSuccessResponse
            {
                Token = authResponse.Token
            });
        }
    }
}