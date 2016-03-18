namespace NewbornApp
{
    partial class ChildDetails
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
            this.dobPicker = new System.Windows.Forms.DateTimePicker();
            this.kilogramsTextBox = new System.Windows.Forms.TextBox();
            this.ouncesTextBox = new System.Windows.Forms.TextBox();
            this.poundsTextBox = new System.Windows.Forms.TextBox();
            this.centimetresTextBox = new System.Windows.Forms.TextBox();
            this.inchesTextBox = new System.Windows.Forms.TextBox();
            this.motherNameTextBox = new System.Windows.Forms.TextBox();
            this.childNameTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.childNameLabel = new System.Windows.Forms.Label();
            this.motherNameLabel = new System.Windows.Forms.Label();
            this.birthDateLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.headLabel = new System.Windows.Forms.Label();
            this.kilosLabel = new System.Windows.Forms.Label();
            this.poundsLabel = new System.Windows.Forms.Label();
            this.ouncesLabel = new System.Windows.Forms.Label();
            this.centimetresLabel = new System.Windows.Forms.Label();
            this.inchesLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.bothRadioButton = new System.Windows.Forms.RadioButton();
            this.breastRadioButton = new System.Windows.Forms.RadioButton();
            this.bottleRadioButton = new System.Windows.Forms.RadioButton();
            this.feedingLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.genderDropdown = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dobPicker
            // 
            this.dobPicker.Location = new System.Drawing.Point(117, 116);
            this.dobPicker.Name = "dobPicker";
            this.dobPicker.Size = new System.Drawing.Size(156, 20);
            this.dobPicker.TabIndex = 0;
            // 
            // kilogramsTextBox
            // 
            this.kilogramsTextBox.Location = new System.Drawing.Point(117, 151);
            this.kilogramsTextBox.Name = "kilogramsTextBox";
            this.kilogramsTextBox.Size = new System.Drawing.Size(100, 20);
            this.kilogramsTextBox.TabIndex = 1;
            this.kilogramsTextBox.Leave += new System.EventHandler(this.kilogramsTextBox_TextChanged);
            // 
            // ouncesTextBox
            // 
            this.ouncesTextBox.Location = new System.Drawing.Point(195, 177);
            this.ouncesTextBox.Name = "ouncesTextBox";
            this.ouncesTextBox.Size = new System.Drawing.Size(50, 20);
            this.ouncesTextBox.TabIndex = 2;
            this.ouncesTextBox.Leave += new System.EventHandler(this.ouncesTextBox_TextChanged);
            // 
            // poundsTextBox
            // 
            this.poundsTextBox.Location = new System.Drawing.Point(117, 177);
            this.poundsTextBox.Name = "poundsTextBox";
            this.poundsTextBox.Size = new System.Drawing.Size(50, 20);
            this.poundsTextBox.TabIndex = 3;
            this.poundsTextBox.Leave += new System.EventHandler(this.poundsTextBox_TextChanged);
            // 
            // centimetresTextBox
            // 
            this.centimetresTextBox.Location = new System.Drawing.Point(117, 213);
            this.centimetresTextBox.Name = "centimetresTextBox";
            this.centimetresTextBox.Size = new System.Drawing.Size(100, 20);
            this.centimetresTextBox.TabIndex = 4;
            this.centimetresTextBox.Leave += new System.EventHandler(this.centimetresTextBox_TextChanged);
            // 
            // inchesTextBox
            // 
            this.inchesTextBox.Location = new System.Drawing.Point(117, 239);
            this.inchesTextBox.Name = "inchesTextBox";
            this.inchesTextBox.Size = new System.Drawing.Size(100, 20);
            this.inchesTextBox.TabIndex = 5;
            this.inchesTextBox.Leave += new System.EventHandler(this.inchesTextBox_TextChanged);
            // 
            // motherNameTextBox
            // 
            this.motherNameTextBox.Location = new System.Drawing.Point(117, 63);
            this.motherNameTextBox.Name = "motherNameTextBox";
            this.motherNameTextBox.Size = new System.Drawing.Size(156, 20);
            this.motherNameTextBox.TabIndex = 6;
            // 
            // childNameTextBox
            // 
            this.childNameTextBox.Location = new System.Drawing.Point(117, 37);
            this.childNameTextBox.Name = "childNameTextBox";
            this.childNameTextBox.Size = new System.Drawing.Size(156, 20);
            this.childNameTextBox.TabIndex = 7;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(13, 309);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(193, 309);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 9;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(91, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(100, 13);
            this.titleLabel.TabIndex = 10;
            this.titleLabel.Text = "Enter Child\'s Details";
            // 
            // childNameLabel
            // 
            this.childNameLabel.AutoSize = true;
            this.childNameLabel.Location = new System.Drawing.Point(23, 40);
            this.childNameLabel.Name = "childNameLabel";
            this.childNameLabel.Size = new System.Drawing.Size(93, 13);
            this.childNameLabel.TabIndex = 11;
            this.childNameLabel.Text = "Child\'s First Name:";
            // 
            // motherNameLabel
            // 
            this.motherNameLabel.AutoSize = true;
            this.motherNameLabel.Location = new System.Drawing.Point(13, 66);
            this.motherNameLabel.Name = "motherNameLabel";
            this.motherNameLabel.Size = new System.Drawing.Size(103, 13);
            this.motherNameLabel.TabIndex = 12;
            this.motherNameLabel.Text = "Mother\'s First Name:";
            // 
            // birthDateLabel
            // 
            this.birthDateLabel.AutoSize = true;
            this.birthDateLabel.Location = new System.Drawing.Point(26, 118);
            this.birthDateLabel.Name = "birthDateLabel";
            this.birthDateLabel.Size = new System.Drawing.Size(90, 13);
            this.birthDateLabel.TabIndex = 13;
            this.birthDateLabel.Text = "Child\'s Birth Date:";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(48, 154);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(68, 13);
            this.weightLabel.TabIndex = 14;
            this.weightLabel.Text = "Birth Weight:";
            // 
            // headLabel
            // 
            this.headLabel.AutoSize = true;
            this.headLabel.Location = new System.Drawing.Point(9, 216);
            this.headLabel.Name = "headLabel";
            this.headLabel.Size = new System.Drawing.Size(107, 13);
            this.headLabel.TabIndex = 15;
            this.headLabel.Text = "Head Circumference:";
            // 
            // kilosLabel
            // 
            this.kilosLabel.AutoSize = true;
            this.kilosLabel.Location = new System.Drawing.Point(223, 154);
            this.kilosLabel.Name = "kilosLabel";
            this.kilosLabel.Size = new System.Drawing.Size(19, 13);
            this.kilosLabel.TabIndex = 16;
            this.kilosLabel.Text = "kg";
            // 
            // poundsLabel
            // 
            this.poundsLabel.AutoSize = true;
            this.poundsLabel.Location = new System.Drawing.Point(173, 180);
            this.poundsLabel.Name = "poundsLabel";
            this.poundsLabel.Size = new System.Drawing.Size(15, 13);
            this.poundsLabel.TabIndex = 17;
            this.poundsLabel.Text = "lb";
            // 
            // ouncesLabel
            // 
            this.ouncesLabel.AutoSize = true;
            this.ouncesLabel.Location = new System.Drawing.Point(251, 180);
            this.ouncesLabel.Name = "ouncesLabel";
            this.ouncesLabel.Size = new System.Drawing.Size(18, 13);
            this.ouncesLabel.TabIndex = 18;
            this.ouncesLabel.Text = "oz";
            // 
            // centimetresLabel
            // 
            this.centimetresLabel.AutoSize = true;
            this.centimetresLabel.Location = new System.Drawing.Point(223, 216);
            this.centimetresLabel.Name = "centimetresLabel";
            this.centimetresLabel.Size = new System.Drawing.Size(21, 13);
            this.centimetresLabel.TabIndex = 19;
            this.centimetresLabel.Text = "cm";
            // 
            // inchesLabel
            // 
            this.inchesLabel.AutoSize = true;
            this.inchesLabel.Location = new System.Drawing.Point(223, 242);
            this.inchesLabel.Name = "inchesLabel";
            this.inchesLabel.Size = new System.Drawing.Size(39, 13);
            this.inchesLabel.TabIndex = 20;
            this.inchesLabel.Text = "Inches";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(103, 309);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 21;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // bothRadioButton
            // 
            this.bothRadioButton.AutoSize = true;
            this.bothRadioButton.Location = new System.Drawing.Point(201, 287);
            this.bothRadioButton.Name = "bothRadioButton";
            this.bothRadioButton.Size = new System.Drawing.Size(47, 17);
            this.bothRadioButton.TabIndex = 22;
            this.bothRadioButton.TabStop = true;
            this.bothRadioButton.Text = "Both";
            this.bothRadioButton.UseVisualStyleBackColor = true;
            // 
            // breastRadioButton
            // 
            this.breastRadioButton.AutoSize = true;
            this.breastRadioButton.Location = new System.Drawing.Point(40, 287);
            this.breastRadioButton.Name = "breastRadioButton";
            this.breastRadioButton.Size = new System.Drawing.Size(76, 17);
            this.breastRadioButton.TabIndex = 23;
            this.breastRadioButton.TabStop = true;
            this.breastRadioButton.Text = "Breast Fed";
            this.breastRadioButton.UseVisualStyleBackColor = true;
            // 
            // bottleRadioButton
            // 
            this.bottleRadioButton.AutoSize = true;
            this.bottleRadioButton.Location = new System.Drawing.Point(122, 287);
            this.bottleRadioButton.Name = "bottleRadioButton";
            this.bottleRadioButton.Size = new System.Drawing.Size(73, 17);
            this.bottleRadioButton.TabIndex = 24;
            this.bottleRadioButton.TabStop = true;
            this.bottleRadioButton.Text = "Bottle Fed";
            this.bottleRadioButton.UseVisualStyleBackColor = true;
            // 
            // feedingLabel
            // 
            this.feedingLabel.AutoSize = true;
            this.feedingLabel.Location = new System.Drawing.Point(29, 271);
            this.feedingLabel.Name = "feedingLabel";
            this.feedingLabel.Size = new System.Drawing.Size(87, 13);
            this.feedingLabel.TabIndex = 25;
            this.feedingLabel.Text = "Feeding Method:";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(33, 92);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(78, 13);
            this.genderLabel.TabIndex = 26;
            this.genderLabel.Text = "Child\'s Gender:";
            // 
            // genderDropdown
            // 
            this.genderDropdown.FormattingEnabled = true;
            this.genderDropdown.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderDropdown.Location = new System.Drawing.Point(117, 89);
            this.genderDropdown.Name = "genderDropdown";
            this.genderDropdown.Size = new System.Drawing.Size(121, 21);
            this.genderDropdown.TabIndex = 27;
            // 
            // ChildDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 371);
            this.Controls.Add(this.genderDropdown);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.feedingLabel);
            this.Controls.Add(this.bottleRadioButton);
            this.Controls.Add(this.breastRadioButton);
            this.Controls.Add(this.bothRadioButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.inchesLabel);
            this.Controls.Add(this.centimetresLabel);
            this.Controls.Add(this.ouncesLabel);
            this.Controls.Add(this.poundsLabel);
            this.Controls.Add(this.kilosLabel);
            this.Controls.Add(this.headLabel);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.birthDateLabel);
            this.Controls.Add(this.motherNameLabel);
            this.Controls.Add(this.childNameLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.childNameTextBox);
            this.Controls.Add(this.motherNameTextBox);
            this.Controls.Add(this.inchesTextBox);
            this.Controls.Add(this.centimetresTextBox);
            this.Controls.Add(this.poundsTextBox);
            this.Controls.Add(this.ouncesTextBox);
            this.Controls.Add(this.kilogramsTextBox);
            this.Controls.Add(this.dobPicker);
            this.Name = "ChildDetails";
            this.Text = "Child Details";
            this.Load += new System.EventHandler(this.ChildDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dobPicker;
        private System.Windows.Forms.TextBox kilogramsTextBox;
        private System.Windows.Forms.TextBox ouncesTextBox;
        private System.Windows.Forms.TextBox poundsTextBox;
        private System.Windows.Forms.TextBox centimetresTextBox;
        private System.Windows.Forms.TextBox inchesTextBox;
        private System.Windows.Forms.TextBox motherNameTextBox;
        private System.Windows.Forms.TextBox childNameTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label childNameLabel;
        private System.Windows.Forms.Label motherNameLabel;
        private System.Windows.Forms.Label birthDateLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label headLabel;
        private System.Windows.Forms.Label kilosLabel;
        private System.Windows.Forms.Label poundsLabel;
        private System.Windows.Forms.Label ouncesLabel;
        private System.Windows.Forms.Label centimetresLabel;
        private System.Windows.Forms.Label inchesLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.RadioButton bothRadioButton;
        private System.Windows.Forms.RadioButton breastRadioButton;
        private System.Windows.Forms.RadioButton bottleRadioButton;
        private System.Windows.Forms.Label feedingLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.ComboBox genderDropdown;
    }
}