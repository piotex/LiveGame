using LiveGame.MyCode.Calendar.Logic;
using LiveGame.MyCode.Models;
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
    public partial class FormAddHabit : Form
    {
        public FormAddHabit()
        {
            InitializeComponent();
        }

        private void FormAddHabit_Load(object sender, EventArgs e)
        {
            textBox_Time.Text = DateTime.Now.ToString("hh:00");
            comboBox_Frequency.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = textBox_Msg.Text;
            string frequency = comboBox_Frequency.SelectedItem.ToString();
            DateTime time = DateTime.Parse(textBox_Time.Text);

            ModelHabit model = new ModelHabit(msg, frequency, time);

            new CalendarHabitManager().AddHabit(model);

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
