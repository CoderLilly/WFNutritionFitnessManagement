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
    public partial class frmSearchRecipes : Form
    {
        NutritionFitnessEntities context;

        public frmSearchRecipes()
        {
            InitializeComponent();
            context = new NutritionFitnessEntities();
        }
       
        private void btnSearchRecipe_Click(object sender, EventArgs e)
        {
            try
            {
                
                                  
                    lstRecipeName.DataSource = null;

                    string userSelected = txtRecipeName.Text;
                    var data = from b in context.Recipes where b.Name.Contains(userSelected) select b;

                    lstRecipeName.Items.AddRange(data.ToArray());                    

                    lstRecipeName.DisplayMember = "Name";
                    lstRecipeName.DataSource = data;

                
            }
            catch (Exception g) { MessageBox.Show(g.Message); }
        }

        private void lstRecipeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                if (lstRecipeName.SelectedItem == null) { return; }
                int id = (lstRecipeName.SelectedItem as Recipe).Id;
                var selectedRecipe = lstRecipeName.SelectedItem as Recipe;
                //MessageBox.Show(selectedRecipe.RecipeIngredients.;
                
                //lstIngredients.Items.AddRange(selectedRecipe.RecipeIngredients.ToArray());
                var data = from b in context.Ingredients where b.Id.Equals(selectedRecipe.RecipeIngredients) select b;
                lstIngredients.Items.AddRange(data.ToArray());
                lstIngredients.DisplayMember = "Name";
                lstIngredients.DataSource = data;
                //lstIngredients.Text = selectedRecipe.RecipeIngredients.Add<RecipeIngredient>;
                //lblIngredient1.Text = ;
                
               
                
            }
            catch(Exception g) { MessageBox.Show(g.ToString()); }
        }
    }
}
