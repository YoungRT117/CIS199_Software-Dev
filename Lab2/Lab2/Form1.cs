/*Grading ID: R3555
Lab#:Lab 2
Due Date: 02/02/2020
Course Section: CIS 199-01
Brief Description: The coding below is created so that when you click the "Calculate Tip" button, it
                   show the amount given at a 15%, 18% and 20% tip. We defined the variables needed,
                   converted the number inputed in the text box into a double, made variables to make it
                   easier to apply the percentages using "const double", seen below and then we use a
                   string.format line to display to results in their respective boxes in currency format.
*/

using System;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Lab2 : Form
    {
        public Lab2()
        {
            InitializeComponent();
        }
       
        /*The event handler is initiated when you click on the "Calculate Tip" button, and description of
         * how it work is in the brief description at the top! */
        private void CalculateTax_Click(object sender, EventArgs e)
        {
            double tax1; //Variable for 15% tip 
            double num1; //Variable for number inputted into the text box
            double tax2; //Variable for 18% tip
            double tax3; //Variable for 20% tip
            num1 = Convert.ToDouble(InputBox.Text);
            const double TIP_RATE1 = 0.15; //Variable to define 15% to be used arithmatically 
            const double TIP_RATE2 = 0.18; //Variable to define 18% to be used arithmatically 
            const double TIP_RATE3 = 0.20; //Variable to define 20% to be used arithmatically 
            tax1 = num1 * TIP_RATE1;
            tax2 = num1 * TIP_RATE2;
            tax3 = num1 * TIP_RATE3;
            taxes15.Text = string.Format("{0:C}", tax1);
            taxes18.Text = string.Format("{0:C}", tax2);
            taxes20.Text = string.Format("{0:C}", tax3);
        }
    }
}
