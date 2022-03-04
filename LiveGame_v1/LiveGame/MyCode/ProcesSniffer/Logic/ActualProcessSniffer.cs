using LiveGame.MyCode.Calendar.Logic;
using LiveGame.MyCode.Calendar.Models;
using LiveGame.MyCode.Models;
using LiveGame.MyCode.ProcesSniffer.Categories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveGame.MyCode
{
    public class ActualProcessSniffer : ProcessSniferTools
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, System.Text.StringBuilder text, int count);

        protected string GetActualProcessName()
        {
            const int nChars = 256;
            IntPtr handle;
            StringBuilder Buff = new StringBuilder(nChars);
            handle = GetForegroundWindow();
            if (GetWindowText(handle, Buff, nChars) > 0)
            {
                return Buff.ToString();
            }
            return "-";
        }

        public void StartSniffing(TextBox textBox_CurrentTask)
        {
            Task task1 = Task.Run(() => _startSniffer(textBox_CurrentTask));
        }

        private void _startSniffer(TextBox textBox)
        {
            List<ModelCurrentProcesses> listOfProcesses = new List<ModelCurrentProcesses>();
            DateTime timeToSaveData = DateTime.Now.AddHours(1);

            var addEvent = new AddEvent();
            var procesCategories = new ProcessCategories();

            int delta_time_ms = 1000;                           // 1000 ms == 1s

            string lastProcess = "";

            /*
            listOfProcesses.Add(new ModelCurrentProcesses() {NumberOf100msRunningProces = 2*60*10, ProcesName = "process2 - 2 min" });
            listOfProcesses.Add(new ModelCurrentProcesses() {NumberOf100msRunningProces = 30 * 60*10, ProcesName = "process - 30 min" });
            listOfProcesses.Add(new ModelCurrentProcesses() {NumberOf100msRunningProces = 5*60*10-1, ProcesName = "process-5 - 5 min" });
            listOfProcesses.Add(new ModelCurrentProcesses() {NumberOf100msRunningProces = 60*10, ProcesName = "process - 1 min" });
            listOfProcesses.Add(new ModelCurrentProcesses() {NumberOf100msRunningProces = 20*60*10, ProcesName = "process - 20 min" });
            listOfProcesses.Add(new ModelCurrentProcesses() {NumberOf100msRunningProces = 60, ProcesName = "process - 0 min" });
            counter = max_time;
            */

            while (1 > 0)
            {
                string name = GetActualProcessName();
                string newProcess = procesCategories.GetCategory(name);

                if (lastProcess != newProcess)
                {
                    lastProcess = newProcess;
                    UpdateTextBox(textBox, newProcess);
                }

                if (DateTime.Now > timeToSaveData)
                {
                    timeToSaveData = timeToSaveData.AddHours(1);
                    List<CalendarEvent> listOfEvents = GetListOfLongestProcesses(ref listOfProcesses);
                    foreach (CalendarEvent calendarEvent in listOfEvents)
                    {
                        addEvent.InsertEventToCalendar(calendarEvent);
                    }
                    listOfProcesses.Clear();
                }
                
                UpdateListOfCurrentProcesses(ref listOfProcesses, newProcess);
                Thread.Sleep(delta_time_ms);
            }
        }

    }
}
