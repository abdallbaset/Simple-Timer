using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Timer : Form
    {
        public Timer()
        {
            InitializeComponent();
        }

        byte CounterSecend = 0;
        byte CounterMinute = 0;
        byte CounterHour   = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            CounterSecend++;
            lbl_Sacend.Text = CounterSecend.ToString();
            lbl_Minute.Text = CounterMinute.ToString();
            lbl_Hour.Text = CounterHour.ToString();

            if (CounterSecend == 60)
            {
                CounterSecend = 0;
                CounterMinute++;
                if(CounterMinute == 60)
                {
                    CounterMinute= 0;
                    CounterHour++;
                }
            }
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void btn_Restart_Click(object sender, EventArgs e)
        {
           CounterHour = 0;
           CounterMinute = 0;
           CounterSecend = 0;
            lbl_Hour.Text=CounterHour.ToString();
            lbl_Minute.Text= CounterMinute.ToString();
            lbl_Sacend.Text= CounterSecend.ToString();
        }
    }
}
