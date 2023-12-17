namespace Assignment01_JB
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.greetingButton = new System.Windows.Forms.Button();
            this.greetingTextBox = new System.Windows.Forms.TextBox();
            this.operand1TextBox = new System.Windows.Forms.TextBox();
            this.operand2TextBox = new System.Windows.Forms.TextBox();
            this.calculationTextBox = new System.Windows.Forms.TextBox();
            this.dateOfBirthTextBox = new System.Windows.Forms.TextBox();
            this.daysButton = new System.Windows.Forms.Button();
            this.daysOldTextBox = new System.Windows.Forms.TextBox();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.sentenceTextBox = new System.Windows.Forms.TextBox();
            this.charCountTextBox = new System.Windows.Forms.TextBox();
            this.sentenceButton = new System.Windows.Forms.Button();
            this.colorButton = new System.Windows.Forms.Button();
            this.colorBox = new System.Windows.Forms.TextBox();
            this.additionButton = new System.Windows.Forms.Button();
            this.subtractionButton = new System.Windows.Forms.Button();
            this.multiplicationButton = new System.Windows.Forms.Button();
            this.divisionButton = new System.Windows.Forms.Button();
            this.moduloButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(26, 35);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(213, 26);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.Text = "Please enter your name";
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // greetingButton
            // 
            this.greetingButton.Location = new System.Drawing.Point(314, 29);
            this.greetingButton.Name = "greetingButton";
            this.greetingButton.Size = new System.Drawing.Size(137, 38);
            this.greetingButton.TabIndex = 1;
            this.greetingButton.Text = "Make greeting";
            this.greetingButton.UseVisualStyleBackColor = true;
            this.greetingButton.Click += new System.EventHandler(this.greetingButton_Click);
            // 
            // greetingTextBox
            // 
            this.greetingTextBox.Location = new System.Drawing.Point(533, 35);
            this.greetingTextBox.Name = "greetingTextBox";
            this.greetingTextBox.ReadOnly = true;
            this.greetingTextBox.Size = new System.Drawing.Size(251, 26);
            this.greetingTextBox.TabIndex = 2;
            this.greetingTextBox.TextChanged += new System.EventHandler(this.greetingTextBox_TextChanged);
            // 
            // operand1TextBox
            // 
            this.operand1TextBox.Location = new System.Drawing.Point(26, 116);
            this.operand1TextBox.Name = "operand1TextBox";
            this.operand1TextBox.Size = new System.Drawing.Size(100, 26);
            this.operand1TextBox.TabIndex = 3;
            this.operand1TextBox.Text = "Operand 1";
            this.operand1TextBox.TextChanged += new System.EventHandler(this.operand1TextBox_TextChanged);
            // 
            // operand2TextBox
            // 
            this.operand2TextBox.Location = new System.Drawing.Point(139, 116);
            this.operand2TextBox.Name = "operand2TextBox";
            this.operand2TextBox.Size = new System.Drawing.Size(100, 26);
            this.operand2TextBox.TabIndex = 4;
            this.operand2TextBox.Text = "Operand 2";
            this.operand2TextBox.TextChanged += new System.EventHandler(this.operand2TextBox_TextChanged);
            // 
            // calculationTextBox
            // 
            this.calculationTextBox.Location = new System.Drawing.Point(533, 116);
            this.calculationTextBox.Name = "calculationTextBox";
            this.calculationTextBox.ReadOnly = true;
            this.calculationTextBox.Size = new System.Drawing.Size(251, 26);
            this.calculationTextBox.TabIndex = 5;
            this.calculationTextBox.Text = "=";
            this.calculationTextBox.TextChanged += new System.EventHandler(this.calculationTextBox_TextChanged);
            // 
            // dateOfBirthTextBox
            // 
            this.dateOfBirthTextBox.Location = new System.Drawing.Point(26, 207);
            this.dateOfBirthTextBox.Name = "dateOfBirthTextBox";
            this.dateOfBirthTextBox.Size = new System.Drawing.Size(213, 26);
            this.dateOfBirthTextBox.TabIndex = 11;
            this.dateOfBirthTextBox.Text = "dd/mm/yyyy";
            this.dateOfBirthTextBox.TextChanged += new System.EventHandler(this.dateOfBirthTextBox_TextChanged);
            // 
            // daysButton
            // 
            this.daysButton.Location = new System.Drawing.Point(314, 201);
            this.daysButton.Name = "daysButton";
            this.daysButton.Size = new System.Drawing.Size(137, 38);
            this.daysButton.TabIndex = 12;
            this.daysButton.Text = "Calculate days";
            this.daysButton.UseVisualStyleBackColor = true;
            this.daysButton.Click += new System.EventHandler(this.daysButton_Click);
            // 
            // daysOldTextBox
            // 
            this.daysOldTextBox.Location = new System.Drawing.Point(533, 201);
            this.daysOldTextBox.Name = "daysOldTextBox";
            this.daysOldTextBox.ReadOnly = true;
            this.daysOldTextBox.Size = new System.Drawing.Size(251, 26);
            this.daysOldTextBox.TabIndex = 13;
            this.daysOldTextBox.Text = "You are __ days old";
            this.daysOldTextBox.TextChanged += new System.EventHandler(this.daysOldTextBox_TextChanged);
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.Location = new System.Drawing.Point(23, 184);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(103, 20);
            this.birthdayLabel.TabIndex = 14;
            this.birthdayLabel.Text = "Your birthday";
            this.birthdayLabel.Click += new System.EventHandler(this.birthdayLabel_Click);
            // 
            // sentenceTextBox
            // 
            this.sentenceTextBox.Location = new System.Drawing.Point(26, 292);
            this.sentenceTextBox.Name = "sentenceTextBox";
            this.sentenceTextBox.Size = new System.Drawing.Size(213, 26);
            this.sentenceTextBox.TabIndex = 15;
            this.sentenceTextBox.Text = "Please enter a sentence";
            // 
            // charCountTextBox
            // 
            this.charCountTextBox.Location = new System.Drawing.Point(533, 292);
            this.charCountTextBox.Name = "charCountTextBox";
            this.charCountTextBox.ReadOnly = true;
            this.charCountTextBox.Size = new System.Drawing.Size(251, 26);
            this.charCountTextBox.TabIndex = 16;
            this.charCountTextBox.Text = "Your sentence has __ characters";
            // 
            // sentenceButton
            // 
            this.sentenceButton.Location = new System.Drawing.Point(325, 277);
            this.sentenceButton.Name = "sentenceButton";
            this.sentenceButton.Size = new System.Drawing.Size(109, 56);
            this.sentenceButton.TabIndex = 17;
            this.sentenceButton.Text = "Count characters";
            this.sentenceButton.UseVisualStyleBackColor = true;
            this.sentenceButton.Click += new System.EventHandler(this.sentenceButton_Click);
            // 
            // colorButton
            // 
            this.colorButton.Location = new System.Drawing.Point(325, 376);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(109, 56);
            this.colorButton.TabIndex = 18;
            this.colorButton.Text = "Off";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // colorBox
            // 
            this.colorBox.BackColor = System.Drawing.Color.IndianRed;
            this.colorBox.Location = new System.Drawing.Point(533, 357);
            this.colorBox.Multiline = true;
            this.colorBox.Name = "colorBox";
            this.colorBox.ReadOnly = true;
            this.colorBox.Size = new System.Drawing.Size(91, 89);
            this.colorBox.TabIndex = 19;
            // 
            // additionButton
            // 
            this.additionButton.Location = new System.Drawing.Point(266, 111);
            this.additionButton.Name = "additionButton";
            this.additionButton.Size = new System.Drawing.Size(42, 40);
            this.additionButton.TabIndex = 20;
            this.additionButton.Text = "+";
            this.additionButton.UseVisualStyleBackColor = true;
            this.additionButton.Click += new System.EventHandler(this.additionButton_Click);
            // 
            // subtractionButton
            // 
            this.subtractionButton.Location = new System.Drawing.Point(314, 111);
            this.subtractionButton.Name = "subtractionButton";
            this.subtractionButton.Size = new System.Drawing.Size(41, 40);
            this.subtractionButton.TabIndex = 21;
            this.subtractionButton.Text = "-";
            this.subtractionButton.UseVisualStyleBackColor = true;
            this.subtractionButton.Click += new System.EventHandler(this.subtractionButton_Click);
            // 
            // multiplicationButton
            // 
            this.multiplicationButton.Location = new System.Drawing.Point(363, 111);
            this.multiplicationButton.Name = "multiplicationButton";
            this.multiplicationButton.Size = new System.Drawing.Size(39, 40);
            this.multiplicationButton.TabIndex = 22;
            this.multiplicationButton.Text = "*";
            this.multiplicationButton.UseVisualStyleBackColor = true;
            this.multiplicationButton.Click += new System.EventHandler(this.multiplicationButton_Click);
            // 
            // divisionButton
            // 
            this.divisionButton.Location = new System.Drawing.Point(408, 111);
            this.divisionButton.Name = "divisionButton";
            this.divisionButton.Size = new System.Drawing.Size(43, 40);
            this.divisionButton.TabIndex = 23;
            this.divisionButton.Text = "/";
            this.divisionButton.UseVisualStyleBackColor = true;
            this.divisionButton.Click += new System.EventHandler(this.divisionButton_Click);
            // 
            // moduloButton
            // 
            this.moduloButton.Location = new System.Drawing.Point(457, 111);
            this.moduloButton.Name = "moduloButton";
            this.moduloButton.Size = new System.Drawing.Size(39, 40);
            this.moduloButton.TabIndex = 24;
            this.moduloButton.Text = "%";
            this.moduloButton.UseVisualStyleBackColor = true;
            this.moduloButton.Click += new System.EventHandler(this.moduloButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 469);
            this.Controls.Add(this.moduloButton);
            this.Controls.Add(this.divisionButton);
            this.Controls.Add(this.multiplicationButton);
            this.Controls.Add(this.subtractionButton);
            this.Controls.Add(this.additionButton);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.sentenceButton);
            this.Controls.Add(this.charCountTextBox);
            this.Controls.Add(this.sentenceTextBox);
            this.Controls.Add(this.birthdayLabel);
            this.Controls.Add(this.daysOldTextBox);
            this.Controls.Add(this.daysButton);
            this.Controls.Add(this.dateOfBirthTextBox);
            this.Controls.Add(this.calculationTextBox);
            this.Controls.Add(this.operand2TextBox);
            this.Controls.Add(this.operand1TextBox);
            this.Controls.Add(this.greetingTextBox);
            this.Controls.Add(this.greetingButton);
            this.Controls.Add(this.nameTextBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(836, 525);
            this.MinimumSize = new System.Drawing.Size(836, 525);
            this.Name = "Form1";
            this.Text = "GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button greetingButton;
        private System.Windows.Forms.TextBox greetingTextBox;
        private System.Windows.Forms.TextBox operand1TextBox;
        private System.Windows.Forms.TextBox operand2TextBox;
        private System.Windows.Forms.TextBox calculationTextBox;
        private System.Windows.Forms.TextBox dateOfBirthTextBox;
        private System.Windows.Forms.Button daysButton;
        private System.Windows.Forms.TextBox daysOldTextBox;
        private System.Windows.Forms.Label birthdayLabel;
        private System.Windows.Forms.TextBox sentenceTextBox;
        private System.Windows.Forms.TextBox charCountTextBox;
        private System.Windows.Forms.Button sentenceButton;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.TextBox colorBox;
        private System.Windows.Forms.Button additionButton;
        private System.Windows.Forms.Button subtractionButton;
        private System.Windows.Forms.Button multiplicationButton;
        private System.Windows.Forms.Button divisionButton;
        private System.Windows.Forms.Button moduloButton;
    }
}

