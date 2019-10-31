using System.Collections.Generic;
using Backomm.Models;

namespace Backomm.Contracts.V1.Responses
{
    public class EventResponse : BaseResponse<List<Event>> { }
    public class EventGetByIdResponse : BaseResponse<Event> { }
}