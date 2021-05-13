using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            // Variables and constants.
            double weight;     // Holds the value for weight.
            double height;     // Holds the value for height.
            int BMI;        // Holds the value for calculated BMI.

            // Calculates the BMI.
            weight = double.Parse(weightTextBox.Text);
            height = double.Parse(heightTextBox.Text);
            BMI = (int) ((weight) * 703 / Math.Pow(height, 2));

            // Determines whether the person is underweight, overweight, or obese.
            if ((BMI >= 25) && (BMI < 30))
            {
                calculatedBMILabel.Text = "Your BMI is: " + BMI + ", you are overweight. There is a moderate risk " +
                    "of you dying from disease.";
            } 
            else if (BMI >= 30)
            {
                calculatedBMILabel.Text = "Your BMI is: " + BMI + ", you are obese. There is a 50 to 100 percent higher" +
                    " risk of you dying prematurely compared to healthy weight";
            } 
            else if (BMI < 18.5)
            {
                calculatedBMILabel.Text = "Your BMI is: " + BMI + ", you are underweight. You can also be unhealthy.";
            } 
            else
            {
                calculatedBMILabel.Text = "Your BMI is: " + BMI + ", You are at a healthy weight!"; 
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Clear the TextBoxes and Label.
            heightTextBox.Text = "";
            weightTextBox.Text = "";
            calculatedBMILabel.Text = "";

            // Clear the focus.
            calculatedBMILabel.Focus();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // Exit the form.
            this.Close();
        }
    }
}
