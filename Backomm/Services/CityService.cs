using System.Collections.Generic;
using System.Threading.Tasks;
using Backomm.Data;
using Backomm.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backomm.Services
{
    public class CityService : ICityService
    {
        private readonly DataContext _dataContext;

        public CityService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }


        public async Task<List<City>> GetAllCitiesAsync()
        {
            return await _dataContext.Cities.ToListAsync();
        }

        public async Task<City> GetCityByIdAsync(int CityId)
        {
            return await _dataContext.Cities
                .Include(city => city.Counties)
                .SingleOrDefaultAsync(x => x.Id == CityId);
        }
    }
}