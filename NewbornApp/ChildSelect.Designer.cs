namespace NewbornApp
{
    partial class ChildSelect
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
            this.newChildButton = new System.Windows.Forms.Button();
            this.selectButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.childListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // newChildButton
            // 
            this.newChildButton.Location = new System.Drawing.Point(84, 240);
            this.newChildButton.Name = "newChildButton";
            this.newChildButton.Size = new System.Drawing.Size(111, 38);
            this.newChildButton.TabIndex = 0;
            this.newChildButton.Text = "Add New Child";
            this.newChildButton.UseVisualStyleBackColor = true;
            this.newChildButton.Click += new System.EventHandler(this.newChildButton_Click);
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(84, 184);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(111, 37);
            this.selectButton.TabIndex = 1;
            this.selectButton.Text = "Select Child";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(102, 306);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(71, 24);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(142, 26);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "New-born Health Application\r\nSelect child from the list";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // childListBox
            // 
            this.childListBox.FormattingEnabled = true;
            this.childListBox.Location = new System.Drawing.Point(28, 83);
            this.childListBox.Name = "childListBox";
            this.childListBox.Size = new System.Drawing.Size(228, 95);
            this.childListBox.TabIndex = 4;
            // 
            // ChildSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 371);
            this.Controls.Add(this.childListBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.newChildButton);
            this.Name = "ChildSelect";
            this.Text = "Child Select";
            this.Load += new System.EventHandler(this.ChildSelect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newChildButton;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ListBox childListBox;
    }
}