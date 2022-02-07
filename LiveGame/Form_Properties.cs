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
    public partial class Form_Properties : Form
    {
        public Form_Properties()
        {
            InitializeComponent();

            Task.Run(() => updateProcesIdTxtBox());
        }

        private void updateProcesIdTxtBox()
        {
            //textBox_Processes.Text = Program.GetActualProcessName();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textBox_Processes.Text = 
        }
    }
}
