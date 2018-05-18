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
                new Event { Id = Guid.NewGuid().ToString(), Text = "First item", Description="This is an item description." },
                new Event { Id = Guid.NewGuid().ToString(), Text = "Second item", Description="This is an item description." },
                new Event { Id = Guid.NewGuid().ToString(), Text = "Third item", Description="This is an item description." },
                new Event { Id = Guid.NewGuid().ToString(), Text = "Fourth item", Description="This is an item description." },
                new Event { Id = Guid.NewGuid().ToString(), Text = "Fifth item", Description="This is an item description." },
                new Event { Id = Guid.NewGuid().ToString(), Text = "Sixth item", Description="This is an item description." },
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