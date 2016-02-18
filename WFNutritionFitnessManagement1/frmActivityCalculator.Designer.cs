namespace WFNutritionFitnessManagement1
{
    partial class frmActivityCalculator
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
            this.lstBoxPrimary = new System.Windows.Forms.ListBox();
            this.lstBoxActivity = new System.Windows.Forms.ListBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbHours = new System.Windows.Forms.ComboBox();
            this.cbMinutes = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblCaloriesBurned = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSearchActivity = new System.Windows.Forms.Button();
            this.tbSearchActivity = new System.Windows.Forms.TextBox();
            this.btnAddActivity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBoxPrimary
            // 
            this.lstBoxPrimary.FormattingEnabled = true;
            this.lstBoxPrimary.Items.AddRange(new object[] {
            "Personal Care",
            "Household Activities",
            "Caring for and Helping HH Members",
            "Caring for and Helping nonHH Members",
            "Education",
            "Consumer Purchases",
            "Professional and Personal Care Services",
            "HH Services",
            "Government Services and Civic Obligations",
            "Eating and Drinking",
            "Socializing, Relaxing and Leisure",
            "Sports, Exercise, and Recreation",
            "Attending Sporting/Recreational Events",
            "Religious and Spiritual Activities",
            "Volunteer Activities",
            "Telephone Calls"});
            this.lstBoxPrimary.Location = new System.Drawing.Point(13, 58);
            this.lstBoxPrimary.Name = "lstBoxPrimary";
            this.lstBoxPrimary.Size = new System.Drawing.Size(349, 160);
            this.lstBoxPrimary.TabIndex = 0;
            this.lstBoxPrimary.SelectedIndexChanged += new System.EventHandler(this.lstBoxPrimary_SelectedIndexChanged);
            // 
            // lstBoxActivity
            // 
            this.lstBoxActivity.FormattingEnabled = true;
            this.lstBoxActivity.Location = new System.Drawing.Point(368, 58);
            this.lstBoxActivity.Name = "lstBoxActivity";
            this.lstBoxActivity.Size = new System.Drawing.Size(335, 160);
            this.lstBoxActivity.TabIndex = 1;
            this.lstBoxActivity.SelectedIndexChanged += new System.EventHandler(this.lstBoxActivity_SelectedIndexChanged);
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(200, 243);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(77, 20);
            this.txtWeight.TabIndex = 4;
            this.txtWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWeight_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Choose Category:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(368, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Choose Activity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(197, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Enter Weight:";
            // 
            // cbHours
            // 
            this.cbHours.FormattingEnabled = true;
            this.cbHours.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cbHours.Location = new System.Drawing.Point(13, 243);
            this.cbHours.Name = "cbHours";
            this.cbHours.Size = new System.Drawing.Size(77, 21);
            this.cbHours.TabIndex = 2;
            this.cbHours.Text = "Hours:";
            // 
            // cbMinutes
            // 
            this.cbMinutes.FormattingEnabled = true;
            this.cbMinutes.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cbMinutes.Location = new System.Drawing.Point(107, 243);
            this.cbMinutes.Name = "cbMinutes";
            this.cbMinutes.Size = new System.Drawing.Size(79, 21);
            this.cbMinutes.TabIndex = 3;
            this.cbMinutes.Text = "Minutes:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Select Time Engaged in Activity:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Transparent;
            this.btnCalculate.BackgroundImage = global::WFNutritionFitnessManagement1.Properties.Resources.StartButton;
            this.btnCalculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalculate.FlatAppearance.BorderSize = 0;
            this.btnCalculate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Location = new System.Drawing.Point(298, 241);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(62, 23);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblCaloriesBurned
            // 
            this.lblCaloriesBurned.AutoSize = true;
            this.lblCaloriesBurned.BackColor = System.Drawing.Color.Transparent;
            this.lblCaloriesBurned.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaloriesBurned.Location = new System.Drawing.Point(569, 231);
            this.lblCaloriesBurned.Name = "lblCaloriesBurned";
            this.lblCaloriesBurned.Size = new System.Drawing.Size(71, 33);
            this.lblCaloriesBurned.TabIndex = 17;
            this.lblCaloriesBurned.Text = "0000";
            this.lblCaloriesBurned.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(370, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(204, 33);
            this.label9.TabIndex = 18;
            this.label9.Text = "Calories burned =";
            // 
            // btnSearchActivity
            // 
            this.btnSearchActivity.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchActivity.BackgroundImage = global::WFNutritionFitnessManagement1.Properties.Resources.SearchButton;
            this.btnSearchActivity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchActivity.FlatAppearance.BorderSize = 0;
            this.btnSearchActivity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSearchActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchActivity.Location = new System.Drawing.Point(633, 12);
            this.btnSearchActivity.Name = "btnSearchActivity";
            this.btnSearchActivity.Size = new System.Drawing.Size(62, 23);
            this.btnSearchActivity.TabIndex = 7;
            this.btnSearchActivity.UseVisualStyleBackColor = false;
            this.btnSearchActivity.Click += new System.EventHandler(this.btnSearchActivity_Click);
            // 
            // tbSearchActivity
            // 
            this.tbSearchActivity.Location = new System.Drawing.Point(403, 12);
            this.tbSearchActivity.Name = "tbSearchActivity";
            this.tbSearchActivity.Size = new System.Drawing.Size(222, 20);
            this.tbSearchActivity.TabIndex = 6;
            this.tbSearchActivity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearchActivity_KeyPress);
            // 
            // btnAddActivity
            // 
            this.btnAddActivity.Enabled = false;
            this.btnAddActivity.Location = new System.Drawing.Point(553, 267);
            this.btnAddActivity.Name = "btnAddActivity";
            this.btnAddActivity.Size = new System.Drawing.Size(150, 23);
            this.btnAddActivity.TabIndex = 19;
            this.btnAddActivity.Text = "Add to Daily Management";
            this.btnAddActivity.UseVisualStyleBackColor = true;
            this.btnAddActivity.Click += new System.EventHandler(this.btnAddActivity_Click);
            // 
            // frmActivityCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::WFNutritionFitnessManagement1.Properties.Resources._1200x600EarthToneslGradient;
            this.ClientSize = new System.Drawing.Size(715, 299);
            this.Controls.Add(this.btnAddActivity);
            this.Controls.Add(this.tbSearchActivity);
            this.Controls.Add(this.btnSearchActivity);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblCaloriesBurned);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbMinutes);
            this.Controls.Add(this.cbHours);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lstBoxActivity);
            this.Controls.Add(this.lstBoxPrimary);
            this.Name = "frmActivityCalculator";
            this.Text = "Activity Calculator";
            this.Load += new System.EventHandler(this.frmActivityCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxPrimary;
        private System.Windows.Forms.ListBox lstBoxActivity;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbHours;
        private System.Windows.Forms.ComboBox cbMinutes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblCaloriesBurned;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSearchActivity;
        private System.Windows.Forms.TextBox tbSearchActivity;
        private System.Windows.Forms.Button btnAddActivity;
    }
}