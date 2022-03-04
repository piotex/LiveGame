using LiveGame.MyCode.Calendar.Logic;
using LiveGame.MyCode.Calendar.Models;
using LiveGame.MyCode.ProcesSniffer.Categories;
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

            if ( !checkBox_AddBackward.Checked)
            {
                start = DateTime.Now;
                end = DateTime.Now.AddMinutes(time);
            }

            string colorId = new ProcessCategoriesColor().GetProcessColorId(title);
            CalendarEvent model = new CalendarEvent(title, start, end, colorId);

            new AddEvent().InsertEventToCalendar(model);

            CloseForm();
        }

        private void CloseForm()
        {
            if (checkBox_AutoClose.Checked)
            {
                int counter = 0;
                while (checkBox_AutoClose.Checked)
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
}
