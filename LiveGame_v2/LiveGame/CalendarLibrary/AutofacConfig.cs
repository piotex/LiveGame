using Autofac;
using CalendarLibrary.Code;
using CalendarLibrary.Code.Operations;
using CalendarLibrary.Interfaces;
using CalendarLibrary.Interfaces.Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalendarLibrary
{
    public class AutofacConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<CalendarOperationsManager>().As<ICalendarOperationsManager>();

            builder.RegisterType<AddEventToCalendarOperation>().As<IAddEventToCalendarOperation>();
            builder.RegisterType<CalendarClient>().As<ICalendarClient>();
            builder.RegisterType<CalendarClientSecrets>().As<ICalendarClientSecrets>();
            builder.RegisterType<CalendarKey>().As<ICalendarKey>();


            return builder.Build();
        }
    }
}
