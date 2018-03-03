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
        int timeRemaining;
        int interval;
        int timesVoted;
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "https://www.bcgreengames.ca/vote/entityform/2199/1/vote/alternate/lXzxzSeOs71jxeGK27YQIIPSTI2kiL6ZQ2qDXKOQnu8/ajax";
            textBox2.Text = "302";
            label4.Text += Application.ProductVersion;

            interval = int.Parse(textBox2.Text);
            Uri uri2 = new Uri(textBox1.Text);
            webBrowser1.Url = uri2;

            label2.Text = "Current Refresh Interval:" + interval.ToString();

            timeRemaining = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeRemaining --;
            label1.Text = "Time remaining until refresh:" + timeRemaining.ToString();
            if(timeRemaining <= 0)
            {

                try
                {
                    webBrowser1.Navigate(textBox1.Text);
                }
                catch {  }
                timeRemaining = interval;
                timesVoted++;
                textBox3.AppendText(string.Format(System.Environment.NewLine + "Sent {0}", timesVoted));
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
            label2.Text = "Current Refresh Interval:" + interval.ToString();
            timeRemaining = interval;
            label1.Text = "Time remaining until refresh:" + timeRemaining.ToString();

        }

        private void webBrowser1_FileDownload(object sender, EventArgs e)
        {
            
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            label3.Text = "Current URL: " + webBrowser1.Url.ToString();
            webBrowser1.Dispose();
            webBrowser1 = new WebBrowser();
        }
        
    }
}
