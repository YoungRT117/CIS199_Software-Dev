/*Grading ID: R3555
Lab#:Lab 3
Due Date: 02/09/2020
Course Section: CIS 199-01
Brief Description: Inputting a number into the Textbox next to "Radius of sphere" and Clicking the 
                   calucate button will output the Diameter, Surface Area, and Volume. I defined the variables
                   then used the parse method for the textbox input, then went on to define the formulas
                   and setting the texts to output in their desired boxes.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Lab3 : Form
    {
        public Lab3()
        {
            InitializeComponent();
        }
        /* The event below was created so that when you click the button, it provides the proper outputs from
           the inputed number. The rest of the description of this program is put in the "Brief Description" 
           at the top of the program with the other required comments.*/
        private void Calculate_Click(object sender, EventArgs e)
        {
            double DiameterFormula; //defines the formula for Diameter
            double AreaFormula; //defines the formula for Area
            double VolumeFormula; //defines the formula for Volume
            double RadiusOFsphereInput; //allows the input to be used in arithmetic

            RadiusOFsphereInput = double.Parse(ROSinput.Text);

            DiameterFormula = 2 * RadiusOFsphereInput;
            Dinput.Text = $"{DiameterFormula:F2}";

            AreaFormula = 4 * Math.PI * Math.Pow(RadiusOFsphereInput, 2);
            SAinput.Text = $"{AreaFormula:F2}";

            VolumeFormula = (4 * Math.PI * Math.Pow(RadiusOFsphereInput, 3)) / 3;
            Vinput.Text = $"{VolumeFormula:F2}";
        }
    }
}
