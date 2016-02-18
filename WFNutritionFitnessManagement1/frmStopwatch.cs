using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFNutritionFitnessManagement1
{
    public partial class frmStopwatch : Form
    {
        public frmStopwatch()
        {
            InitializeComponent();
        }

        int h, m, s = 0;
        bool running = false;

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (running == true)
            {
                timer1.Stop();
                //btnStopwatchStart.Text = "Start";
                h = 0;
                m = 0;
                s = 0;
                running = false;
                lblKTimer1.Text ="00:00:00";
            }
            else
            {
                lblKTimer1.Text = "00:00:00";
            }
        }

        private void frmStopwatch_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalVariables.stopwatch = false;
        }

        private void btnKT1Reset_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            running = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s++;

            //if (ms > 100) { s++; ms = 0; }

            if (s > 60) { m++; s = 0; }
           
            if (m > 60) { h++; m = 0; }
            
            //if (m > 0) { h++; m = 1; }
            
            //if (h == 0 && m == 0 && s == 0) { timer1.Stop(); Alarm(); }

            lblKTimer1.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", h, m, s);
            //lblMs.Text = ms.ToString();
        }

        //private void btnKT1Start_Click(object sender, EventArgs e)
        //{

        //    timer1.Start();
        //}

        private void btnStopwatchStart_Click(object sender, EventArgs e)
        {
            if (running == false)
            {
                timer1.Start();
                //btnStopwatchStart.Text = "Pause";
                running = true;
            }
            //else { timer1.Stop(); btnStopwatchStart.Text = "Start"; running = false; }
        }

        //private void btnKT1PauseResume_Click(object sender, EventArgs e)
        //{
        //    if (btnKT1PauseResume.Text == "Pause") { timer1.Stop(); btnKT1PauseResume.Text = "Resume"; }
        //    else { timer1.Start(); btnKT1PauseResume.Text = "Pause"; }
        //}

        //private void Alarm()
        //{
        //    string alarmFile = @"C:\Users\Lilly\documents\visual studio 2015\Projects\WFNutritionFitnessManagement1\WFNutritionFitnessManagement1\ALAR_003.wav";

        //    var sound = new SoundPlayer(alarmFile);

        //    for (int i = 0; i < 5; i++)
        //    {
        //        sound.Play();
        //    }

        //}
    }
}
