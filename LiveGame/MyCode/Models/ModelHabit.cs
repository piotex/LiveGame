using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveGame.MyCode.Models
{
    public class ModelHabit
    {
        public DateTime StartTime;
        public string Frequency;
        public string Message;


        public ModelHabit(string msg, string frequency, DateTime time)
        {
            Message = msg;
            Frequency = frequency;
            StartTime = time;
        }
    }
}
