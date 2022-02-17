using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveGame
{
    public partial class Form_HabitRemainder : Form
    {
        public int SelectedAnswer = 0;
        public Label TextBox;

        public Form_HabitRemainder()
        {
            InitializeComponent();
            TextBox = textBox_Processes;
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void button_HabitRemainder_OK_Click(object sender, EventArgs e)
        {
            SelectedAnswer = 1;
        }

        private void button_HabitRemainder_X_Click(object sender, EventArgs e)
        {
            SelectedAnswer = -1;
        }

        private void textBox_Processes_TextChanged(object sender, EventArgs e)
        {
           // TextBox.SelectionStart = 0;

        }
    }
}
