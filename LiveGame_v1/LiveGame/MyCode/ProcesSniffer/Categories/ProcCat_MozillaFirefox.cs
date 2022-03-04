using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveGame.MyCode.ProcesSniffer.Categories
{
    public class ProcCat_MozillaFirefox
    {
        public string GetCategory(string process)
        {
            string retVal = "-";

            if (process.Contains("YouTube"))
            {
                return "YouTube";
            }
            if (process.Contains("Kalendarz Google "))
            {
                return "Kalendarz Google";
            }
            if (process.Contains("Messenger | Facebook"))
            {
                return "Messenger";
            }
            if (process.Contains("Netflix — Mozilla Firefox"))
            {
                return "Netflix";
            }
            if (process.Contains("WhatsApp — "))
            {
                return "WhatsApp";
            }
            if (process.Contains("Szukaj w Google — Mozilla Firefox"))
            {
                return "Google";
            }
            /*
            if (process.Contains(""))
            {
                return "";
            }
            */
            return process;
        }
    }
}
