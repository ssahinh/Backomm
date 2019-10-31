using System.Collections.Generic;
using Backomm.Models;

namespace Backomm.Contracts.V1.Responses
{
    public class CityResponse : BaseResponse<List<City>> {}
    public class CityGetByIdResponse : BaseResponse<City> {}
}