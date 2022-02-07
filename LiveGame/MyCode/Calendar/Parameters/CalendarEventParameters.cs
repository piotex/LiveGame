using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveGame.MyCode.Calendar.Parameters
{
    public class CalendarEventParameters
    {
        public Dictionary<string, string> Parameters = new Dictionary<string, string>();

        public CalendarEventParameters()
        {
            Parameters.Add("Zrobione","[Done]");
            Parameters.Add("Odpoczynek", "[Rest]");
        }
    }
}
