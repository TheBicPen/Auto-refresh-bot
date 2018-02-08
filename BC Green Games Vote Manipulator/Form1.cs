using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BC_Green_Games_Vote_Manipulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "https://www.bcgreengames.ca/vote/entityform/2199/1/vote/alternate/lXzxzSeOs71jxeGK27YQIIPSTI2kiL6ZQ2qDXKOQnu8/ajax";
            textBox2.Text = "300";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Interval = int.Parse(textBox2.Text) * 1000;
        }
    }
}
