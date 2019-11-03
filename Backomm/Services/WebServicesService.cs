using System.Collections.Generic;
using System.Threading.Tasks;
using Backomm.Data;
using Backomm.Models;
using Microsoft.EntityFrameworkCore;

namespace Backomm.Services
{
    public class WebServicesService : IWebServicesService
    {
        private readonly DataContext _dataContext;

        public WebServicesService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<Api>> GetAllServicesAsync()
        {
            return await _dataContext.WebServices
                .Include(services => services.ApplicationUser)
                .ToListAsync();
        }

        public async Task<Api> GetServiceByIdAsync(int ServiceId)
        {
            return await _dataContext.WebServices.SingleOrDefaultAsync(x => x.Id == ServiceId);
        }

        public async Task<bool> CreateServiceAsync(Api api, ApplicationUser applicationUser)
        {
            await _dataContext.WebServices.AddAsync(api);
            api.ApplicationUser = applicationUser;

            var created = await _dataContext.SaveChangesAsync();

            return created > 0;
        }

    }
}