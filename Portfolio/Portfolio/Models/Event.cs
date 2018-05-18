using System;

namespace Portfolio.Models
{
    public class Event
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public string EventType { get; set; }
        public DateTime EventDate { get; set; }
    }
}