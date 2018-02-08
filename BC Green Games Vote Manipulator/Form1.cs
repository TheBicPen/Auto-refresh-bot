﻿using System;
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
        int timeRemaining;
        int interval;
        Uri uri;
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "https://www.bcgreengames.ca/vote/entityform/2199/1/vote/alternate/lXzxzSeOs71jxeGK27YQIIPSTI2kiL6ZQ2qDXKOQnu8/ajax";
            textBox2.Text = "300";

            interval = int.Parse(textBox2.Text);
            Uri uri2 = new Uri(textBox1.Text);
            webBrowser1.Url = uri2;

            label2.Text = interval.ToString();
          //  label3.Text = webBrowser1.Url.ToString();

            webBrowser1.Refresh();
            timeRemaining = interval;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeRemaining --;
            label1.Text = timeRemaining.ToString();
            if(timeRemaining <= 0)
            {
                webBrowser1.Refresh();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
            label3.Text += webBrowser1.Url.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            interval = int.Parse(textBox2.Text);
            timer1.Interval = interval;
            label2.Text = timer1.Interval.ToString();
        }
    }
}
