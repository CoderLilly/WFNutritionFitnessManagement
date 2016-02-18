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
    public partial class frmActivityCalculator : Form
    {
        
        public frmActivityCalculator()
        {
            InitializeComponent();
        }

        private void frmActivityCalculator_Load(object sender, EventArgs e)
        {
            lstBoxPrimary.Focus();
            lstBoxPrimary.SelectedIndex = 0;
            //lstBoxSecondary.SelectedIndex = 0;

        }

        private void lstBoxPrimary_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {                  
                lstBoxActivity.Items.Clear();
                
                string userSelected = lstBoxPrimary.Text;
                using (NutritionFitnessEntities context = new NutritionFitnessEntities())
                {
                    var activity = context.Activities.Where(c => c.MajorCategory.Contains(userSelected));
                    lstBoxActivity.Items.AddRange(activity.ToArray());
                    lstBoxActivity.DisplayMember = "SpecificActivity";                    

                }
            }
            catch (Exception g) { MessageBox.Show(g.ToString()); }
                        
        }

        private void btnSearchActivity_Click(object sender, EventArgs e)
        {
            search();           

        }

        string selectedActivityId;
        private void lstBoxActivity_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {                        
                using (NutritionFitnessEntities context = new NutritionFitnessEntities())
                {
                    if (lstBoxActivity.SelectedItem == null) { return; }
                    int id = (lstBoxActivity.SelectedItem as Activity).Id;                    
                    var selectedActivity = lstBoxActivity.SelectedItem as Activity;
                    var selectedMET = selectedActivity.MET;

                    selectedActivityId = selectedActivity.MET.ToString();                                      
                }
            }
            catch (Exception g) { MessageBox.Show(g.ToString()); }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            calculate();
            btnAddActivity.Enabled = true;      

        }

        private void tbSearchActivity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                search();
            }
        }

        public void search()
        {
            try
            {
                if (lstBoxActivity.DataSource != null)
                {
                    lstBoxActivity.DataSource = null;
                }
                lstBoxActivity.Items.Clear();
                string userSelected = tbSearchActivity.Text;
                using (NutritionFitnessEntities context = new NutritionFitnessEntities())
                {
                    var activity = context.Activities.Where(c => c.SpecificActivity.Contains(userSelected));
                    lstBoxActivity.Items.AddRange(activity.ToArray());
                    lstBoxActivity.DisplayMember = "SpecificActivity";
                    lstBoxActivity.DataSource = activity;
                }
            }
            catch (Exception g) { MessageBox.Show(g.ToString()); }
        }

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                calculate();
               
            }

        }

        private void calculate()
        {
            double totalTime;
            if (cbHours.Text == "Hours:") { cbHours.Text = "0"; }
            if (cbMinutes.Text == "Minutes:") { cbMinutes.Text = "0"; }
            //int hours = Convert.ToInt32(cbHours.SelectedText);
            double hours = Convert.ToDouble(cbHours.Text);
            double minutes = Convert.ToDouble(cbMinutes.Text);
            double weight = Convert.ToDouble(txtWeight.Text);
            double kilos = weight / 2.2;
            double caloriesBurned;
            double selectedActivityMET = Convert.ToDouble(selectedActivityId);

            totalTime = hours + (minutes / 60);

            var personalMET = selectedActivityMET * kilos;

            caloriesBurned = totalTime * personalMET;

            //lblCaloriesBurned.Text = caloriesBurned.ToString("D2");

            lblCaloriesBurned.Text = string.Format("{0:N2}", caloriesBurned);
            //MessageBox.Show(personalMET.ToString());
        }

        private string selectedActivity;
        public string passedActivity
        {
            get { return selectedActivity; }
            set { selectedActivity = value; }
        }

        private double calculatedCalories;
        public double passedCalories
        {
            get { return calculatedCalories; }
            set { calculatedCalories = value; }
        }

        private void btnAddActivity_Click(object sender, EventArgs e)
        {

            try
            {
                
                passedActivity = lstBoxActivity.Text;
                passedCalories = double.Parse(lblCaloriesBurned.Text);
                this.Hide();
            }
            catch(Exception g)
            { MessageBox.Show(g.ToString()); }   

        }
    }

   
}
