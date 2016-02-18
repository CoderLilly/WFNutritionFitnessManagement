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
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void searchRecipesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRecipes recipes = new frmRecipes();
            recipes.ShowDialog();

            //this.Hide();

        }

        private void addNewIngredientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddIngredients addIngredients = new frmAddIngredients();
            addIngredients.ShowDialog();
        }

        private void searchIngredientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearchIngredients searchIngredients = new frmSearchIngredients();
            searchIngredients.ShowDialog();
        }

        private void kitchenTimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerLoad();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmAddIngredients addIngredients = new frmAddIngredients();
            addIngredients.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmSearchIngredients searchIngredients = new frmSearchIngredients();
            searchIngredients.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmKTimer kitchenTimer1 = new frmKTimer();
            kitchenTimer1.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frmKTimer kitchenTimer2 = new frmKTimer();
            kitchenTimer2.Show();
        }


        private void btnKitchenTimer_Click(object sender, EventArgs e)
        {

            timerLoad();
        }

        //int amount = 0;
        private void timerLoad()
        {
            int amount = GlobalVariables.amount;
            if (amount > 5) { return; }

            frmKTimer[] forms = new frmKTimer[6];

            forms[amount] = new frmKTimer();

            forms[amount].Text = "Timer " + (amount + 1);

            forms[amount].Show();
            GlobalVariables.amount++;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.stopwatch == false)
            {
                frmStopwatch stopwatch = new frmStopwatch();
                stopwatch.Show();
                GlobalVariables.stopwatch = true;
            }

        }

        private void stopwatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.stopwatch == false)
            {
                frmStopwatch stopwatch = new frmStopwatch();
                stopwatch.Show();
                GlobalVariables.stopwatch = true;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmConverter converter = new frmConverter();
            converter.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmDataImport di = new frmDataImport();
            di.Show();
        }

        private void btnCalBurnCalc_Click(object sender, EventArgs e)
        {
            frmActivityCalculator activity = new frmActivityCalculator();
            activity.Show();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmCreateUser newUser = new frmCreateUser();
            newUser.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void btnSearchRecipes_Click(object sender, EventArgs e)
        {
            frmSearchRecipes recipes = new frmSearchRecipes();
            recipes.Show();
        }        

        private void frmMain_Activated(object sender, EventArgs e)
        {
            if (DateTime.Now.ToString("tt") == "PM")
            {
                this.Text = "Nutrition and Fitness Management System - Good Afternoon " + GlobalVariables.currentUser;
            }
            else if (DateTime.Now.ToString("tt") == "AM")
            {
                this.Text = "Nutrition and Fitness Management System - Good Morning " + GlobalVariables.currentUser;
            }

            if (GlobalVariables.currentUser == "Guest")
            {
                pnlDaily.Enabled = false;
                
                lblGuestMessage.Visible = true;
            }
            else
            {
                pnlDaily.Enabled = true;
                lblGuestMessage.Visible = false;
            }
            
            txtCurentUser.Text = GlobalVariables.currentUser;
            if (GlobalVariables.currentUser == "") { return; }
            else { gridload(); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        private void frmMain_Load(object sender, EventArgs e)
        {           

            //gridload();
        }

        private void btnAddToDaily_Click(object sender, EventArgs e)
        {
            try
            {
                using (NutritionFitnessEntities context = new NutritionFitnessEntities())
                {
                    Daily daily = new Daily()                   
                    {
                        User = GlobalVariables.currentUser,
                        BloodPressure = txtBP.Text,
                        RestingHR = int.Parse(txtHR.Text),
                        BloodSugar = int.Parse(txtBG.Text),
                        SelectedDateTime = dtpDailyMangement.Value,
                        SelectedActivity = txtActivity.Text,
                        Food = txtFood.Text,
                        CalorieBurn = decimal.Parse(txtCalBurn.Text),
                        CalorieIntake = decimal.Parse(txtCalIntake.Text),


                    };

                    context.Dailies.Add(daily);                    
                    context.SaveChanges();                    
                    gridload();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("You must enter a value for each item");
            }
        }

        private void gridload()
        {
            using (NutritionFitnessEntities context = new NutritionFitnessEntities())
            {
                Daily daily = new Daily();
                BindingSource dm = new BindingSource();
                            
                dm.DataSource = context.Dailies.Where(c => c.User.Contains(GlobalVariables.currentUser)).ToList();
                dataGridView1.DataSource = dm;
                dataGridView1.Refresh();
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            gridload();
        }

        private void btnSearchActivity_Click(object sender, EventArgs e)
        {
            frmActivityCalculator burnCalculator = new frmActivityCalculator();

            burnCalculator.ShowDialog();

            txtActivity.Text = burnCalculator.passedActivity;
            txtCalBurn.Text = string.Format("{0:N2}", burnCalculator.passedCalories);
        
        }
    }
}
