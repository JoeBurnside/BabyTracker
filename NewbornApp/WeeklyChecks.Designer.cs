namespace NewbornApp
{
    partial class WeeklyChecks
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
            this.clearButton = new System.Windows.Forms.Button();
            this.inchesLabel = new System.Windows.Forms.Label();
            this.centimetresLabel = new System.Windows.Forms.Label();
            this.ouncesLabel = new System.Windows.Forms.Label();
            this.poundsLabel = new System.Windows.Forms.Label();
            this.kilosLabel = new System.Windows.Forms.Label();
            this.headLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.inchesTextBox = new System.Windows.Forms.TextBox();
            this.centimetresTextBox = new System.Windows.Forms.TextBox();
            this.poundsTextBox = new System.Windows.Forms.TextBox();
            this.ouncesTextBox = new System.Windows.Forms.TextBox();
            this.kilogramsTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(103, 309);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 36;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // inchesLabel
            // 
            this.inchesLabel.AutoSize = true;
            this.inchesLabel.Location = new System.Drawing.Point(221, 208);
            this.inchesLabel.Name = "inchesLabel";
            this.inchesLabel.Size = new System.Drawing.Size(39, 13);
            this.inchesLabel.TabIndex = 35;
            this.inchesLabel.Text = "Inches";
            // 
            // centimetresLabel
            // 
            this.centimetresLabel.AutoSize = true;
            this.centimetresLabel.Location = new System.Drawing.Point(221, 182);
            this.centimetresLabel.Name = "centimetresLabel";
            this.centimetresLabel.Size = new System.Drawing.Size(21, 13);
            this.centimetresLabel.TabIndex = 34;
            this.centimetresLabel.Text = "cm";
            // 
            // ouncesLabel
            // 
            this.ouncesLabel.AutoSize = true;
            this.ouncesLabel.Location = new System.Drawing.Point(249, 146);
            this.ouncesLabel.Name = "ouncesLabel";
            this.ouncesLabel.Size = new System.Drawing.Size(18, 13);
            this.ouncesLabel.TabIndex = 33;
            this.ouncesLabel.Text = "oz";
            // 
            // poundsLabel
            // 
            this.poundsLabel.AutoSize = true;
            this.poundsLabel.Location = new System.Drawing.Point(171, 146);
            this.poundsLabel.Name = "poundsLabel";
            this.poundsLabel.Size = new System.Drawing.Size(15, 13);
            this.poundsLabel.TabIndex = 32;
            this.poundsLabel.Text = "lb";
            // 
            // kilosLabel
            // 
            this.kilosLabel.AutoSize = true;
            this.kilosLabel.Location = new System.Drawing.Point(221, 120);
            this.kilosLabel.Name = "kilosLabel";
            this.kilosLabel.Size = new System.Drawing.Size(19, 13);
            this.kilosLabel.TabIndex = 31;
            this.kilosLabel.Text = "kg";
            // 
            // headLabel
            // 
            this.headLabel.AutoSize = true;
            this.headLabel.Location = new System.Drawing.Point(7, 182);
            this.headLabel.Name = "headLabel";
            this.headLabel.Size = new System.Drawing.Size(107, 13);
            this.headLabel.TabIndex = 30;
            this.headLabel.Text = "Head Circumference:";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(65, 120);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(44, 13);
            this.weightLabel.TabIndex = 29;
            this.weightLabel.Text = "Weight:";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(193, 309);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 28;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(13, 309);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 27;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // inchesTextBox
            // 
            this.inchesTextBox.Location = new System.Drawing.Point(115, 205);
            this.inchesTextBox.Name = "inchesTextBox";
            this.inchesTextBox.Size = new System.Drawing.Size(100, 20);
            this.inchesTextBox.TabIndex = 26;
            this.inchesTextBox.Leave += new System.EventHandler(this.inchesTextBox_TextChanged);
            // 
            // centimetresTextBox
            // 
            this.centimetresTextBox.Location = new System.Drawing.Point(115, 179);
            this.centimetresTextBox.Name = "centimetresTextBox";
            this.centimetresTextBox.Size = new System.Drawing.Size(100, 20);
            this.centimetresTextBox.TabIndex = 25;
            this.centimetresTextBox.Leave += new System.EventHandler(this.centimetresTextBox_TextChanged);
            // 
            // poundsTextBox
            // 
            this.poundsTextBox.Location = new System.Drawing.Point(115, 143);
            this.poundsTextBox.Name = "poundsTextBox";
            this.poundsTextBox.Size = new System.Drawing.Size(50, 20);
            this.poundsTextBox.TabIndex = 24;
            this.poundsTextBox.Leave += new System.EventHandler(this.poundsTextBox_TextChanged);
            // 
            // ouncesTextBox
            // 
            this.ouncesTextBox.Location = new System.Drawing.Point(193, 143);
            this.ouncesTextBox.Name = "ouncesTextBox";
            this.ouncesTextBox.Size = new System.Drawing.Size(50, 20);
            this.ouncesTextBox.TabIndex = 23;
            this.ouncesTextBox.Leave += new System.EventHandler(this.ouncesTextBox_TextChanged);
            // 
            // kilogramsTextBox
            // 
            this.kilogramsTextBox.Location = new System.Drawing.Point(115, 117);
            this.kilogramsTextBox.Name = "kilogramsTextBox";
            this.kilogramsTextBox.Size = new System.Drawing.Size(100, 20);
            this.kilogramsTextBox.TabIndex = 22;
            this.kilogramsTextBox.Leave += new System.EventHandler(this.kilogramsTextBox_TextChanged);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(100, 47);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(82, 13);
            this.titleLabel.TabIndex = 37;
            this.titleLabel.Text = "Weekly Checks";
            // 
            // WeeklyChecks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 371);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.inchesLabel);
            this.Controls.Add(this.centimetresLabel);
            this.Controls.Add(this.ouncesLabel);
            this.Controls.Add(this.poundsLabel);
            this.Controls.Add(this.kilosLabel);
            this.Controls.Add(this.headLabel);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.inchesTextBox);
            this.Controls.Add(this.centimetresTextBox);
            this.Controls.Add(this.poundsTextBox);
            this.Controls.Add(this.ouncesTextBox);
            this.Controls.Add(this.kilogramsTextBox);
            this.Name = "WeeklyChecks";
            this.Text = "Weekly Checks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label inchesLabel;
        private System.Windows.Forms.Label centimetresLabel;
        private System.Windows.Forms.Label ouncesLabel;
        private System.Windows.Forms.Label poundsLabel;
        private System.Windows.Forms.Label kilosLabel;
        private System.Windows.Forms.Label headLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox inchesTextBox;
        private System.Windows.Forms.TextBox centimetresTextBox;
        private System.Windows.Forms.TextBox poundsTextBox;
        private System.Windows.Forms.TextBox ouncesTextBox;
        private System.Windows.Forms.TextBox kilogramsTextBox;
        private System.Windows.Forms.Label titleLabel;
    }
}