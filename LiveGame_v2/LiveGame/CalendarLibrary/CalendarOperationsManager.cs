using Autofac;
using CalendarLibrary.Interfaces;
using CalendarLibrary.Interfaces.Operations;
using CalendarLibrary.Models;
using Google.Apis.Calendar.v3.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalendarLibrary
{
    public class CalendarOperationsManager : ICalendarOperationsManager
    {
        IAddEventToCalendarOperation _add;
        public CalendarOperationsManager()
        {
            IContainer autofacConfig = AutofacConfig.Configure();

            using (var scope = autofacConfig.BeginLifetimeScope())
            {
                _add = scope.Resolve<IAddEventToCalendarOperation>();
            }
        }

        public void AddEventToCalendar(CalendarEvent _event)
        {
            _add.AddEventToCalendar(_event);
        }
    }
}
