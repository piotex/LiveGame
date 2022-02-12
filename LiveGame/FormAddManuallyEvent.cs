using LiveGame.MyCode.Calendar.Logic;
using LiveGame.MyCode.Calendar.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveGame
{
    public partial class FormAddManuallyEvent : Form
    {
        public FormAddManuallyEvent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string title = textBox1.Text;
            int time = int.Parse(textBox2.Text);
            DateTime start = DateTime.Now.AddMinutes(-time);
            DateTime end = DateTime.Now;

            Google.Apis.Calendar.v3.Data.Event google_ev = new CalendarEvent(title, start, end);

            AddEvent tmp = new AddEvent();
            tmp.InsertEventToCalendar(google_ev);

            int counter = 0;
            while (checkBox1.Checked)
            {
                Thread.Sleep(100);
                counter++;
                if (counter > 10)   //1s
                    break;
            }
            this.Close();
        }
    }
}
