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
    public partial class frmCreateUser : Form
    {
        public frmCreateUser()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            addUser();

            //try
            //{
            //    if(txtPassword.Text != txtVerifyPassword.Text)
            //    {
            //        //MessageBox.Show("Passwords did not match.");
            //        lblCreateFinished.Text = "Passwords did not match.";
            //        txtPassword.Text = "";
            //        txtVerifyPassword.Text = "";
            //        return;
            //    }

            //    using (NutritionFitnessEntities context = new NutritionFitnessEntities())
            //    {
            //        //Ingredient ingredient = new Ingredient()
            //        UserProfile newUser = new UserProfile()
            //        {
            //            Username = txtUserName.Text,
            //            Age = int.Parse(cbAge.Text),
            //            DOB = DateTime.Parse(dtpDOB.Text),
            //            Weight = decimal.Parse(txtWeight.Text),
            //            Password = txtPassword.Text
            //        };

            //        context.UserProfiles.Add(newUser);                    
            //        context.SaveChanges();
            //        lblCreateFinished.Text = "New user profile has been created.";
            //    }
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("You must enter a value for each item");
            //}
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                addUser();

            }
        }

        public void addUser()
        {
            try
            {
                if (txtPassword.Text != txtVerifyPassword.Text)
                {
                    //MessageBox.Show("Passwords did not match.");
                    lblCreateFinished.Text = "Passwords did not match.";
                    txtPassword.Text = "";
                    txtVerifyPassword.Text = "";
                    return;
                }

                using (NutritionFitnessEntities context = new NutritionFitnessEntities())
                {
                    //Ingredient ingredient = new Ingredient()
                    UserProfile newUser = new UserProfile()
                    {
                        Username = txtUserName.Text,
                        Age = int.Parse(cbAge.Text),
                        DOB = DateTime.Parse(dtpDOB.Text),
                        Weight = decimal.Parse(txtWeight.Text),
                        Password = txtPassword.Text
                    };

                    context.UserProfiles.Add(newUser);
                    context.SaveChanges();
                    lblCreateFinished.Text = "New user profile has been created.";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("You must enter a value for each item");
            }
        }
    }
}
