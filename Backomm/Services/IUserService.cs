using System.Collections.Generic;
using System.Threading.Tasks;
using Backomm.Models;
using Microsoft.EntityFrameworkCore.Query;

namespace Backomm.Services
{
    public interface IUserService
    { 
        Task<ApplicationUser> GetUserEventsAsync(ApplicationUser user);
        Task<ApplicationUser> GetUserGroupAsync(ApplicationUser user);
        Task<bool> UpdateUserAsync(ApplicationUser user);
    }
}