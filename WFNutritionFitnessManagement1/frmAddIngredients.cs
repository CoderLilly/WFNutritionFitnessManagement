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
    public partial class frmAddIngredients : Form
    {
        public frmAddIngredients()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {            
            try
            {           
            using (NutritionFitnessEntities context = new NutritionFitnessEntities())
                {
                    Ingredient ingredient = new Ingredient()
                    {
                        Name = tbIngredientName.Text,
                        ServingSize = Decimal.Parse(tbIngredientServingSize.Text),
                        Calories = Decimal.Parse(tbIngredientCalories.Text),
                        CaloriesFromFat = Decimal.Parse(tbIngredientCaloriesFromFat.Text),
                        TotalFat = Decimal.Parse(tbIngredientTotalFat.Text),
                        SatFat = Decimal.Parse(tbIngredientSaturatedFat.Text),
                        PolyUnSatFat = Decimal.Parse(tbIngredientPolyunsaturatedFat.Text),
                        MonoUnSatFat = Decimal.Parse(tbIngredientMonounsaturatedFat.Text),
                        Cholesterol = Decimal.Parse(tbIngredientCholesterol.Text),
                        Sodium = Decimal.Parse(tbIngredientSodium.Text),
                        Potassium = Decimal.Parse(tbIngredientPotassium.Text),
                        Carbohydrates = Decimal.Parse(tbIngredientCarbohydrates.Text),
                        DietaryFiber = Decimal.Parse(tbIngredientDietaryFiber.Text),
                        Sugar = Decimal.Parse(tbIngredientSugar.Text),
                        Protein = Decimal.Parse(tbIngredientProtein.Text),
                        VitaminA = Decimal.Parse(tbIngredientVitaminA.Text),
                        VitaminC = Decimal.Parse(tbIngredientVitaminC.Text),
                        Calcium = Decimal.Parse(tbIngredientCalcium.Text),
                        Iron = Decimal.Parse(tbIngredientIron.Text),
                        VitaminD = Decimal.Parse(tbIngredientVitaminD.Text),
                        VitaminB6 = Decimal.Parse(tbIngredientVitaminB6.Text),
                        VitaminB12 = Decimal.Parse(tbIngredientVitaminB12.Text),
                        Magnesium = Decimal.Parse(tbIngredientMagnesium.Text),
                        GlutenFree = cbIngredientGlutenFree.Checked,
                        NightshadeFree = cbIngredientNightshadeFree.Checked,
                        PeanutFree = cbIngredientPeanutFree.Checked,
                        TreeNutFree = cbIngredientTreeNutFree.Checked,
                        DairyFree = cbIngredientDairyFree.Checked,
                        EggFree = cbIngredientEggFree.Checked,
                        SoyFree = cbIngredientSoyFree.Checked,
                        Vegetarian = cbIngredientVegetarian.Checked,
                        Vegan = cbIngredientVegan.Checked,
                        ServingType = cbServingType.Text

                };

                    context.Ingredients.Add(ingredient);
                    context.SaveChanges();     
                }
            }
            catch(Exception)
            {
                MessageBox.Show("You must enter a value for each item");
            }       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
