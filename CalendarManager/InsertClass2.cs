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

namespace CalendarManager
{
    public class InsertClass2
    {


        static string[] Scopes = { CalendarService.Scope.CalendarReadonly };
        static string ApplicationName = "Klient na komputerze 1";
        //UserCredential credential;
        //string file = @"client_secret.json";
        //string path = @"C:\Users\pkubo\OneDrive\Dokumenty\GitHub\_Klucze\KalendarzGoogle\" + file;


        public void Insert()
        {
            var credential = GoogleWebAuthorizationBroker.AuthorizeAsync(

            new ClientSecrets
            {
                ClientId = "",          // add this from file!
                ClientSecret = "",          // add this from file!
            },
            new[] { CalendarService.Scope.Calendar },
                "user",
                CancellationToken.None).Result;


            // Create the service.
            var service = new CalendarService(new BaseClientService.Initializer
            {
                HttpClientInitializer = credential,
                ApplicationName = "Calendar API Sample",
            });
            DateTime start = DateTime.Now;
            DateTime end = start + TimeSpan.FromMinutes(30);

            DateTime initiate = DateTime.Now;
            DateTime ending = start + TimeSpan.FromMinutes(30);
            start = DateTime.SpecifyKind(start, DateTimeKind.Local);
            end = DateTime.SpecifyKind(end, DateTimeKind.Local);
            var myEvent = new Event
            {
                Summary = "Google I/O 2015",
                Location = "800 Howard St., San Francisco, CA 94103",
                Description = "A chance to hear more about Google's developer products.",
                Start = new EventDateTime()
                {
                    DateTime = DateTime.Parse("2022-02-12T09:00:00-07:00"),
                    TimeZone = "America/Los_Angeles",
                },
                End = new EventDateTime()
                {
                    DateTime = DateTime.Parse("2022-02-12T17:00:00-07:00"),
                    TimeZone = "America/Los_Angeles",
                },
                Recurrence = new String[] { "RRULE:FREQ=WEEKLY;BYDAY=MO" },
                Attendees = new List<EventAttendee>
            {
            new EventAttendee { Email = "wgcu418@gmail.com"}
            },
            };

            var recurringEvent = service.Events.Insert(myEvent, "primary");
            recurringEvent.SendNotifications = true;
            recurringEvent.Execute();
        }
    }
}
