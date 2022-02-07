using Google.Apis.Calendar.v3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveGame.MyCode.Calendar.Models
{
    public class CalendarEvent
    {
        private string location = "Wrocław, Polska";
        private string timeZone = "Europe/Zurich";
        private string colourId = "8";
        private string description = "[Auto_Added]";

        public string Title = "";
        public string Location = "";
        public string Description = "";
        public string ColourID = "";

        public DateTime StartTime;
        public DateTime EndTime;

        public CalendarEvent(string _title, string _location, string _description, DateTime _startTime, DateTime _endTime)
        {
            Title = _title;
            Location = _location;
            Description = _description;
            ColourID = colourId;

            StartTime = _startTime;
            EndTime = _endTime;


        }
        public CalendarEvent(string _title, string _description, DateTime _startTime, DateTime _endTime)
        {
            Title = _title;
            Location = location;
            Description = _description;
            ColourID = colourId;

            StartTime = _startTime;
            EndTime = _endTime;
        }
        public CalendarEvent(string _title, DateTime _startTime, DateTime _endTime)
        {
            Title = _title;
            Location = location;
            Description = description;
            ColourID = colourId;

            StartTime = _startTime;
            EndTime = _endTime;
        }
        public CalendarEvent(string _title)
        {
            Title = _title;
            Location = location;
            Description = description;
            ColourID = colourId;

            StartTime = DateTime.Now;
            EndTime = DateTime.Now;
        }

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
    }
}
