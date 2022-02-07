using System;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UserProcessesEavesdropper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("UserProcessesEavesdropper -> Start");
            Task.Run(() => updateProcesIdTxtBox());

            while (1 > 0)
                Thread.Sleep(1000);
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, System.Text.StringBuilder text, int count);

        public static string GetActualProcessName()
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

        private static void updateProcesIdTxtBox()
        {
            string lastProcess = "";
            while (1 > 0)
            {
                string name = GetActualProcessName();
                if (lastProcess != name)
                {
                    lastProcess = name;
                    Console.WriteLine(name);
                }
                Thread.Sleep(300);
            }
        }
    }
}
