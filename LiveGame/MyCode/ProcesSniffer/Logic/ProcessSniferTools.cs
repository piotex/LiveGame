using LiveGame.MyCode.Calendar.Models;
using LiveGame.MyCode.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveGame.MyCode
{
    public class ProcessSniferTools
    {
        public void UpdateListOfCurrentProcesses(ref List<Models.ModelCurrentProcesses> listOfProcesses, string process)
        {
            for (int i = 0; i < listOfProcesses.Count; i++)
            {
                if (listOfProcesses[i].ProcesName == process)
                {
                    listOfProcesses[i].NumberOf1sRunningProces ++;
                    return;
                }
            }
            var tmp = new Models.ModelCurrentProcesses()
            {
                NumberOf1sRunningProces = 1,
                ProcesName = process
            };
            listOfProcesses.Add(tmp);
        }


        public void AddToFile(string process_to_add)
        {
            string path = @"C:\Users\pkubo\OneDrive\Dokumenty\GitHub\_Files\LiveGame\" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt";
            List<string> processes = new List<string>();

            if (!File.Exists(path))
            {
                using (var aaa = File.Create(path))
                {
                    aaa.Close();
                }
            }

            using (StreamReader sr = new StreamReader(path))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    processes.Add(line);
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            using (StreamWriter sr = File.AppendText(path))
            {
                bool isInFile = false;
                foreach (string process in processes)
                {
                    if (process == process_to_add)
                    {
                        isInFile = true;
                        break;
                    }
                }
                if (!isInFile)
                {
                    sr.WriteLine(process_to_add);
                }
                sr.Close();
            }
        }
        public List<CalendarEvent> GetListOfLongestProcesses(ref List<ModelCurrentProcesses> listOfProcesses)
        {
            List<CalendarEvent> tmp = new List<CalendarEvent>();
            UpdateListOdProcesses(ref listOfProcesses);

            DateTime lastEventStart = DateTime.Now;
            for (int i = 0; i < listOfProcesses.Count; i++)
            {
                string title = listOfProcesses[i].ProcesName;
                int seconds = listOfProcesses[i].NumberOf1sRunningProces ;
                DateTime end = lastEventStart;
                DateTime start = lastEventStart.AddSeconds(-seconds);

                lastEventStart = start;
                CalendarEvent model = new CalendarEvent(title, start, end);

                tmp.Add(model);
            }

            if (listOfProcesses.Count > 0)
                listOfProcesses.Clear();

            return tmp;
        }


        //return the 3 largest processes
        public void UpdateListOdProcesses(ref List<ModelCurrentProcesses> listOfProcesses)
        {
            int time_5min_in_1s = 5 * 60;

            if (listOfProcesses.Count == 1)
                return;

            listOfProcesses.Sort((p, q) => q.NumberOf1sRunningProces.CompareTo(p.NumberOf1sRunningProces));

            for (int i = 0; i < listOfProcesses.Count; i++)
            {
                if (listOfProcesses[i].NumberOf1sRunningProces < time_5min_in_1s)
                {
                    listOfProcesses.RemoveAt(i);
                    i--;
                }
            }

            if (listOfProcesses.Count > 3)
            {
                listOfProcesses.RemoveRange(3, listOfProcesses.Count - 3);
            }
        }


        public void UpdateTextBox(TextBox textBox, string name)
        {
            lock (textBox.Text)
            {
                AddToFile(name);
                textBox.Invoke(new Action(() => textBox.Text = name));
            }
        }

    }
}

