using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveGame.MyCode.ProcesSniffer.Categories
{
    public class ProcessCategoriesColor
    {
        public string GetProcessColorId(string title)
        {
            string Basil = "10";
            string Tomato = "11";
            string Blueberry = "9";
            string Graphite = "8";
            string Peacock = "7";
            string Tangerine = "6";
            string Banana = "5";
            string Flamingo = "4";
            string Grape = "3";
            string Sage = "2";
            string Lavender = "1";


            if (title.Contains("YouTube"))
            {
                return Basil;
            }
            if (title.Contains("Messenger"))
            {
                return Basil;
            }
            if (title.Contains("Netflix"))
            {
                return Basil;
            }
            return Graphite;
        }
    }
}
