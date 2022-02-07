using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace LiveGame.MyCode.Calendar.Logic
{
    public class AddEvent : CalendarClient
    {
        public void InsertEventToCalendar(Event eventToInsert)
        {
            var recurringEvent = service.Events.Insert(eventToInsert, "primary");
            recurringEvent.SendNotifications = true;
            recurringEvent.Execute();
        }

        public Event GetTestEvent()
        {
            DateTime start = DateTime.Now;
            DateTime end = start + TimeSpan.FromMinutes(30);

            DateTime initiate = DateTime.Now;
            DateTime ending = start + TimeSpan.FromMinutes(30);
            start = DateTime.SpecifyKind(start, DateTimeKind.Local);
            end = DateTime.SpecifyKind(end, DateTimeKind.Local);

            Event myEvent = new Event();
            myEvent.Summary = "Google I/O 2015";
            myEvent.Location = "800 Howard St., San Francisco, CA 94103";
            myEvent.Description = "A chance to hear more about Google's developer products.";
            myEvent.Start = new EventDateTime()
            {
                DateTime = DateTime.Now,
                //DateTime = DateTime.Parse("2022-01-30T09:00:00-07:00"),
                TimeZone = "Europe/Zurich",
            };
            myEvent.End = new EventDateTime()
            {
                DateTime = DateTime.Now.AddHours(2),
                //DateTime = DateTime.Parse("2022-01-31T17:00:00-07:00"),
                TimeZone = "Europe/Zurich",
            };
            //myEvent.Recurrence = new String[] { "RRULE:FREQ=WEEKLY;BYDAY=MO" };
            //myEvent.Attendees = new List<EventAttendee> { new EventAttendee { Email = "wgcu418@gmail.com"} };
            return myEvent;
        }
    }
}
