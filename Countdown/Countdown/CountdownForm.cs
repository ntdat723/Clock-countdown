using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Countdown
{
    public partial class CountdownForm : Form
    {
        int IntHour, IntMin, IntSec;
        public string Display(int first, int second, int third)
        {
            return first.ToString().PadLeft(2, '0') + ':' + second.ToString().PadLeft(2, '0') + ':' + third.ToString().PadLeft(2, '0');
        }
        public CountdownForm()
        {
            InitializeComponent();
        }

        private void CountdownForm_Load(object sender, EventArgs e)
        {
            OnDisplay.Text = Display(Convert.ToInt32(HourUpDown.Value), Convert.ToInt32(MinuteUpDown.Value), Convert.ToInt32(SecondUpDown.Value));
        }

        private void Start_Click(object sender, EventArgs e)
        {
            OnDisplay.ForeColor = System.Drawing.Color.Black;

            IntHour = Convert.ToInt32(HourUpDown.Value);
            IntMin = Convert.ToInt32(MinuteUpDown.Value);
            IntSec = Convert.ToInt32(SecondUpDown.Value);

            HourUpDown.Enabled = false;
            MinuteUpDown.Enabled = false;
            SecondUpDown.Enabled = false;

            Start.Visible = false;
            PauseButton.Visible = true;


            countingDown.Enabled = true;
            countingDown.Start();
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            PauseButton.Visible = false;
            ResumeButton.Visible = true;
            countingDown.Stop();
        }

        private void ResumeButton_Click(object sender, EventArgs e)
        {
            ResumeButton.Visible = false;
            PauseButton.Visible = true;
            countingDown.Start();
        }

        private void countingDown_Tick(object sender, EventArgs e)
        {
            if (IntHour > 0)
            {
                if (IntMin > 0)
                {
                    if (IntSec > 0)
                    {
                        --IntSec;
                    }
                    else
                    {
                        --IntMin;
                        IntSec = 59;
                    }
                }
                else
                {
                    if (IntSec > 0)
                    {
                        --IntSec;
                    }
                    else
                    {
                        --IntHour;
                        IntSec = 59;
                        IntMin = 59;
                    }
                }
            }
            else
            {
                if (IntMin > 0)
                {
                    if (IntSec > 0)
                    {
                        --IntSec;
                    }
                    else
                    {
                        --IntMin;
                        IntSec = 59;
                    }
                }
                else
                {
                    if (IntSec > 0)
                    {
                        --IntSec;
                    }
                }
            }

            if (IntSec <= 10 && IntHour == 0 && IntMin == 0)
            {
                OnDisplay.ForeColor = System.Drawing.Color.Red;
                OnDisplay.Text = Display(IntHour, IntMin, IntSec);
            }
            else
            {
                OnDisplay.Text = Display(IntHour, IntMin, IntSec);
            }

            if (IntSec == 0 && IntMin == 0 && IntHour == 0)
            {
                countingDown.Stop();

                HourUpDown.Enabled = true;
                MinuteUpDown.Enabled = true;
                SecondUpDown.Enabled = true;

                PauseButton.Visible = false;
                Start.Visible = true;

                MessageBox.Show("TIME OVER!", "Timeout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
