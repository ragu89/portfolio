using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Portfolio.Services
{
    public interface IDataStore
    {
        Task<Event> GetEventAsync(string id);
        Task<IEnumerable<Event>> GetEventsAsync(bool forceRefresh = false);
    }
}
