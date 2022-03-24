// Program 3
//

// This application calculates the marginal tax rate
// for various candidates' tex plans.

/*Grading ID: R3555
  Program #: 3
  Due Date: 04/03/2020
  Course Section: CIS 199-01
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

namespace Prog3
{
    public partial class Prog3Form : Form
    {
        public Prog3Form()
        {
            InitializeComponent();
        }

        // User has clicked the Calculate Tax button
        // Will calculate and display their marginal tax rate
        private void calcTaxBtn_Click(object sender, EventArgs e)
        {
            int taxIncomeInput; //user's input
            int[] baselineThresholdLimits = { 0, 9701, 39476, 84201, 160726, 204101, 510300 }; //array for baseline threshold
            int[] candidate2ThresLimits = { 0, 9526, 38701, 82501, 157501, 200001, 250001, 500001, 2000001, 10000000 }; //array for candidate 2 threshold
            double[] candidate2Rate = { .10, .12, .22, .24, .32, .35, .40, .45, .50, .52 }; //array for candidate 2 rate
            double[] baselineRate = { .10, .12, .22, .24, .32, .35, .37 }; //array for baseline rate
            bool found = false; //found statement to use in while loop
            double rate = 0; //used to add marginal tax rate depending on user input to display in marginalRateOutLbl

            //users input + baseline radio button check, while loop to calculate marginal tax rate and display results
            if (int.TryParse(incomeTxt.Text, out taxIncomeInput) && (baselineRdoBtn.Checked)) 
            {
                int index = baselineThresholdLimits.Length - 1;

                while (index >= 0 && !found)
                {
                    if (taxIncomeInput >= baselineThresholdLimits[index])
                        found = true;
                    else
                        --index;
                }
                if (found)
                    rate = baselineRate[index];

                marginalRateOutLbl.Text = $"{rate:P1}";
            }
            //users input + Candidate 2 radio button check, while loop to calculate marginal tax rate and display results
            else if (int.TryParse(incomeTxt.Text, out taxIncomeInput) && (candidate2RdoBtn.Checked))
            {
                int index = candidate2ThresLimits.Length - 1;

                while (index >= 0 && !found)
                {
                    if (taxIncomeInput >= candidate2ThresLimits[index])
                        found = true;
                    else
                        --index;
                }
                if (found)
                    rate = candidate2Rate[index];

                marginalRateOutLbl.Text = $"{rate:P1}";
            }
        }
    }
}