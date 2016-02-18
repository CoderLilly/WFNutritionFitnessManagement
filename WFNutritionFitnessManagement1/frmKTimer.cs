using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace WFNutritionFitnessManagement1
{
    public partial class frmKTimer : Form
    {
        public frmKTimer()
        {
            InitializeComponent();
            tbKTimer1Title.Text = "Timer " + (GlobalVariables.amount +1);            
        }

        int h1;
        int m1;
        int s1;
        bool running = false;
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            s1--;

            if (s1 < 0) { m1--; s1 = 59; }
            if (m1 < 0) { h1--; m1 = 59; }

            if (h1 == 0 && m1 == 0 && s1 == 0) { timer1.Stop(); Alarm(); }

            lblKTimer1.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", h1, m1, s1);
        }

        private void btnKT1Start_Click(object sender, EventArgs e)
        {           

            h1 = Convert.ToInt32(cmbKT1Hour.Text);
            m1 = Convert.ToInt32(cmbKT1Minute.Text);
            s1 = Convert.ToInt32(cmbKT1Second.Text);
            running = true;

            timer1.Start();
        }

        private void btnKT1PauseResume_Click(object sender, EventArgs e)
        {
            if (running == true) { timer1.Stop(); running = false; }
            else { timer1.Start(); running = true; }
        }

        private void Alarm()
        {
            string alarmFile = @"C:\Users\Lilly\documents\visual studio 2015\Projects\WFNutritionFitnessManagement1\WFNutritionFitnessManagement1\ALAR_003.wav";

            var sound = new SoundPlayer(alarmFile);

            for (int i = 0; i < 5; i++)
            {
                sound.Play();
            }

        }

        private void btnKT1Reset_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            cmbKT1Hour.Text = "0";
            cmbKT1Minute.Text = "0:";
            cmbKT1Second.Text = "0:";
            lblKTimer1.Text = "00:00:00";
        }

        private void frmKTimer_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalVariables.amount--;
        }
    }
}
