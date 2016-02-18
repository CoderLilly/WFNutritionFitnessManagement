namespace WFNutritionFitnessManagement1
{
    partial class frmConverter
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
            this.cbFrom = new System.Windows.Forms.ComboBox();
            this.cbTo = new System.Windows.Forms.ComboBox();
            this.btnConvertStart = new System.Windows.Forms.Button();
            this.tbValueIn = new System.Windows.Forms.TextBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbFrom
            // 
            this.cbFrom.FormattingEnabled = true;
            this.cbFrom.Items.AddRange(new object[] {
            "Teaspoon",
            "Tablespoon",
            "Cup",
            "Pint",
            "Quart",
            "Gallon",
            "Ounce",
            "Milliliter"});
            this.cbFrom.Location = new System.Drawing.Point(33, 83);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(100, 21);
            this.cbFrom.TabIndex = 0;
            this.cbFrom.Text = "Convert from:";
            // 
            // cbTo
            // 
            this.cbTo.FormattingEnabled = true;
            this.cbTo.Items.AddRange(new object[] {
            "Teaspoon",
            "Tablespoon",
            "Cup",
            "Pint",
            "Quart",
            "Gallon",
            "Ounce",
            "Milliliter"});
            this.cbTo.Location = new System.Drawing.Point(235, 83);
            this.cbTo.Name = "cbTo";
            this.cbTo.Size = new System.Drawing.Size(100, 21);
            this.cbTo.TabIndex = 1;
            this.cbTo.Text = "Convert to:";
            // 
            // btnConvertStart
            // 
            this.btnConvertStart.BackColor = System.Drawing.Color.Transparent;
            this.btnConvertStart.BackgroundImage = global::WFNutritionFitnessManagement1.Properties.Resources.StartButton;
            this.btnConvertStart.FlatAppearance.BorderSize = 0;
            this.btnConvertStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnConvertStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertStart.Location = new System.Drawing.Point(146, 67);
            this.btnConvertStart.Name = "btnConvertStart";
            this.btnConvertStart.Size = new System.Drawing.Size(62, 23);
            this.btnConvertStart.TabIndex = 2;
            this.btnConvertStart.UseVisualStyleBackColor = false;
            this.btnConvertStart.Click += new System.EventHandler(this.btnConvertStart_Click);
            // 
            // tbValueIn
            // 
            this.tbValueIn.Location = new System.Drawing.Point(33, 57);
            this.tbValueIn.Name = "tbValueIn";
            this.tbValueIn.Size = new System.Drawing.Size(100, 20);
            this.tbValueIn.TabIndex = 3;
            this.tbValueIn.Text = "0";
            this.tbValueIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(235, 57);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(100, 20);
            this.tbResult.TabIndex = 4;
            this.tbResult.Text = "0";
            this.tbResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "From value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(232, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Result:";
            // 
            // frmConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WFNutritionFitnessManagement1.Properties.Resources._1200x600EarthToneslGradient;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(366, 173);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.tbValueIn);
            this.Controls.Add(this.btnConvertStart);
            this.Controls.Add(this.cbTo);
            this.Controls.Add(this.cbFrom);
            this.Name = "frmConverter";
            this.Text = "Unit Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFrom;
        private System.Windows.Forms.ComboBox cbTo;
        private System.Windows.Forms.Button btnConvertStart;
        private System.Windows.Forms.TextBox tbValueIn;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}