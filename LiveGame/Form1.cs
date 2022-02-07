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

            Task task1 = Task.Run( ()=> new ActualProcessSniffer().StartSniffer( textBox_CurrentTask) );

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            Point screan_size = new Point(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            this.Location = new Point(screan_size.X - this.Width, 130);
            this.Opacity = (0.70);

            this.TopMost = true;
        }

        void mouseHover()
        {
            this.Opacity = 1;
        }
        void mouseLeave()
        {
            this.Opacity = 0.7;
        }

        private void button_Icon_Click(object sender, EventArgs e)
        {
            FormAddManuallyEvent form = new FormAddManuallyEvent();
            form.Show();
            
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
