using Google.Apis.Calendar.v3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveGame.MyCode.Calendar.Models
{
    public class CalendarEvent : Event
    {
        private string location = "Wrocław, Polska";
        private string timeZone = "Europe/Zurich";
        private string colorId = "8";
        private string description = "[Auto_Added]";


        public CalendarEvent(string _title, DateTime _startTime, DateTime _endTime, string _colorId) 
        {
            Summary = _title;
            Location = location;
            Description = description;
            ColorId = _colorId;

            Start = new EventDateTime()
            {
                DateTime = _startTime,
                TimeZone = timeZone,
            };
            End = new EventDateTime()
            {
                DateTime = _endTime,
                TimeZone = timeZone,
            };
        }


        /*
public Event ConvertToGoogleCalendarEvent() 
{
   Event myEvent = new Event();
   myEvent.Summary = Title;
   myEvent.Location = Location;
   myEvent.Description = Description;
   myEvent.ColorId = ColourID;

   myEvent.Start = new EventDateTime()
   {
       DateTime = StartTime,
       TimeZone = timeZone,
   };
   myEvent.End = new EventDateTime()
   {
       DateTime = EndTime,
       TimeZone = timeZone,
   };
   return myEvent;
}
*/
    }
}
