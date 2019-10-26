using Backomm.Models;

namespace Backomm.Contracts.V1.Responses
{
    public class AuthSuccessResponse : BaseResponse<ApplicationUser>
    {
        public string Token { get; set; }
    }
}