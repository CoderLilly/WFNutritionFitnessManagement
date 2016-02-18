using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFNutritionFitnessManagement1
{
    public partial class frmDataImport : Form
    {
        public frmDataImport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + textBox1.Text + "; Extended Properties = 'Excel 12.0 Xml;HDR=YES'");
                OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM [Sheet1$]", conn);
                da.Fill(dataSet1);
                //MessageBox.Show(dataSet1.Tables[0].Rows.Count.ToString());
                dataGridView1.DataSource = dataSet1.Tables[0];
            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message);
            }
        }

        private void mETBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.mETBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.nutritionFitnessDataSet);

        }

        private void frmDataImport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nutritionFitnessDataSet1.Activities' table. You can move, or remove it, as needed.
            this.activitiesTableAdapter.Fill(this.nutritionFitnessDataSet1.Activities);
            //try
            //{
            //    // TODO: This line of code loads data into the 'nutritionFitnessDataSet.MET' table. You can move, or remove it, as needed.
            //    this.mETTableAdapter.Fill(this.nutritionFitnessDataSet.MET);
            //    // TODO: This line of code loads data into the 'nutritionFitnessDataSet.MET' table. You can move, or remove it, as needed.
            //    this.mETTableAdapter.Fill(this.nutritionFitnessDataSet.MET);
            //    // TODO: This line of code loads data into the 'nutritionFitnessDataSet.MET' table. You can move, or remove it, as needed.
            //    this.mETTableAdapter.Fill(this.nutritionFitnessDataSet.MET);
            //}
            //catch(Exception g) { MessageBox.Show(g.ToString()); }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow r in dataSet1.Tables[0].Rows)
                {
                    // DataRow dr = nutritionFitnessDataSet.MET.NewRow();
                    DataRow dr = nutritionFitnessDataSet1.Activities.NewRow();
                    dr[1] = r[0];
                    dr[2] = r[1];
                    dr[3] = r[2];
                    dr[4] = r[3];

                    // nutritionFitnessDataSet.MET.Rows.Add(dr);
                    // mETTableAdapter.Update(nutritionFitnessDataSet);

                    nutritionFitnessDataSet1.Activities.Rows.Add(dr);
                }

                // mETTableAdapter.Update(nutritionFitnessDataSet);
                activitiesTableAdapter.Update(nutritionFitnessDataSet1);
            }
            catch(Exception g)
            { MessageBox.Show(g.ToString()); }
        }

        private void mETBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            //this.Validate();
            //this.mETBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.nutritionFitnessDataSet);

        }

        private void mETBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            //this.Validate();
            //this.mETBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.nutritionFitnessDataSet);

        }

        private void activitiesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.activitiesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nutritionFitnessDataSet1);

        }
    }
}
