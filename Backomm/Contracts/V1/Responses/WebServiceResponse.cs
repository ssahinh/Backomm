using System.Collections.Generic;
using Backomm.Models;

namespace Backomm.Contracts.V1.Responses
{
    public class WebServiceResponse : BaseResponse<Api>
    {
    }

    public class WebServiceGetResponse : BaseResponse<List<Api>>
    {
    }
}