using System;

// Think of these as models or formal name is entity
namespace Domain
{
    public class Activity
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string description { get; set; }
        public string City { get; set; }
        public string Venue { get; set; }
    }
}

