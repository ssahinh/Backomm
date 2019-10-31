using System.Collections.Generic;
using System.Threading.Tasks;
using Backomm.Models;

namespace Backomm.Services
{
    public interface ICityService
    {
        Task<List<City>> GetAllCitiesAsync();
        Task<City> GetCityByIdAsync(int CityId);
    }
}