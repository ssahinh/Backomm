using System.Collections.Generic;
using System.Threading.Tasks;
using Backomm.Contracts.V1.Responses;
using Backomm.Models;

namespace Backomm.Services
{
    public interface IGroupService
    {
        Task<List<Group>> GetGroupsAsync();

        Task<Group> GetGroupByIdAsync(int GroupId);

        Task<bool> JoinGroup(ApplicationUser user, int GroupId);
    }
}