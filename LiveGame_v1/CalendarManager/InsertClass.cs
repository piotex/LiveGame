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
    public class InsertClass
    {

        static string[] Scopes = { CalendarService.Scope.CalendarReadonly };
        static string ApplicationName = "Klient na komputerze 1";
        public void GetEvents()
        {
            UserCredential credential;
            string file = @"client_secret.json";
            string path = @"C:\Users\pkubo\OneDrive\Dokumenty\GitHub\_Klucze\KalendarzGoogle\" + file;



            using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                string credPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                credPath = Path.Combine(credPath, ".credentials/calendar-dotnet-quickstart.json");

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    new string[] { CalendarService.Scope.Calendar },
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }


            /*

            using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            */

            // Create Google Calendar API service.
            var service = new CalendarService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            /*

            // Define parameters of request.
            EventsResource.ListRequest request = service.Events.List("primary");
            request.TimeMin = DateTime.Now;
            request.ShowDeleted = false;
            request.SingleEvents = true;
            request.MaxResults = 10;
            request.OrderBy = EventsResource.ListRequest.OrderByEnum.StartTime;

            // List events.
            Events events = request.Execute();
            Console.WriteLine("Upcoming events:");
            if (events.Items != null && events.Items.Count > 0)
            {
                foreach (var eventItem in events.Items)
                {
                    string when = eventItem.Start.DateTime.ToString();
                    if (String.IsNullOrEmpty(when))
                    {
                        when = eventItem.Start.Date;
                    }
                    Console.WriteLine("{0} ({1})", eventItem.Summary, when);
                }
            }
            else
            {
                Console.WriteLine("No upcoming events found.");
            }

            */

            /*
            DateTime start = DateTime.Now;
            DateTime end = start + TimeSpan.FromMinutes(30);

            var curTZone = TimeZone.CurrentTimeZone;
            var dateStart = new DateTimeOffset(start, curTimeZone.GetUtcOffset(start));
            var dateEnd = new DateTimeOffset(end, curTimeZone.GetUtcOffset(end));
            var startTimeString = dateStart.ToString("o");
            var endTimeString = dateEnd.ToString("o");

            evnt.Start = new EventDateTime()
            {
                DateTime = startTimeString
            };

            evnt.End = new EventDateTime()
            {
                DateTime = endTimeString
            };

            */


            Event newEvent = new Event()
            {
                Summary = "Google I/O 2015",
                Location = "800 Howard St., San Francisco, CA 94103",
                Description = "A chance to hear more about Google's developer products.",
                Start = new EventDateTime()
                {
                    Date = DateTime.Now.ToString("yyyy-MM-dd"),
                    DateTime = DateTime.Now,    //DateTime.Parse("2015-05-28T09:00:00-07:00"),
                    TimeZone = "Europe/Oslo",
                },
                End = new EventDateTime()
                {
                    Date = DateTime.Now.ToString("yyyy-MM-dd"),
                    DateTime = DateTime.Today.AddHours(1),    //DateTime.Parse("2015-05-28T09:00:00-07:00"),
                    TimeZone = "Europe/Oslo",
                },
                //Recurrence = new String[] { "RRULE:FREQ=DAILY;COUNT=2" },

                /*
                Attendees = new EventAttendee[] {
//                    new EventAttendee() { Email = "lpage@example.com" },
//                    new EventAttendee() { Email = "sbrin@example.com" },
                },
                Reminders = new Event.RemindersData()
                {
                    UseDefault = false,
                    Overrides = new EventReminder[] {
//                        new EventReminder() { Method = "email", Minutes = 24 * 60 },
//                        new EventReminder() { Method = "sms", Minutes = 10 },
                    }
                }
                */
            };


            String calendarId = "primary";
            EventsResource.InsertRequest request22 = service.Events.Insert(newEvent, calendarId);
            Event createdEvent = request22.Execute();
            Console.WriteLine("Event created: {0}", createdEvent.HtmlLink);

            Console.Read();
        }

    }
}
