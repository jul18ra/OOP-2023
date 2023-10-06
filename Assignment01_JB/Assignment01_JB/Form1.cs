using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Assignment01_JB
{
    public partial class Form1 : Form
    {
        bool addition = false;
        bool subtraction = false;
        bool multiplication = false;
        bool division = false;
        bool modulo = false;

        public float GetOperand1()
        {

            float operand1 = float.Parse(operand1TextBox.Text);
            return operand1;

        }

        public float GetOperand2()
        {
            float operand2 = float.Parse(operand2TextBox.Text);
            return operand2;
        }

        public void CalculateResult()
        {
            try
            {
                double result = 0;

                if (addition == true)
                {
                    result = Math.Round((GetOperand1() + GetOperand2()), 2);
                    addition = false;
                }

                else if (subtraction == true)
                {
                    result = Math.Round((GetOperand1() - GetOperand2()), 2);
                    subtraction = false;
                }

                else if (multiplication == true)
                {
                    result = Math.Round((GetOperand1() * GetOperand2()), 2);
                    multiplication = false;
                }

                else if (division == true)
                {
                    result = Math.Round((GetOperand1() / GetOperand2()), 2);
                    division = false;
                }
                else if (modulo == true)
                {
                    result = Math.Round((GetOperand1() % GetOperand2()), 2);
                    modulo = false;
                }

                calculationTextBox.Text = result.ToString();
            }
            catch
            {
                MessageBox.Show("Invalid operand(s)", "Error", MessageBoxButtons.OK);
            }
            
        }

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
            addition = true;
            CalculateResult();
        }

        private void subtractionButton_Click(object sender, EventArgs e)
        {
            subtraction = true; 
            CalculateResult();
        }

        private void multiplicationButton_Click(object sender, EventArgs e)
        {
            multiplication = true;
            CalculateResult();
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            division = true;    
            CalculateResult();
        }

        private void moduloButton_Click(object sender, EventArgs e)
        {
            modulo = true;
            CalculateResult();
        }
    }

}



