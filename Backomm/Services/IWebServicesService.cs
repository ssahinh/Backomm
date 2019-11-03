using System.Collections.Generic;
using System.Threading.Tasks;
using Backomm.Models;

namespace Backomm.Services
{
    public interface IWebServicesService
    {
        Task<List<Api>> GetAllServicesAsync();
        Task<Api> GetServiceByIdAsync(int ServiceId);
        Task<bool> CreateServiceAsync(Api api, ApplicationUser applicationUser);
    }
}