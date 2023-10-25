using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Task02_form_JB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            textBox.ForeColor = Color.Black;

        }

        private void button_Click(object sender, EventArgs e)
        {
            string userInput = textBox.Text;
            bool conversionSuccess = float.TryParse(userInput, out float dogWeight);

            if (conversionSuccess && dogWeight > 0) 
            {
                Dog yourDog = new Dog(dogWeight);
                MessageBox.Show($"Recommended food amount: {yourDog.getFoodAmount()} cups per day");
            }
            else
            {
                MessageBox.Show("Invalid input");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void infoLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
