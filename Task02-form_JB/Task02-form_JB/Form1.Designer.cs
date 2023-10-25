namespace Task02_form_JB
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.dogWeightLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textBox.Location = new System.Drawing.Point(135, 98);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(115, 26);
            this.textBox.TabIndex = 0;
            this.textBox.Text = "Enter weight";
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(135, 142);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(115, 42);
            this.button.TabIndex = 1;
            this.button.Text = "Calculate";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // dogWeightLabel
            // 
            this.dogWeightLabel.AutoSize = true;
            this.dogWeightLabel.Location = new System.Drawing.Point(131, 75);
            this.dogWeightLabel.Name = "dogWeightLabel";
            this.dogWeightLabel.Size = new System.Drawing.Size(120, 20);
            this.dogWeightLabel.TabIndex = 2;
            this.dogWeightLabel.Text = "Dog weight (kg)";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(12, 9);
            this.infoLabel.MaximumSize = new System.Drawing.Size(400, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(368, 40);
            this.infoLabel.TabIndex = 3;
            this.infoLabel.Text = "This tool calculates how many cups of dry food you should feed your dog per day.";
            this.infoLabel.Click += new System.EventHandler(this.infoLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 202);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.dogWeightLabel);
            this.Controls.Add(this.button);
            this.Controls.Add(this.textBox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(412, 258);
            this.MinimumSize = new System.Drawing.Size(412, 258);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label dogWeightLabel;
        private System.Windows.Forms.Label infoLabel;
    }
}

