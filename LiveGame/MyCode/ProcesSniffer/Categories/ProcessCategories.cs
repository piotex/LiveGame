using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveGame.MyCode.ProcesSniffer.Categories
{
    public class ProcessCategories
    {
        public string GetCategory(string process)
        {
            string retVal = "-";

            if (process.Contains("Mozilla Firefox"))
            {
                return new ProcCat_MozillaFirefox().GetCategory(process);
            }

            if (process.Contains("Microsoft Visual Studio"))
            {
                return "Microsoft Visual Studio";
            }
            if (process.Contains("Microsoft Docs"))
            {
                return "Microsoft Docs";
            }
            if (process.Contains("OneNote for Windows 10"))
            {
                return "OneNote";
            }
            if (process.Contains("| Microsoft Teams"))
            {
                return "Microsoft Teams";
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
