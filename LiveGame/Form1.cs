using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveGame.MyCode;
using LiveGame.MyCode.Calendar.Logic;
using LiveGame.MyCode.Calendar.Models;
using LiveGame.MyCode.ProcesSniffer;

namespace LiveGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            new ActualProcessSniffer().StartSniffing( textBox_CurrentTask);
            new CalendarHabitManager().StartManagingHabits();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Point screan_size = new Point(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            this.Location = new Point(screan_size.X - this.Width, 130);
            this.Opacity = (0.70);

            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void button_Habits_Click(object sender, EventArgs e)
        {
            FormAddHabit form = new FormAddHabit();
            form.Show();
        }
        private void button_Icon_Click(object sender, EventArgs e)
        {
            FormAddManuallyEvent form = new FormAddManuallyEvent();
            form.Show();
        }







        void mouseHover()
        {
            this.Opacity = 1;
        }
        void mouseLeave()
        {
            this.Opacity = 0.7;
        }
        private void Form1_MouseHover(object sender, EventArgs e)
        {
            mouseHover();
        }
        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave();
        }
        private void button_Icon_MouseHover(object sender, EventArgs e)
        {
            mouseHover();
        }
        private void button_Icon_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave();
        }
        private void panel1_MouseHover(object sender, EventArgs e)
        {
            mouseHover();
        }
        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave();
        }
        private void button_Habits_MouseLeave(object sender, EventArgs e)
        {
            mouseLeave();
        }
        private void button_Habits_MouseHover(object sender, EventArgs e)
        {
            mouseHover();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
