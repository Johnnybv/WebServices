using System;
using System.Linq;
using System.Collections.Generic;

namespace ModasSeedData
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // first create Locations list
            List<Location> Locations = new List<Location>()
            {
                //new Location { LocationId = 1, Name = "Front Door"},
                // TODO: Add locations
                new Location { LocationId = 0, Name = "Front Door"},
                new Location { LocationId = 1, Name = "Back Door"},
                new Location { LocationId = 2, Name = "Side Door"},
                new Location { LocationId = 3, Name = "Garage Door"}
       
            };
            // create date object containing current date/time
            DateTime localDate = DateTime.Now;
            // TODO: subtract 6 months from date
            DateTime eventDate = localDate.AddMonths(-6);
            // eventDate = ???
            // TODO: instantiate Random class
            // Random rnd = ???
            Random rnd = new Random();
            // TODO: create list to store events (Events)
            List<Event> Events = new List<Event>();
            while (eventDate < localDate)
            {
                int eventsNum = rnd.Next(0, 5);
                
                List<Event> DailyEvents = new List<Event>();
                for(int i = 0; i < eventsNum; i++)
                {
                    int hour = rnd.Next(0, 24);
                    int min = rnd.Next(0, 56);
                    int sec = rnd.Next(0, 56);
                    int LId = rnd.Next(0, 4);

                    DateTime AddedTime = eventDate.Date + new TimeSpan(hour, min, sec);

                    DailyEvents.Add(new Event{ TimeStamp = AddedTime, Flagged = false, Location = Locations.FirstOrDefault(l => l.LocationId == LId) });
                }

                Events.Sort((x, y) => DateTime.Compare(x.TimeStamp, y.TimeStamp));
                foreach(Event e in DailyEvents)
                {
                    Events.Add(new Event { TimeStamp = e.TimeStamp, Flagged = e.Flagged, Location = e.Location });
                }

                eventDate = eventDate.AddDays(1);
            }

            foreach(Event e in Events)
            {
                Console.WriteLine(e.TimeStamp + " - " + e.Location.Name);
            }

            
            

            // loop for each day in the range from 6 months ago to today
            //while (eventDate < localDate)
            //{
            // TODO: random between 0 and 5 determines the number of events to occur on a given day
            // TODO: a sorted list will be used to store daily events sorted by date/time - each time an event is added, the list is re-sorted
            // TODO: for loop to generate times for each event
            // TODO: random between 0 and 23 for hour of the day
            // TODO: random between 0 and 59 for minute of the day
            // TODO: random between 0 and 59 for seconds of the day
            // TODO: random location (use Locations)
            // TODO: create date/time for event
            // TODO: create event from date/time and location
            // TODO: add daily event to sorted list
            // TODO: loop thru sorted list for daily events
            // add daily event to Events
            // TODO: add 1 day to eventDate
            //}
            // TODO: loop thru Events
            // TODO: display event at console
        }
    }

    public class Location
    {
        public int LocationId { get; set; }
        public string Name { get; set; }
    }

    public class Event
    {
        public int EventId { get; set; }
        public DateTime TimeStamp { get; set; }
        public bool Flagged { get; set; }
        // foreign key for location 
        public int LocationId { get; set; }
        // navigation property
        public Location Location { get; set; }
    }
}