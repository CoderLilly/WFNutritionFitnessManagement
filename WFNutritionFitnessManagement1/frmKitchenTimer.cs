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
    public partial class frmKitchenTimer : Form
    {
        
        public frmKitchenTimer()
        {
            InitializeComponent();
        }

        int h1; int m1; int s1;
        int h2; int m2; int s2;
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

            if (cmbKT1Hour.Text == "Hrs:") { return; }
            if (cmbKT1Minute.Text == "Min:") { return; }
            if (cmbKT1Second.Text == "Sec:") { return; }

            h1 = Convert.ToInt32(cmbKT1Hour.Text);
            m1 = Convert.ToInt32(cmbKT1Minute.Text);
            s1 = Convert.ToInt32(cmbKT1Second.Text);

            timer1.Start();
        }

        private void btnKT2Start_Click(object sender, EventArgs e)
        {
            if (cmbKT2Hour.Text == "Hrs:") { cmbKT2Hour.Text = "0"; }
            if (cmbKT2Minute.Text == "Min:") { cmbKT2Minute.Text = "0"; }
            if (cmbKT2Second.Text == "Sec:") { cmbKT2Second.Text = "0"; }

            h2 = Convert.ToInt32(cmbKT2Hour.Text);
            m2 = Convert.ToInt32(cmbKT2Minute.Text);
            s2 = Convert.ToInt32(cmbKT2Second.Text);

            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            s2--;

            if (s2 < 0) { m2--; s2 = 59; }
            if (m2 < 0) { h2--; m2 = 59; }

            if (h2 == 0 && m1 == 0 && s2 == 0) { timer2.Stop(); Alarm(); }

            lblKTimer2.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", h2, m2, s2);
        }

        private void btnKT1PauseResume_Click(object sender, EventArgs e)
        {
            if (btnKT1PauseResume.Text == "Pause") { timer1.Stop(); btnKT1PauseResume.Text = "Resume"; }
            else { timer1.Start(); btnKT1PauseResume.Text = "Pause"; }
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
            cmbKT1Hour.Text = "Hrs:";
            cmbKT1Minute.Text = "Min:";
            cmbKT1Second.Text = "Sec:";
            lblKTimer1.Text = "00:00:00";
        }
    }

    
}
