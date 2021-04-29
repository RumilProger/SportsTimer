using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SportsTimer;
using System.Threading;

namespace SportsTimer
{
    public partial class Form1 : Form
    {
        
        
        System.Windows.Forms.Timer myTimer;
        bool exitFlag = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void TimerWorker()
        {
            TimerSettings settings = new TimerSettings(Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));

            for (int i = 0; i < settings.Intervals; i++)
            {
                if (button1.Text != "Start")
                {
                    textBox1.Text = $"{i + 1}-й интервал, отдых";
                    You(settings.Space * 1000);
                    exitFlag = false;
                    for (int j = 0; j < settings.Circles; j++)
                    {
                        if (button1.Text != "Start")
                        {
                            textBox1.Text = $"{i+1}-й интервал, {j+1}-й круг";
                            You(settings.FirstTime * 1000);
                            exitFlag = false;
                        }
                        if (button1.Text != "Start")
                        {
                            You(settings.SecondTime * 1000);
                            exitFlag = false;
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public int You(int second)
        {
            /* Adds the event and the event handler for the method that will 
               process the timer event to the timer. */
            myTimer = new System.Windows.Forms.Timer();

            myTimer.Tick += new EventHandler(timer1_Tick);

            // Sets the timer interval to 5 seconds.
            myTimer.Interval = second;
            myTimer.Start();

            // Runs the timer, and raises the event.
            while (exitFlag == false)
            {
                // Processes all the events in the queue.
                Application.DoEvents();
            }
            return 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            myTimer.Stop();

            Console.Beep();
            Console.Beep();
            Console.Beep();

            exitFlag = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Start")
            {
                button1.Text = "Stop";
                TimerWorker();
            }
            else
            {
                button1.Text = "Start";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
