namespace NewbornApp
{
    partial class DailyChecks
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
            this.wetLabel = new System.Windows.Forms.Label();
            this.dirtyLabel = new System.Windows.Forms.Label();
            this.temperatureLabel = new System.Windows.Forms.Label();
            this.centigradeLabel = new System.Windows.Forms.Label();
            this.farenheitLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.wetTextBox = new System.Windows.Forms.TextBox();
            this.dirtyTextBox = new System.Windows.Forms.TextBox();
            this.centigradeTextBox = new System.Windows.Forms.TextBox();
            this.farenheitTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(91, 45);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(97, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Enter Daily Checks";
            // 
            // wetLabel
            // 
            this.wetLabel.AutoSize = true;
            this.wetLabel.Location = new System.Drawing.Point(15, 117);
            this.wetLabel.Name = "wetLabel";
            this.wetLabel.Size = new System.Drawing.Size(124, 13);
            this.wetLabel.TabIndex = 1;
            this.wetLabel.Text = "Number of Wet Nappies:";
            // 
            // dirtyLabel
            // 
            this.dirtyLabel.AutoSize = true;
            this.dirtyLabel.Location = new System.Drawing.Point(14, 143);
            this.dirtyLabel.Name = "dirtyLabel";
            this.dirtyLabel.Size = new System.Drawing.Size(125, 13);
            this.dirtyLabel.TabIndex = 2;
            this.dirtyLabel.Text = "Number of Dirty Nappies:";
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.Location = new System.Drawing.Point(36, 190);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(103, 13);
            this.temperatureLabel.TabIndex = 3;
            this.temperatureLabel.Text = "Child\'s Temperature:";
            // 
            // centigradeLabel
            // 
            this.centigradeLabel.AutoSize = true;
            this.centigradeLabel.Location = new System.Drawing.Point(205, 190);
            this.centigradeLabel.Name = "centigradeLabel";
            this.centigradeLabel.Size = new System.Drawing.Size(58, 13);
            this.centigradeLabel.TabIndex = 4;
            this.centigradeLabel.Text = "Centigrade";
            // 
            // farenheitLabel
            // 
            this.farenheitLabel.AutoSize = true;
            this.farenheitLabel.Location = new System.Drawing.Point(205, 216);
            this.farenheitLabel.Name = "farenheitLabel";
            this.farenheitLabel.Size = new System.Drawing.Size(51, 13);
            this.farenheitLabel.TabIndex = 5;
            this.farenheitLabel.Text = "Farenheit";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(13, 309);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(103, 309);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(193, 309);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 8;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // wetTextBox
            // 
            this.wetTextBox.Location = new System.Drawing.Point(145, 114);
            this.wetTextBox.Name = "wetTextBox";
            this.wetTextBox.Size = new System.Drawing.Size(54, 20);
            this.wetTextBox.TabIndex = 9;
            // 
            // dirtyTextBox
            // 
            this.dirtyTextBox.Location = new System.Drawing.Point(145, 140);
            this.dirtyTextBox.Name = "dirtyTextBox";
            this.dirtyTextBox.Size = new System.Drawing.Size(54, 20);
            this.dirtyTextBox.TabIndex = 10;
            // 
            // centigradeTextBox
            // 
            this.centigradeTextBox.Location = new System.Drawing.Point(145, 187);
            this.centigradeTextBox.Name = "centigradeTextBox";
            this.centigradeTextBox.Size = new System.Drawing.Size(54, 20);
            this.centigradeTextBox.TabIndex = 11;
            this.centigradeTextBox.Leave += new System.EventHandler(this.centigradeTextBox_TextChanged);
            // 
            // farenheitTextBox
            // 
            this.farenheitTextBox.Location = new System.Drawing.Point(145, 213);
            this.farenheitTextBox.Name = "farenheitTextBox";
            this.farenheitTextBox.Size = new System.Drawing.Size(54, 20);
            this.farenheitTextBox.TabIndex = 12;
            this.farenheitTextBox.Leave += new System.EventHandler(this.farenheitTextBox_TextChanged);
            // 
            // DailyChecks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 371);
            this.Controls.Add(this.farenheitTextBox);
            this.Controls.Add(this.centigradeTextBox);
            this.Controls.Add(this.dirtyTextBox);
            this.Controls.Add(this.wetTextBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.farenheitLabel);
            this.Controls.Add(this.centigradeLabel);
            this.Controls.Add(this.temperatureLabel);
            this.Controls.Add(this.dirtyLabel);
            this.Controls.Add(this.wetLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "DailyChecks";
            this.Text = "Daily Checks";
            this.Load += new System.EventHandler(this.DailyChecks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label wetLabel;
        private System.Windows.Forms.Label dirtyLabel;
        private System.Windows.Forms.Label temperatureLabel;
        private System.Windows.Forms.Label centigradeLabel;
        private System.Windows.Forms.Label farenheitLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox wetTextBox;
        private System.Windows.Forms.TextBox dirtyTextBox;
        private System.Windows.Forms.TextBox centigradeTextBox;
        private System.Windows.Forms.TextBox farenheitTextBox;
    }
}