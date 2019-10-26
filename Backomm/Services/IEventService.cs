using System.Collections.Generic;
using System.Threading.Tasks;
using Backomm.Models;

namespace Backomm.Services
{
    public interface IEventService
    {
        Task<List<Event>> GetAllEventsAsync();

        Task<Event> GetEventByIdAsync(int EventId);

        Task<bool> JoinEventAsync(int EventId, ApplicationUser user);

        Task<bool> CreateEventAsync(Event Event);
    }
}