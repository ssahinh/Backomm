using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backomm.Data;
using Backomm.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace Backomm.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly DataContext _dataContext;

        public UserService(UserManager<ApplicationUser> userManager, DataContext dataContext)
        {
            _userManager = userManager;
            _dataContext = dataContext;
        }

        public async Task<ApplicationUser> GetUserEventsAsync(ApplicationUser user)
        {
            return await _dataContext.Users
                .Where(x => x.Id == user.Id)
                .Include(x => x.Event)
                .ThenInclude(x => x.Users)
                .FirstAsync();
        }

        public async Task<ApplicationUser> GetUserGroupAsync(ApplicationUser user)
        {
            return await _dataContext.Users
                .Where(x => x.Id == user.Id)
                .Include(x => x.Group)
                .ThenInclude(x => x.Category)
                .FirstAsync();
        }
    }
}