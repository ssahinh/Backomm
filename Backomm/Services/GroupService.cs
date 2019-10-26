using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Backomm.Contracts.V1.Responses;
using Backomm.Data;
using Backomm.Models;
using Microsoft.EntityFrameworkCore;

namespace Backomm.Services
{
    public class GroupService : IGroupService
    {
        private readonly DataContext _context;

        public GroupService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Group>> GetGroupsAsync()
        {
            return await _context.Groups.ToListAsync();
        }

        public async Task<Group> GetGroupByIdAsync(int GroupId)
        {
            return await _context.Groups.
                Include(group => group.Users).
                SingleOrDefaultAsync(x => x.Id == GroupId);
        }

        public async Task<bool> JoinGroup(ApplicationUser user, int GroupId)
        {
            var group = await GetGroupByIdAsync(GroupId);

            if (group == null)
            {
                return false;
            }
            
            group.Users.Add(user);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}