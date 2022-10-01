namespace Galaxy_Conqueror
{
    partial class Form1
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
            this.txtEnergy = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.Label();
            this.txtHealth = new System.Windows.Forms.Label();
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.energyBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // txtEnergy
            // 
            this.txtEnergy.AutoSize = true;
            this.txtEnergy.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnergy.ForeColor = System.Drawing.SystemColors.Control;
            this.txtEnergy.Location = new System.Drawing.Point(34, 26);
            this.txtEnergy.Name = "txtEnergy";
            this.txtEnergy.Size = new System.Drawing.Size(82, 24);
            this.txtEnergy.TabIndex = 1;
            this.txtEnergy.Text = "Energy:";
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.ForeColor = System.Drawing.SystemColors.Control;
            this.txtScore.Location = new System.Drawing.Point(539, 26);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(65, 24);
            this.txtScore.TabIndex = 2;
            this.txtScore.Text = "Score:";
            // 
            // txtHealth
            // 
            this.txtHealth.AutoSize = true;
            this.txtHealth.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHealth.ForeColor = System.Drawing.SystemColors.Control;
            this.txtHealth.Location = new System.Drawing.Point(948, 26);
            this.txtHealth.Name = "txtHealth";
            this.txtHealth.Size = new System.Drawing.Size(82, 24);
            this.txtHealth.TabIndex = 3;
            this.txtHealth.Text = "Health:";
            // 
            // healthBar
            // 
            this.healthBar.Location = new System.Drawing.Point(1051, 26);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(190, 23);
            this.healthBar.TabIndex = 4;
            this.healthBar.Value = 100;
            // 
            // energyBar
            // 
            this.energyBar.Location = new System.Drawing.Point(133, 27);
            this.energyBar.Name = "energyBar";
            this.energyBar.Size = new System.Drawing.Size(190, 23);
            this.energyBar.TabIndex = 5;
            this.energyBar.Value = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.energyBar);
            this.Controls.Add(this.healthBar);
            this.Controls.Add(this.txtHealth);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtEnergy);
            this.Name = "Form1";
            this.Text = "Galaxy Conqueror";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtEnergy;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label txtHealth;
        private System.Windows.Forms.ProgressBar healthBar;
        private System.Windows.Forms.ProgressBar energyBar;
    }
}

