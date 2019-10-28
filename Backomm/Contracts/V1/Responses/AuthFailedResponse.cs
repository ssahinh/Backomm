using System.Collections.Generic;

namespace Backomm.Contracts.V1.Responses
{
    public class AuthFailedResponse
    {
        //public IEnumerable<string> Errors { get; set; }
        public string Code { get; set; }
        
        public string Message { get; set; }
        public string Error { get; set; }
    }
}