using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backomm.Contracts.V1.Responses;
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

        public Task<bool> UpdateUserAsync(ApplicationUser user)
        {
            throw new System.NotImplementedException();
        }

        /*
        public async Task<bool> UpdateUserAsync(string email, string userName)
        {
            var existingUser = await _userManager.FindByEmailAsync(email);

            if (existingUser == null)
            {
                return false;
            }

            _userManager.ChangePasswordAsync(existingUser.Email);
        }
        */
    }
}