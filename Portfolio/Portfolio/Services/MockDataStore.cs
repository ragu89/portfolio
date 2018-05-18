using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Portfolio.Models;

[assembly: Xamarin.Forms.Dependency(typeof(Portfolio.Services.MockDataStore))]
namespace Portfolio.Services
{
    public class MockDataStore : IDataStore
    {
        List<Event> items;

        public MockDataStore()
        {
            items = new List<Event>();
            var mockItems = new List<Event>
            {
                new Event { Id = Guid.NewGuid().ToString(), Title = "Event 1", Location="Location 1", EventType = "Type 1", EventDate = new DateTime(2018,1,1) },
                new Event { Id = Guid.NewGuid().ToString(), Title = "Event 2", Location="Location 2", EventType = "Type 2", EventDate = new DateTime(2018,2,2) },
                new Event { Id = Guid.NewGuid().ToString(), Title = "Event 3", Location="Location 3", EventType = "Type 1", EventDate = new DateTime(2018,3,3) },
                new Event { Id = Guid.NewGuid().ToString(), Title = "Event 4", Location="Location 4", EventType = "Type 2", EventDate = new DateTime(2018,4,4) },
                new Event { Id = Guid.NewGuid().ToString(), Title = "Event 5", Location="Location 5", EventType = "Type 1", EventDate = new DateTime(2018,5,5) },
                new Event { Id = Guid.NewGuid().ToString(), Title = "Event 6", Location="Location 6", EventType = "Type 2", EventDate = new DateTime(2018,6,6) },
            };

            foreach (var item in mockItems)
            {
                items.Add(item);
            }
        }

        public async Task<Event> GetEventAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Event>> GetEventsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}