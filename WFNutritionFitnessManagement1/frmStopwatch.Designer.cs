namespace WFNutritionFitnessManagement1
{
    partial class frmStopwatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStopwatch));
            this.lblKTimer1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStopwatchStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnKT1Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKTimer1
            // 
            this.lblKTimer1.AutoSize = true;
            this.lblKTimer1.BackColor = System.Drawing.Color.Black;
            this.lblKTimer1.Font = new System.Drawing.Font("Calibri", 44.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKTimer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(202)))));
            this.lblKTimer1.Location = new System.Drawing.Point(18, 18);
            this.lblKTimer1.Name = "lblKTimer1";
            this.lblKTimer1.Size = new System.Drawing.Size(242, 72);
            this.lblKTimer1.TabIndex = 4;
            this.lblKTimer1.Text = "00:00:00";
            this.lblKTimer1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.BackgroundImage = global::WFNutritionFitnessManagement1.Properties.Resources.ResetButton;
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(110, 106);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(62, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStopwatchStart
            // 
            this.btnStopwatchStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStopwatchStart.BackgroundImage = global::WFNutritionFitnessManagement1.Properties.Resources.StartButton;
            this.btnStopwatchStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStopwatchStart.FlatAppearance.BorderSize = 0;
            this.btnStopwatchStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnStopwatchStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopwatchStart.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopwatchStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnStopwatchStart.Location = new System.Drawing.Point(198, 106);
            this.btnStopwatchStart.Name = "btnStopwatchStart";
            this.btnStopwatchStart.Size = new System.Drawing.Size(62, 23);
            this.btnStopwatchStart.TabIndex = 0;
            this.btnStopwatchStart.UseVisualStyleBackColor = false;
            this.btnStopwatchStart.Click += new System.EventHandler(this.btnStopwatchStart_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnKT1Reset
            // 
            this.btnKT1Reset.BackColor = System.Drawing.Color.Transparent;
            this.btnKT1Reset.BackgroundImage = global::WFNutritionFitnessManagement1.Properties.Resources.PauseButton;
            this.btnKT1Reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKT1Reset.FlatAppearance.BorderSize = 0;
            this.btnKT1Reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnKT1Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKT1Reset.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKT1Reset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnKT1Reset.Location = new System.Drawing.Point(21, 106);
            this.btnKT1Reset.Name = "btnKT1Reset";
            this.btnKT1Reset.Size = new System.Drawing.Size(62, 23);
            this.btnKT1Reset.TabIndex = 7;
            this.btnKT1Reset.UseVisualStyleBackColor = false;
            this.btnKT1Reset.Click += new System.EventHandler(this.btnKT1Reset_Click);
            // 
            // frmStopwatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WFNutritionFitnessManagement1.Properties.Resources._1200x600EarthToneslGradient;
            this.ClientSize = new System.Drawing.Size(272, 153);
            this.Controls.Add(this.btnKT1Reset);
            this.Controls.Add(this.lblKTimer1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStopwatchStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmStopwatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stopwatch";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmStopwatch_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStopwatchStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblKTimer1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnKT1Reset;
    }
}