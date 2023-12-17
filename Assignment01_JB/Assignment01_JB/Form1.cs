using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Assignment01_JB
{
    public partial class Form1 : Form
    {
        // Returns the operand from the specified text box
        public float GetOperand(TextBox operandTextBox)
        {
            float operand = float.Parse(operandTextBox.Text);
            return operand;
        }
      
        // Calculates result for operation 
        public void CalculateResult(string logic)
        {
            double result = 0;

            try
            {
                float operand1 = GetOperand(operand1TextBox);
                float operand2 = GetOperand(operand2TextBox);

                switch (logic)
                {
                    // Addition
                    case "+":
                        result = operand1 + operand2;
                        break;

                    // Subtraction
                    case "-":
                        result = operand1 - operand2;
                        break;

                    // Multiplication
                    case "*":
                        result = operand1 * operand2;
                        break;

                    // Division
                    case "/":
                        result = operand1 / operand2;
                        break;

                    // Modulo
                    case "%":
                        result = operand1 % operand2;
                        break;
                }

                // Displays the rounded result in the text box
                result = Math.Round(result, 2);
                calculationTextBox.Text = result.ToString();

            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid operand(s)", "Error", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Invalid operation", "Error", MessageBoxButtons.OK);
            }
            
        }

        // Calculates how many days old you are based on date of birth
        public double CalculateDaysOld()
        {

            string dateOfBirthString = dateOfBirthTextBox.Text;

            try
            {
                DateTime dateOfBirth = DateTime.ParseExact(dateOfBirthString, "dd/MM/yyyy", null);

                DateTime currentDate = DateTime.Now;

                TimeSpan difference = currentDate - dateOfBirth;
                double daysOld = Math.Floor(difference.TotalDays);

                return daysOld;

            }

            catch
            {
                MessageBox.Show("Enter date in format dd/mm/yyyy", "Error", MessageBoxButtons.OK);
                return 0;
            }
        }

        // Calculates number of characters in a string
        public int CalculateChars()
        {
            string sentence = sentenceTextBox.Text;

            int charCount = 0;

            foreach (char c in sentence)
            {
                charCount++;
            }

            return charCount;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void greetingButton_Click(object sender, EventArgs e)
        {
            greetingTextBox.Text = $"Hello {nameTextBox.Text}!";
        }

        private void greetingTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void operand1TextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void operand2TextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void calculationTextBox_TextChanged(object sender, EventArgs e)
        {
;
        }

        private void birthdayLabel_Click(object sender, EventArgs e)
        {

        }

        private void dateOfBirthTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void daysOldTextBox_TextChanged(object sender, EventArgs e)
        {
              
        }

        private void daysButton_Click(object sender, EventArgs e)
        {
            daysOldTextBox.Text = $"You are {CalculateDaysOld()} days old";
        }

        private void sentenceButton_Click(object sender, EventArgs e)
        {
            charCountTextBox.Text = $"Your sentence has {CalculateChars()} characters";
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            if (colorBox.BackColor == Color.IndianRed)
            {
                colorBox.BackColor = Color.LightGreen;
                colorButton.Text = "On";
            }

            else
            {
                colorBox.BackColor = Color.IndianRed;
                colorButton.Text = "Off";
            }
        }

        private void additionButton_Click(object sender, EventArgs e)
        {
            CalculateResult("+");
        }

        private void subtractionButton_Click(object sender, EventArgs e)
        {
            CalculateResult("-");
        }

        private void multiplicationButton_Click(object sender, EventArgs e)
        {
            CalculateResult("*");
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            CalculateResult("/");
        }

        private void moduloButton_Click(object sender, EventArgs e)
        {
            CalculateResult("%");
        }
    }

}



