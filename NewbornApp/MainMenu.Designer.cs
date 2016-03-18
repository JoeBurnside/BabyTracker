namespace NewbornApp
{
    partial class MainMenu
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
            this.dailyButton = new System.Windows.Forms.Button();
            this.weeklyButton = new System.Windows.Forms.Button();
            this.chartButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dailyButton
            // 
            this.dailyButton.Location = new System.Drawing.Point(50, 96);
            this.dailyButton.Name = "dailyButton";
            this.dailyButton.Size = new System.Drawing.Size(181, 52);
            this.dailyButton.TabIndex = 0;
            this.dailyButton.Text = "Enter Daily Checks";
            this.dailyButton.UseVisualStyleBackColor = true;
            this.dailyButton.Click += new System.EventHandler(this.dailyButton_Click);
            // 
            // weeklyButton
            // 
            this.weeklyButton.Location = new System.Drawing.Point(50, 154);
            this.weeklyButton.Name = "weeklyButton";
            this.weeklyButton.Size = new System.Drawing.Size(181, 52);
            this.weeklyButton.TabIndex = 1;
            this.weeklyButton.Text = "Enter Weekly Checks";
            this.weeklyButton.UseVisualStyleBackColor = true;
            this.weeklyButton.Click += new System.EventHandler(this.weeklyButton_Click);
            // 
            // chartButton
            // 
            this.chartButton.Location = new System.Drawing.Point(50, 212);
            this.chartButton.Name = "chartButton";
            this.chartButton.Size = new System.Drawing.Size(181, 52);
            this.chartButton.TabIndex = 2;
            this.chartButton.Text = "View Charts";
            this.chartButton.UseVisualStyleBackColor = true;
            this.chartButton.Click += new System.EventHandler(this.chartButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(102, 289);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(47, 49);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(184, 26);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Welcome to the Newborn Health App\r\nMain Menu";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(284, 371);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.chartButton);
            this.Controls.Add(this.weeklyButton);
            this.Controls.Add(this.dailyButton);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dailyButton;
        private System.Windows.Forms.Button weeklyButton;
        private System.Windows.Forms.Button chartButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label titleLabel;
    }
}

