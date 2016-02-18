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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
                       

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            login();
                       
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            GlobalVariables.currentUser = "Guest";
            this.Close();
        }

        private void btnNewProfile_Click(object sender, EventArgs e)
        {
            frmCreateUser createUser = new frmCreateUser();
            createUser.Show();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {

                
        }

        public void login()
        {
            string userName = txtUserName.Text;
            string userPassword = txtPassword.Text;



            try {
                using (NutritionFitnessEntities context = new NutritionFitnessEntities())
                {
                    var user = context.UserProfiles.Where(c => c.Username.Contains(userName));
                    var userData = user.FirstOrDefault<UserProfile>();

                    if (userData.Password == userPassword)
                    {
                        GlobalVariables.currentUser = userName;

                        //frmMain mainForm = new frmMain();
                        //mainForm.Text = "Welcome " + userName;

                        this.Close();
                        //form1.Visible = true;
                        //MessageBox.Show("Success!");

                    }
                    else
                    {
                        MessageBox.Show("Login information is incorrect. Please try again.");
                    }
                }
            }
            catch (Exception g)
            {
                MessageBox.Show(g.ToString());
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                login();

            }
        }

        private void frmLogin_Shown(object sender, EventArgs e)
        {
            this.Activate();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
