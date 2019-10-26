using System.Collections.Generic;
using System.Threading.Tasks;
using Backomm.Contracts.V1.Requests;
using Backomm.Data;
using Backomm.Models;
using Microsoft.EntityFrameworkCore;

namespace Backomm.Services
{
    public class EventService : IEventService
    {
        private readonly DataContext _dataContext;

        public EventService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<Event>> GetAllEventsAsync()
        {
            return await _dataContext.Events.ToListAsync();
        }

        public async Task<Event> GetEventByIdAsync(int EventId)
        {
            return await _dataContext.Events
                .Include(_event => _event.Users)
                .SingleOrDefaultAsync(x => x.Id == EventId);
        }

        public async Task<bool> JoinEventAsync(int EventId, ApplicationUser user)
        {
            var eventModel = await GetEventByIdAsync(EventId);

            if (eventModel == null)
            {
                return false;
            }
            
            eventModel.Users.Add(user);
            await _dataContext.SaveChangesAsync();

            return true;
        }
    }
}