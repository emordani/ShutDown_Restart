using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShutDown_Restart
{
    public partial class Form1 : Form
    {
        private string power;
        int Hour;
        int Minute;
        int Second;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioShutDown.Checked)
                power = "Shuttig down";
            if (radioRestart.Checked)
                power = "Restarting";

            if (!radioTime.Checked && !radioInterval.Checked && !radioShutDown.Checked && !radioRestart.Checked)
            {
                MessageBox.Show("Select power and time option!");
            }
            else if (!radioShutDown.Checked && !radioRestart.Checked)
            {
                MessageBox.Show("Select power option!");
            }
            else if (!radioTime.Checked && !radioInterval.Checked)
            {
                MessageBox.Show("Select time option!");
            }
            else if (radioTime.Checked)
            {
                DateTime now = new DateTime();
                now = DateTime.Now;
                DateTime time = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, (int)numericHour.Value, (int)numericMinute.Value, (int)numericSecond.Value);
                TimeSpan interval = time - now;
                
                Hour = interval.Hours;
                Minute = interval.Minutes;
                Second = interval.Seconds;
                timer1.Start();

                numericHour.Visible = false;
                numericMinute.Visible = false;
                numericSecond.Visible = false;
                labelHour.Visible = false;
                labelMinute.Visible = false;
                labelSeconds.Visible = false;
                buttonClear.Visible = false;

            }
            else if (radioInterval.Checked)
            {
                Hour = (int)numericHour.Value;
                Minute = (int)numericMinute.Value;
                Second = (int)numericSecond.Value;
                timer1.Start();

                numericHour.Visible = false;
                numericMinute.Visible = false;
                numericSecond.Visible = false;
                labelHour.Visible = false;
                labelMinute.Visible = false;
                labelSeconds.Visible = false;
                buttonClear.Visible = false;

            }
            
                     
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Hour != 0 && Minute == 0)
            {
                --Hour;
                Minute = 60;
            }
            if (Minute!= 0 && Second == 0)
            {
                --Minute;
                Second = 60;
            }
            if (Second != 0)
                Second -= 1;

            label1.Text = power + " in " + Hour.ToString() + ": " + Minute.ToString() + ": " + Second.ToString();

            if (Second == 0 && Minute == 0 && Hour == 0)
            {
                timer1.Stop();
                Power();
            }
        }
        public void Power()
        {
            if (radioShutDown.Checked)
            {
                Process.Start("shutdown", "/s /t 0");
            }
            if (radioRestart.Checked)
            {
                Process.Start("shutdown", "/r /t 0");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            numericHour.Visible = true;
            numericMinute.Visible = true;
            numericSecond.Visible = true;
            labelHour.Visible = true;
            labelMinute.Visible = true;
            labelSeconds.Visible = true;
            buttonClear.Visible = true;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            numericHour.Value = 0;
            numericMinute.Value = 0;
            numericSecond.Value = 0;          
        }
    }
}
