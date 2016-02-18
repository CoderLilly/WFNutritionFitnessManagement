namespace WFNutritionFitnessManagement1
{
    partial class frmSearchRecipes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSearchRecipe = new System.Windows.Forms.Button();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.lstRecipeName = new System.Windows.Forms.ListBox();
            this.lstIngredients = new System.Windows.Forms.ListBox();
            this.lblIngredient1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSearchRecipe
            // 
            this.btnSearchRecipe.Location = new System.Drawing.Point(140, 13);
            this.btnSearchRecipe.Name = "btnSearchRecipe";
            this.btnSearchRecipe.Size = new System.Drawing.Size(75, 23);
            this.btnSearchRecipe.TabIndex = 0;
            this.btnSearchRecipe.Text = "Search";
            this.btnSearchRecipe.UseVisualStyleBackColor = true;
            this.btnSearchRecipe.Click += new System.EventHandler(this.btnSearchRecipe_Click);
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Location = new System.Drawing.Point(34, 15);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(100, 20);
            this.txtRecipeName.TabIndex = 1;
            // 
            // lstRecipeName
            // 
            this.lstRecipeName.FormattingEnabled = true;
            this.lstRecipeName.Location = new System.Drawing.Point(34, 42);
            this.lstRecipeName.Name = "lstRecipeName";
            this.lstRecipeName.Size = new System.Drawing.Size(181, 212);
            this.lstRecipeName.TabIndex = 2;
            this.lstRecipeName.SelectedIndexChanged += new System.EventHandler(this.lstRecipeName_SelectedIndexChanged);
            // 
            // lstIngredients
            // 
            this.lstIngredients.FormattingEnabled = true;
            this.lstIngredients.Location = new System.Drawing.Point(222, 133);
            this.lstIngredients.Name = "lstIngredients";
            this.lstIngredients.Size = new System.Drawing.Size(158, 121);
            this.lstIngredients.TabIndex = 3;
            // 
            // lblIngredient1
            // 
            this.lblIngredient1.AutoSize = true;
            this.lblIngredient1.Location = new System.Drawing.Point(222, 42);
            this.lblIngredient1.Name = "lblIngredient1";
            this.lblIngredient1.Size = new System.Drawing.Size(35, 13);
            this.lblIngredient1.TabIndex = 4;
            this.lblIngredient1.Text = "label1";
            // 
            // frmSearchRecipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 261);
            this.Controls.Add(this.lblIngredient1);
            this.Controls.Add(this.lstIngredients);
            this.Controls.Add(this.lstRecipeName);
            this.Controls.Add(this.txtRecipeName);
            this.Controls.Add(this.btnSearchRecipe);
            this.Name = "frmSearchRecipes";
            this.Text = "Search Recipes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchRecipe;
        private System.Windows.Forms.TextBox txtRecipeName;
        private System.Windows.Forms.ListBox lstRecipeName;
        private System.Windows.Forms.ListBox lstIngredients;
        private System.Windows.Forms.Label lblIngredient1;
    }
}