namespace NewbornApp
{
    partial class ChartsMenu
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.nappyButton = new System.Windows.Forms.Button();
            this.temperatureButton = new System.Windows.Forms.Button();
            this.growthButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(110, 48);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(67, 13);
            this.titleLabel.TabIndex = 9;
            this.titleLabel.Text = "Charts Menu";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(105, 294);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 8;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // nappyButton
            // 
            this.nappyButton.Location = new System.Drawing.Point(53, 217);
            this.nappyButton.Name = "nappyButton";
            this.nappyButton.Size = new System.Drawing.Size(181, 52);
            this.nappyButton.TabIndex = 7;
            this.nappyButton.Text = "View Nappy Chart";
            this.nappyButton.UseVisualStyleBackColor = true;
            // 
            // temperatureButton
            // 
            this.temperatureButton.Location = new System.Drawing.Point(53, 159);
            this.temperatureButton.Name = "temperatureButton";
            this.temperatureButton.Size = new System.Drawing.Size(181, 52);
            this.temperatureButton.TabIndex = 6;
            this.temperatureButton.Text = "View Temperature Chart";
            this.temperatureButton.UseVisualStyleBackColor = true;
            // 
            // growthButton
            // 
            this.growthButton.Location = new System.Drawing.Point(53, 101);
            this.growthButton.Name = "growthButton";
            this.growthButton.Size = new System.Drawing.Size(181, 52);
            this.growthButton.TabIndex = 5;
            this.growthButton.Text = "View Growth Chart";
            this.growthButton.UseVisualStyleBackColor = true;
            this.growthButton.Click += new System.EventHandler(this.growthButton_Click);
            // 
            // ChartsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 371);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.nappyButton);
            this.Controls.Add(this.temperatureButton);
            this.Controls.Add(this.growthButton);
            this.Name = "ChartsMenu";
            this.Text = "Charts Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button nappyButton;
        private System.Windows.Forms.Button temperatureButton;
        private System.Windows.Forms.Button growthButton;
    }
}