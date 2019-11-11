using Backomm.Models;

namespace Backomm.Contracts.V1.Responses
{
    public class UserResponse : BaseResponse<ApplicationUser>
    {
        
    }

    public class UserNullResponse
    {
        public string Code { get; set; }
        public string Message { get; set; }
    }
}