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
    public partial class frmSearchIngredients : Form
    {
        public frmSearchIngredients()
        {
            InitializeComponent();
            //btnSearchIngredients.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnSearchIngredients_Click(object sender, EventArgs e)
        {
            searchIngredients();
            
        }

        public void searchIngredients()
        {
           
            try
            {
                //label34.Text = "Searching. Please wait...";
                using (NutritionFitnessEntities context = new NutritionFitnessEntities())
                {

                    lstBoxIngredients.ClearSelected();
                    lstBoxIngredients.DataSource = null;

                    string userSelected = tbUserSelected.Text;
                    var data = from b in context.Ingredients where b.Name.Contains(userSelected) select b;

                    lstBoxIngredients.Items.AddRange(data.ToArray());

                    label34.Text = "Search complete";

                    lstBoxIngredients.DisplayMember = "Name";
                    lstBoxIngredients.DataSource = data;

                }
            }
            catch (Exception g) { MessageBox.Show(g.Message); }
        }
        private void lstBoxIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(lstBoxIngredients.SelectedItem == null) { return; }
            int id = (lstBoxIngredients.SelectedItem as Ingredient).Id;
            var selectedIngredient = lstBoxIngredients.SelectedItem as Ingredient;

            lblNutFactsName.Text = selectedIngredient.Name;
            lblNutFactServ.Text = selectedIngredient.ServingSize.ToString("G29");
            lblNutFactServType.Text = selectedIngredient.ServingType;
            lblNutFactCalories.Text = selectedIngredient.Calories.ToString("G29");
            lblNutFactCalFromFat.Text = selectedIngredient.CaloriesFromFat.ToString("G29");
            lblNutFactTotFat.Text = selectedIngredient.TotalFat.ToString("G29");
            lblNutFactSatFat.Text = selectedIngredient.SatFat.ToString("G29");
            lblNutFactPolyunSatFat.Text = selectedIngredient.PolyUnSatFat.ToString("G29");
            lblNutFactMonunSatFat.Text = selectedIngredient.MonoUnSatFat.ToString("G29");
            lblNutFactCholesterol.Text = selectedIngredient.Cholesterol.ToString("G29");
            lblNutFactSodium.Text = selectedIngredient.Sodium.ToString("G29");
            lblNutFactPotassium.Text = selectedIngredient.PolyUnSatFat.ToString("G29");
            lblNutFactTotCarbs.Text = selectedIngredient.Carbohydrates.ToString("G29");
            lblNutFactDietaryFiber.Text = selectedIngredient.DietaryFiber.ToString("G29");
            lblNutFactSugar.Text = selectedIngredient.Sugar.ToString("G29");
            lblNutFactProtein.Text = selectedIngredient.Protein.ToString("G29");
            lblNutFactVitA.Text = selectedIngredient.VitaminA.ToString("G29");
            lblNutFactVitC.Text = selectedIngredient.VitaminC.ToString("G29");
            lblNutFactCalcium.Text = selectedIngredient.Calcium.ToString("G29");
            lblNutFactIron.Text = selectedIngredient.Iron.ToString("G29");
            lblNutFactVitD.Text = selectedIngredient.VitaminD.ToString("G29");
            lblNutFactVitB6.Text = selectedIngredient.VitaminB6.ToString("G29");
            lblNutFactVitB12.Text = selectedIngredient.VitaminB12.ToString("G29");
            lblNutFactMagnesium.Text = selectedIngredient.Magnesium.ToString("G29");
            lblNutFactGluten.Text = selectedIngredient.GlutenFree.ToString();
            lblNutFactNithgshades.Text = selectedIngredient.NightshadeFree.ToString();
            lblNutFactPeanut.Text = selectedIngredient.PeanutFree.ToString();
            lblNutFactTreeNut.Text = selectedIngredient.TreeNutFree.ToString();
            lblNutFactDairy.Text = selectedIngredient.DairyFree.ToString();
            lblNutFactEgg.Text = selectedIngredient.EggFree.ToString();
            lblNutFactSoy.Text = selectedIngredient.SoyFree.ToString();
            lblNutFactVegetarian.Text = selectedIngredient.Vegetarian.ToString();
            lblNutFactVegan.Text = selectedIngredient.Vegan.ToString();

            lblPercentTotFat.Text = ((selectedIngredient.TotalFat / 65).ToString("P"));
            lblPercentSatFat.Text = ((selectedIngredient.SatFat / 20).ToString("P"));
            //lblPercentPolyunSatFat.Text = ((selectedIngredient.PolyUnSatFat / 20).ToString("P"));
            //lblPercentMonounSatFat.Text = ((selectedIngredient.MonoUnSatFat / 24).ToString("P"));
            lblPercentCholesterol.Text = ((selectedIngredient.Cholesterol / 300).ToString("P"));
            lblPercentSodium.Text = ((selectedIngredient.Sodium / 2400).ToString("P"));
            lblPercentPotassium.Text = ((selectedIngredient.Potassium / 3500).ToString("P"));
            lblPercentTotCarbs.Text = ((selectedIngredient.Carbohydrates / 300).ToString("P"));
            lblPercentDietaryFiber.Text = ((selectedIngredient.DietaryFiber / 25).ToString("P"));
            //lblPercentSugar.Text = ((selectedIngredient.Sugar / 25).ToString("P"));
            lblPercentProtein.Text = ((selectedIngredient.Protein / 50).ToString("P"));

        }

        private void tbUserSelected_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                searchIngredients();

            }
        }
    }
}
