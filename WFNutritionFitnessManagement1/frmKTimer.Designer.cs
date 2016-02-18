namespace WFNutritionFitnessManagement1
{
    partial class frmKTimer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKTimer));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbKTimer1Title = new System.Windows.Forms.TextBox();
            this.btnKT1Start = new System.Windows.Forms.Button();
            this.lblKTimer1 = new System.Windows.Forms.Label();
            this.btnKT1Reset = new System.Windows.Forms.Button();
            this.cmbKT1Hour = new System.Windows.Forms.ComboBox();
            this.btnKT1PauseResume = new System.Windows.Forms.Button();
            this.cmbKT1Minute = new System.Windows.Forms.ComboBox();
            this.cmbKT1Second = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(166, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 14);
            this.label3.TabIndex = 10;
            this.label3.Text = "Seconds:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 9;
            this.label2.Text = "Minutes:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "Hours:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbKTimer1Title
            // 
            this.tbKTimer1Title.BackColor = System.Drawing.Color.Black;
            this.tbKTimer1Title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbKTimer1Title.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKTimer1Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(202)))));
            this.tbKTimer1Title.Location = new System.Drawing.Point(27, 14);
            this.tbKTimer1Title.Name = "tbKTimer1Title";
            this.tbKTimer1Title.Size = new System.Drawing.Size(198, 30);
            this.tbKTimer1Title.TabIndex = 4;
            this.tbKTimer1Title.Text = "Kitchen Timer";
            this.tbKTimer1Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnKT1Start
            // 
            this.btnKT1Start.BackColor = System.Drawing.Color.Transparent;
            this.btnKT1Start.BackgroundImage = global::WFNutritionFitnessManagement1.Properties.Resources.StartButton;
            this.btnKT1Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKT1Start.FlatAppearance.BorderSize = 0;
            this.btnKT1Start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnKT1Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKT1Start.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKT1Start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnKT1Start.Location = new System.Drawing.Point(163, 149);
            this.btnKT1Start.Name = "btnKT1Start";
            this.btnKT1Start.Size = new System.Drawing.Size(62, 23);
            this.btnKT1Start.TabIndex = 7;
            this.btnKT1Start.UseVisualStyleBackColor = false;
            this.btnKT1Start.Click += new System.EventHandler(this.btnKT1Start_Click);
            // 
            // lblKTimer1
            // 
            this.lblKTimer1.AutoSize = true;
            this.lblKTimer1.BackColor = System.Drawing.Color.Black;
            this.lblKTimer1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKTimer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(202)))));
            this.lblKTimer1.Location = new System.Drawing.Point(-2, 0);
            this.lblKTimer1.MaximumSize = new System.Drawing.Size(200, 53);
            this.lblKTimer1.MinimumSize = new System.Drawing.Size(200, 53);
            this.lblKTimer1.Name = "lblKTimer1";
            this.lblKTimer1.Size = new System.Drawing.Size(200, 53);
            this.lblKTimer1.TabIndex = 0;
            this.lblKTimer1.Text = "00:00:00";
            this.lblKTimer1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnKT1Reset
            // 
            this.btnKT1Reset.BackColor = System.Drawing.Color.Transparent;
            this.btnKT1Reset.BackgroundImage = global::WFNutritionFitnessManagement1.Properties.Resources.ResetButton;
            this.btnKT1Reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKT1Reset.FlatAppearance.BorderSize = 0;
            this.btnKT1Reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnKT1Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKT1Reset.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKT1Reset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnKT1Reset.Location = new System.Drawing.Point(94, 149);
            this.btnKT1Reset.Name = "btnKT1Reset";
            this.btnKT1Reset.Size = new System.Drawing.Size(62, 23);
            this.btnKT1Reset.TabIndex = 6;
            this.btnKT1Reset.UseVisualStyleBackColor = false;
            this.btnKT1Reset.Click += new System.EventHandler(this.btnKT1Reset_Click);
            // 
            // cmbKT1Hour
            // 
            this.cmbKT1Hour.FormattingEnabled = true;
            this.cmbKT1Hour.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbKT1Hour.Location = new System.Drawing.Point(27, 122);
            this.cmbKT1Hour.Name = "cmbKT1Hour";
            this.cmbKT1Hour.Size = new System.Drawing.Size(62, 21);
            this.cmbKT1Hour.TabIndex = 1;
            this.cmbKT1Hour.Text = "0";
            // 
            // btnKT1PauseResume
            // 
            this.btnKT1PauseResume.BackColor = System.Drawing.Color.Transparent;
            this.btnKT1PauseResume.BackgroundImage = global::WFNutritionFitnessManagement1.Properties.Resources.PauseButton;
            this.btnKT1PauseResume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKT1PauseResume.FlatAppearance.BorderSize = 0;
            this.btnKT1PauseResume.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnKT1PauseResume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKT1PauseResume.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKT1PauseResume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnKT1PauseResume.Location = new System.Drawing.Point(25, 149);
            this.btnKT1PauseResume.Name = "btnKT1PauseResume";
            this.btnKT1PauseResume.Size = new System.Drawing.Size(62, 23);
            this.btnKT1PauseResume.TabIndex = 5;
            this.btnKT1PauseResume.UseVisualStyleBackColor = false;
            this.btnKT1PauseResume.Click += new System.EventHandler(this.btnKT1PauseResume_Click);
            // 
            // cmbKT1Minute
            // 
            this.cmbKT1Minute.FormattingEnabled = true;
            this.cmbKT1Minute.Items.AddRange(new object[] {
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
            this.cmbKT1Minute.Location = new System.Drawing.Point(94, 122);
            this.cmbKT1Minute.Name = "cmbKT1Minute";
            this.cmbKT1Minute.Size = new System.Drawing.Size(62, 21);
            this.cmbKT1Minute.TabIndex = 2;
            this.cmbKT1Minute.Text = "0";
            // 
            // cmbKT1Second
            // 
            this.cmbKT1Second.FormattingEnabled = true;
            this.cmbKT1Second.Items.AddRange(new object[] {
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
            this.cmbKT1Second.Location = new System.Drawing.Point(163, 122);
            this.cmbKT1Second.Name = "cmbKT1Second";
            this.cmbKT1Second.Size = new System.Drawing.Size(62, 21);
            this.cmbKT1Second.TabIndex = 3;
            this.cmbKT1Second.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lblKTimer1);
            this.panel1.Location = new System.Drawing.Point(27, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 60);
            this.panel1.TabIndex = 11;
            // 
            // frmKTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WFNutritionFitnessManagement1.Properties.Resources._1200x600EarthToneslGradient;
            this.ClientSize = new System.Drawing.Size(249, 187);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbKTimer1Title);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbKT1Second);
            this.Controls.Add(this.cmbKT1Minute);
            this.Controls.Add(this.btnKT1Start);
            this.Controls.Add(this.btnKT1PauseResume);
            this.Controls.Add(this.cmbKT1Hour);
            this.Controls.Add(this.btnKT1Reset);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmKTimer";
            this.Text = "frmKTimer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmKTimer_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbKTimer1Title;
        private System.Windows.Forms.Button btnKT1Start;
        private System.Windows.Forms.Label lblKTimer1;
        private System.Windows.Forms.Button btnKT1Reset;
        private System.Windows.Forms.ComboBox cmbKT1Hour;
        private System.Windows.Forms.Button btnKT1PauseResume;
        private System.Windows.Forms.ComboBox cmbKT1Minute;
        private System.Windows.Forms.ComboBox cmbKT1Second;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}