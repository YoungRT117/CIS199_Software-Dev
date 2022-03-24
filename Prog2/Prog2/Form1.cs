/*Grading ID: R3555
  Program #: 2
  Due Date: 02/09/2020
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

namespace Prog2
{
    public partial class taxIncome : Form
    {
        public taxIncome()
        {
            InitializeComponent();
        }

        //When the Calculate button is clicked on the form, the coding program I wrote below will iniate
        private void calculateButton_Click(object sender, EventArgs e)
        {
         //----------------------------------------------------------------------------------------------\\
         //Marginal Tax Rates

            //Baseline Tax Rates 1-7
            const double baseline_rate_1 = .10; //Baseline marginal tax rate 10%
            const double baseline_rate_2 = .12; //Baseline marginal tax rate 12%
            const double baseline_rate_3 = .22; //Baseline marginal tax rate 22%
            const double baseline_rate_4 = .24; //Baseline marginal tax rate 24%
            const double baseline_rate_5 = .32; //Baseline marginal tax rate 32%
            const double baseline_rate_6 = .35; //Baseline marginal tax rate 35%
            const double baseline_rate_7 = .37; //Baseline marginal tax rate 37%

            //Candidate 1 & 3 Tax Rates 1-7
            const double Candidate13_rate_1 = .10; //Candidate 1 & 3 marginal tax rate 10%
            const double Candidate13_rate_2 = .15; //Candidate 1 & 3 marginal tax rate 15%
            const double Candidate13_rate_3 = .25; //Candidate 1 & 3 marginal tax rate 25%
            const double Candidate13_rate_4 = .28; //Candidate 1 & 3 marginal tax rate 28%
            const double Candidate13_rate_5 = .33; //Candidate 1 & 3 marginal tax rate 33%
            const double Candidate13_rate_6 = .35; //Candidate 1 & 3 marginal tax rate 35%
            const double Candidate13_rate_7 = .396; //Candidate 1 & 3 marginal tax rate 39.6%

            //Candidate 2 Tax Rates 1-10
            const double Candidate2_rate_1 = .10; //Candidate 2 marginal tax rate 10%
            const double Candidate2_rate_2 = .12; //Candidate 2 marginal tax rate 12%
            const double Candidate2_rate_3 = .22; //Candidate 2 marginal tax rate 22%
            const double Candidate2_rate_4 = .24; //Candidate 2 marginal tax rate 24%
            const double Candidate2_rate_5 = .32; //Candidate 2 marginal tax rate 32%
            const double Candidate2_rate_6 = .35; //Candidate 2 marginal tax rate 35%
            const double Candidate2_rate_7 = .40; //Candidate 2 marginal tax rate 40%
            const double Candidate2_rate_8 = .45; //Candidate 2 marginal tax rate 45%
            const double Candidate2_rate_9 = .50; //Candidate 2 marginal tax rate 50%
            const double Candidate2_rate_10 = .52; //Candidate 2 marginal tax rate 52%

            //----------------------------------------------------------------------------------------------\\
            //Income Thresholds

            //Baseline Income Thresholds 1-7
            const int baseline_threshold_1 = 9700; //Baseline Income Threshold $9700
            const int baseline_threshold_2 = 39475; //Baseline Income Threshold $39475
            const int baseline_threshold_3 = 84200; //Baseline Income Threshold $84200
            const int baseline_threshold_4 = 160725; //Baseline Income Threshold $160725
            const int baseline_threshold_5 = 204100; //Baseline Income Threshold $204100
            const int baseline_threshold_67 = 510300; //Baseline Income Threshold $510300

            //Candidate 1 & 3 Income Thresholds 1-7
            const int Candidate13_threshold_1 = 9525; //Candidate 1 & 3 Income Thresholds $9525
            const int Candidate13_threshold_2 = 38700; //Candidate 1 & 3 Income Thresholds $38700
            const int Candidate13_threshold_3 = 82500; //Candidate 1 & 3 Income Thresholds $82500
            const int Candidate13_threshold_4 = 157500; //Candidate 1 & 3 Income Thresholds $157500
            const int Candidate13_threshold_5 = 200000; //Candidate 1 & 3 Income Thresholds $200000
            const int Candidate13_threshold_67 = 500000; //Candidate 1 & 3 Income Thresholds $500000

            //Candidate 2 Income Thresholds 1-10
            const int Candidate2_threshold_1 = 9525; //Candidate 2 Income Thresholds $9525
            const int Candidate2_threshold_2 = 38700; //Candidate 2 Income Thresholds $38700
            const int Candidate2_threshold_3 = 82500; //Candidate 2 Income Thresholds $82500
            const int Candidate2_threshold_4 = 157500; //Candidate 2 Income Thresholds $157500
            const int Candidate2_threshold_5 = 200000; //Candidate 2 Income Thresholds $200000
            const int Candidate2_threshold_6 = 250000; //Candidate 2 Income Thresholds $250000
            const int Candidate2_threshold_7 = 500000; //Candidate 2 Income Thresholds $500000
            const int Candidate2_threshold_8 = 2000000; //Candidate 2 Income Thresholds $2000000
            const int Candidate2_threshold_91 = 10000000; //Candidate 2 Income Thresholds $10000000

            //----------------------------------------------------------------------------------------------\\
            //Special Circumstances

            //Additional Tax
            const double extraRate = .04; //additional 4% tax
            const int extraRateThreshold = 29000; //apply added tax if greater than this const int (29000)

            //Reducted Tax
            const double reductionRate = .10; //reduced tax by this const double (.10) for 200000 and under

            int income; //inputed number in textbox on form, TryParse to use in calculations
            double marginalRate; //Rate used and applied to show up in Tax label
            double currentTax; //Rate used to determine total tax from income input and radio button thats checked

         //----------------------------------------------------------------------------------------------\\

            if (int.TryParse(Income.Text, out income) && (baselineButton.Checked))
            {
                if (income <= baseline_threshold_1)
                {
                    marginalRate = baseline_rate_1;
                    currentTax = (income * baseline_rate_1);


                    Tax.Text = ($"{currentTax:C}");
                    marginalR.Text = ($"{marginalRate:P1}");
                    Plan.Text = ("Baseline");
                }

                else if (income <= baseline_threshold_2)
                {
                    marginalRate = baseline_rate_2;
                    currentTax = ((baseline_threshold_1 * baseline_rate_1) + ((income - baseline_threshold_1) * baseline_rate_2));


                    Tax.Text = ($"{currentTax:C}");
                    marginalR.Text = ($"{marginalRate:P1}");
                    Plan.Text = ("Baseline");
                }
                else if (income <= baseline_threshold_3)
                {
                    marginalRate = baseline_rate_3;
                    currentTax = ((baseline_threshold_1 * baseline_rate_1) + ((baseline_threshold_2 - baseline_threshold_1) * baseline_rate_2) + (income - (baseline_threshold_2 - baseline_threshold_1) - baseline_threshold_1) * baseline_rate_3);


                    Tax.Text = ($"{currentTax:C}");
                    marginalR.Text = ($"{marginalRate:P1}");
                    Plan.Text = ("Baseline");
                }
                else if (income <= baseline_threshold_4)
                {
                    marginalRate = baseline_rate_4;
                    currentTax = ((baseline_threshold_1 * baseline_rate_1) + ((baseline_threshold_2 - baseline_threshold_1) * baseline_rate_2) + ((baseline_threshold_3 - baseline_threshold_2) * baseline_rate_3) + (income - (baseline_threshold_3 - baseline_threshold_2) - (baseline_threshold_2 - baseline_threshold_1) - baseline_threshold_1) * baseline_rate_4);


                    Tax.Text = ($"{currentTax:C}");
                    marginalR.Text = ($"{marginalRate:P1}");
                    Plan.Text = ("Baseline");
                }
                else if (income <= baseline_threshold_5)
                {
                    marginalRate = baseline_rate_5;
                    currentTax = ((baseline_threshold_1 * baseline_rate_1) + ((baseline_threshold_2 - baseline_threshold_1) * baseline_rate_2) + ((baseline_threshold_3 - baseline_threshold_2) * baseline_rate_3) + ((baseline_threshold_4 - baseline_threshold_3) * baseline_rate_4) + (income - (baseline_threshold_4 - baseline_threshold_3) - (baseline_threshold_3 - baseline_threshold_2) - (baseline_threshold_2 - baseline_threshold_1) - baseline_threshold_1) * baseline_rate_5);


                    Tax.Text = ($"{currentTax:C}");
                    marginalR.Text = ($"{marginalRate:P1}");
                    Plan.Text = ("Baseline");
                }
                else if (income <= baseline_threshold_67)
                {
                    marginalRate = baseline_rate_5;
                    currentTax = ((baseline_threshold_1 * baseline_rate_1) + ((baseline_threshold_2 - baseline_threshold_1) * baseline_rate_2) + ((baseline_threshold_3 - baseline_threshold_2) * baseline_rate_3) + ((baseline_threshold_4 - baseline_threshold_3) * baseline_rate_4) + ((baseline_threshold_5 - baseline_threshold_4) * baseline_rate_5) + (income - (baseline_threshold_5 - baseline_threshold_4) - (baseline_threshold_4 - baseline_threshold_3) - (baseline_threshold_3 - baseline_threshold_2) - (baseline_threshold_2 - baseline_threshold_1) - baseline_threshold_1) * baseline_rate_6);


                    Tax.Text = ($"{currentTax:C}");
                    marginalR.Text = ($"{marginalRate:P1}");
                    Plan.Text = ("Baseline");
                }
                else if (income > baseline_threshold_67)
                {
                    marginalRate = baseline_rate_6;
                    currentTax = ((baseline_threshold_1 * baseline_rate_1) + ((baseline_threshold_2 - baseline_threshold_1) * baseline_rate_2) + ((baseline_threshold_3 - baseline_threshold_2) * baseline_rate_3) + ((baseline_threshold_4 - baseline_threshold_3) * baseline_rate_4) + ((baseline_threshold_5 - baseline_threshold_4) * baseline_rate_5) + ((baseline_threshold_67 - baseline_threshold_5) * baseline_rate_6) + (income - (baseline_threshold_67 - baseline_threshold_5) - (baseline_threshold_5 - baseline_threshold_4) - (baseline_threshold_4 - baseline_threshold_3) - (baseline_threshold_3 - baseline_threshold_2) - (baseline_threshold_2 - baseline_threshold_1) - baseline_threshold_1) * baseline_rate_7);


                    Tax.Text = ($"{currentTax:C}");
                    marginalR.Text = ($"{marginalRate:P1}");
                    Plan.Text = ("Baseline");
                }

            }
            else if (int.TryParse(Income.Text, out income) && (candidate1Button.Checked))
            {
                if (income <= Candidate13_threshold_1)
                {
                    marginalRate = Candidate13_rate_1;
                    currentTax = (income * Candidate13_rate_1);


                    Tax.Text = ($"{currentTax:C}");
                    marginalR.Text = ($"{marginalRate:P1}");
                    Plan.Text = ("Candidate 1");
                }

                else if (income <= Candidate13_threshold_2)
                {
                    marginalRate = Candidate13_rate_2;
                    currentTax = ((Candidate13_threshold_1 * Candidate13_rate_1) + ((income - Candidate13_threshold_1) * Candidate13_rate_2));


                    Tax.Text = ($"{currentTax:C}");
                    marginalR.Text = ($"{marginalRate:P1}");
                    Plan.Text = ("Candidate 1");
                }
                else if (income <= Candidate13_threshold_3)
                {
                    marginalRate = Candidate13_rate_3;
                    currentTax = ((Candidate13_threshold_1 * Candidate13_rate_1) + ((Candidate13_threshold_2 - Candidate13_threshold_1) * Candidate13_rate_2) + (income - (Candidate13_threshold_2 - Candidate13_threshold_1) - Candidate13_threshold_1) * Candidate13_rate_3);


                    Tax.Text = ($"{currentTax:C}");
                    marginalR.Text = ($"{marginalRate:P1}");
                    Plan.Text = ("Candidate 1");
                }
                else if (income <= Candidate13_threshold_4)
                {
                    marginalRate = Candidate13_rate_4;
                    currentTax = ((Candidate13_threshold_1 * Candidate13_rate_1) + ((Candidate13_threshold_2 - Candidate13_threshold_1) * Candidate13_rate_2) + ((Candidate13_threshold_3 - Candidate13_threshold_2) * Candidate13_rate_3) + (income - (Candidate13_threshold_3 - Candidate13_threshold_2) - (Candidate13_threshold_2 - Candidate13_threshold_1) - Candidate13_threshold_1) * Candidate13_rate_4);


                    Tax.Text = ($"{currentTax:C}");
                    marginalR.Text = ($"{marginalRate:P1}");
                    Plan.Text = ("Candidate 1");
                }
                else if (income <= Candidate13_threshold_5)
                {
                    marginalRate = Candidate13_rate_5;
                    currentTax = ((Candidate13_threshold_1 * Candidate13_rate_1) + ((Candidate13_threshold_2 - Candidate13_threshold_1) * Candidate13_rate_2) + ((Candidate13_threshold_3 - Candidate13_threshold_2) * Candidate13_rate_3) + ((Candidate13_threshold_4 - Candidate13_threshold_3) * Candidate13_rate_4) + (income - (Candidate13_threshold_4 - Candidate13_threshold_3) - (Candidate13_threshold_3 - Candidate13_threshold_2) - (Candidate13_threshold_2 - Candidate13_threshold_1) - Candidate13_threshold_1) * Candidate13_rate_5);


                    Tax.Text = ($"{currentTax:C}");
                    marginalR.Text = ($"{marginalRate:P1}");
                    Plan.Text = ("Candidate 1");
                }
                else if (income <= Candidate13_threshold_67)
                {
                    marginalRate = Candidate13_rate_6;
                    currentTax = ((Candidate13_threshold_1 * Candidate13_rate_1) + ((Candidate13_threshold_2 - Candidate13_threshold_1) * Candidate13_rate_2) + ((Candidate13_threshold_3 - Candidate13_threshold_2) * Candidate13_rate_3) + ((Candidate13_threshold_4 - Candidate13_threshold_3) * Candidate13_rate_4) + ((Candidate13_threshold_5 - Candidate13_threshold_4) * Candidate13_rate_5) + (income - (Candidate13_threshold_5 - Candidate13_threshold_4) - (Candidate13_threshold_4 - Candidate13_threshold_3) - (Candidate13_threshold_3 - Candidate13_threshold_2) - (Candidate13_threshold_2 - Candidate13_threshold_1) - Candidate13_threshold_1) * Candidate13_rate_6);


                    Tax.Text = ($"{currentTax:C}");
                    marginalR.Text = ($"{marginalRate:P1}");
                    Plan.Text = ("Candidate 1");
                }
                else if (income > Candidate13_threshold_67)
                {
                    marginalRate = Candidate13_rate_7;
                    currentTax = ((Candidate13_threshold_1 * Candidate13_rate_1) + ((Candidate13_threshold_2 - Candidate13_threshold_1) * Candidate13_rate_2) + ((Candidate13_threshold_3 - Candidate13_threshold_2) * Candidate13_rate_3) + ((Candidate13_threshold_4 - Candidate13_threshold_3) * Candidate13_rate_4) + ((Candidate13_threshold_5 - Candidate13_threshold_4) * Candidate13_rate_5) + ((Candidate13_threshold_67 - Candidate13_threshold_5) * Candidate13_rate_6) + (income - (Candidate13_threshold_67 - Candidate13_threshold_5) - (Candidate13_threshold_5 - Candidate13_threshold_4) - (Candidate13_threshold_4 - Candidate13_threshold_3) - (Candidate13_threshold_3 - Candidate13_threshold_2) - (Candidate13_threshold_2 - Candidate13_threshold_1) - Candidate13_threshold_1) * Candidate13_rate_7);


                    Tax.Text = ($"{currentTax:C}");
                    marginalR.Text = ($"{marginalRate:P1}");
                    Plan.Text = ("Candidate 1");
                }

            }
            else if (int.TryParse(Income.Text, out income) && (candidate2Button.Checked))
            {
                if (income <= Candidate2_threshold_1)
                {
                    marginalRate = Candidate2_rate_1;
                    currentTax = (income * Candidate2_rate_1);


                    Tax.Text = ($"{currentTax:C}");
                    marginalR.Text = ($"{marginalRate:P1}");
                    Plan.Text = ("Candidate 2");
                }

                else if (income <= Candidate2_threshold_2 && income > extraRateThreshold)
                {
                    marginalRate = Candidate2_rate_2;
                    currentTax = ((Candidate2_threshold_1 * Candidate2_rate_1) + ((income - Candidate2_threshold_1) * Candidate2_rate_2) + ((income - extraRateThreshold) * extraRate));


                    Tax.Text = ($"{currentTax:C}");
                    marginalR.Text = ($"{marginalRate:P1}");
                    Plan.Text = ("Candidate 2");
                }
                else if (income <= Candidate2_threshold_2 && income < extraRateThreshold)
                {
                    marginalRate = Candidate2_rate_2;
                    currentTax = ((Candidate2_threshold_1 * Candidate2_rate_1) + ((income - Candidate2_threshold_1) * Candidate2_rate_2));


                    Tax.Text = ($"{currentTax:C}");
                    marginalR.Text = ($"{marginalRate:P1}");
                    Plan.Text = ("Candidate 2");
                }

                else if (income <= Candidate2_threshold_3)
                {
                    marginalRate = Candidate2_rate_3;
                    currentTax = ((Candidate2_threshold_1 * Candidate2_rate_1) + ((Candidate2_threshold_2 - Candidate2_threshold_1) * Candidate2_rate_2) + (income - (Candidate2_threshold_2 - Candidate2_threshold_1) - Candidate2_threshold_1) * Candidate2_rate_3) + ((income - extraRateThreshold) * extraRate);


                    Tax.Text = ($"{currentTax:C}");
                    marginalR.Text = ($"{marginalRate:P1}");
                    Plan.Text = ("Candidate 2");
                }
                else if (income <= Candidate2_threshold_4)
                {
                    marginalRate = Candidate2_rate_4;
                    currentTax = ((Candidate2_threshold_1 * Candidate2_rate_1) + ((Candidate2_threshold_2 - Candidate2_threshold_1) * Candidate2_rate_2) + ((Candidate2_threshold_3 - Candidate2_threshold_2) * Candidate2_rate_3) + (income - (Candidate2_threshold_3 - Candidate2_threshold_2) - (Candidate2_threshold_2 - Candidate2_threshold_1) - Candidate2_threshold_1) * Candidate2_rate_4) + ((income - extraRateThreshold) * extraRate);


                    Tax.Text = ($"{currentTax:C}");
                    marginalR.Text = ($"{marginalRate:P1}");
                    Plan.Text = ("Candidate 2");
                }
                else if (income <= Candidate2_threshold_5)
                {
                    marginalRate = Candidate2_rate_5;
                    currentTax = ((Candidate2_threshold_1 * Candidate2_rate_1) + ((Candidate2_threshold_2 - Candidate2_threshold_1) * Candidate2_rate_2) + ((Candidate2_threshold_3 - Candidate2_threshold_2) * Candidate2_rate_3) + ((Candidate2_threshold_4 - Candidate2_threshold_3) * Candidate2_rate_4) + (income - (Candidate2_threshold_4 - Candidate2_threshold_3) - (Candidate2_threshold_3 - Candidate2_threshold_2) - (Candidate2_threshold_2 - Candidate2_threshold_1) - Candidate2_threshold_1) * Candidate2_rate_5) + ((income - extraRateThreshold) * extraRate);


                    Tax.Text = ($"{currentTax:C}");
                    marginalR.Text = ($"{marginalRate:P1}");
                    Plan.Text = ("Candidate 2");
                }
                else if (income <= Candidate2_threshold_6)
                {
                    marginalRate = Candidate2_rate_6;
                    currentTax = ((Candidate2_threshold_1 * Candidate2_rate_1) + ((Candidate2_threshold_2 - Candidate2_threshold_1) * Candidate2_rate_2) + ((Candidate2_threshold_3 - Candidate2_threshold_2) * Candidate2_rate_3) + ((Candidate2_threshold_4 - Candidate2_threshold_3) * Candidate2_rate_4) + ((Candidate2_threshold_5 - Candidate2_threshold_4) * Candidate2_rate_5) + (income - (Candidate2_threshold_5 - Candidate2_threshold_4) - (Candidate2_threshold_4 - Candidate2_threshold_3) - (Candidate2_threshold_3 - Candidate2_threshold_2) - (Candidate2_threshold_2 - Candidate2_threshold_1) - Candidate2_threshold_1) * Candidate2_rate_6) + ((income - extraRateThreshold) * extraRate);


                    Tax.Text = ($"{currentTax:C}");
                    marginalR.Text = ($"{marginalRate:P1}");
                    Plan.Text = ("Candidate 1");
                }
                else if (income <= Candidate2_threshold_7)
                {
                    marginalRate = Candidate2_rate_7;
                    currentTax = ((Candidate2_threshold_1 * Candidate2_rate_1) + ((Candidate2_threshold_2 - Candidate2_threshold_1) * Candidate2_rate_2) + ((Candidate2_threshold_3 - Candidate2_threshold_2) * Candidate2_rate_3) + ((Candidate2_threshold_4 - Candidate2_threshold_3) * Candidate2_rate_4) + ((Candidate2_threshold_5 - Candidate2_threshold_4) * Candidate2_rate_5) + ((Candidate2_threshold_6 - Candidate2_threshold_5) * Candidate2_rate_6) + (income - (Candidate2_threshold_6 - Candidate2_threshold_5) - (Candidate2_threshold_5 - Candidate2_threshold_4) - (Candidate2_threshold_4 - Candidate2_threshold_3) - (Candidate2_threshold_3 - Candidate2_threshold_2) - (Candidate2_threshold_2 - Candidate2_threshold_1) - Candidate2_threshold_1) * Candidate2_rate_7) + ((income - extraRateThreshold) * extraRate);


                    Tax.Text = ($"{currentTax:C}");
                    marginalR.Text = ($"{marginalRate:P1}");
                    Plan.Text = ("Candidate 2");
                }
                else if (income <= Candidate2_threshold_8)
                {
                    marginalRate = Candidate2_rate_8;
                    currentTax = ((Candidate2_threshold_1 * Candidate2_rate_1) + ((Candidate2_threshold_2 - Candidate2_threshold_1) * Candidate2_rate_2) + ((Candidate2_threshold_3 - Candidate2_threshold_2) * Candidate2_rate_3) + ((Candidate2_threshold_4 - Candidate2_threshold_3) * Candidate2_rate_4) + ((Candidate2_threshold_5 - Candidate2_threshold_4) * Candidate2_rate_5) + ((Candidate2_threshold_6 - Candidate2_threshold_5) * Candidate2_rate_6) + ((Candidate2_threshold_7 - Candidate2_threshold_6) * Candidate2_rate_7) + (income - (Candidate2_threshold_7 - Candidate2_threshold_6) - (Candidate2_threshold_6 - Candidate2_threshold_5) - (Candidate2_threshold_5 - Candidate2_threshold_4) - (Candidate2_threshold_4 - Candidate2_threshold_3) - (Candidate2_threshold_3 - Candidate2_threshold_2) - (Candidate2_threshold_2 - Candidate2_threshold_1) - Candidate2_threshold_1) * Candidate2_rate_8) + ((income - extraRateThreshold) * extraRate);


                    Tax.Text = ($"{currentTax:C}");
                    marginalR.Text = ($"{marginalRate:P1}");
                    Plan.Text = ("Candidate 2");
                }
                else if (income <= Candidate2_threshold_91)
                {
                    marginalRate = Candidate2_rate_9;
                    currentTax = ((Candidate2_threshold_1 * Candidate2_rate_1) + ((Candidate2_threshold_2 - Candidate2_threshold_1) * Candidate2_rate_2) + ((Candidate2_threshold_3 - Candidate2_threshold_2) * Candidate2_rate_3) + ((Candidate2_threshold_4 - Candidate2_threshold_3) * Candidate2_rate_4) + ((Candidate2_threshold_5 - Candidate2_threshold_4) * Candidate2_rate_5) + ((Candidate2_threshold_6 - Candidate2_threshold_5) * Candidate2_rate_6) + ((Candidate2_threshold_7 - Candidate2_threshold_6) * Candidate2_rate_7) + ((Candidate2_threshold_8 - Candidate2_threshold_7) * Candidate2_rate_8) + (income - (Candidate2_threshold_8 - Candidate2_threshold_7) - (Candidate2_threshold_7 - Candidate2_threshold_6) - (Candidate2_threshold_6 - Candidate2_threshold_5) - (Candidate2_threshold_5 - Candidate2_threshold_4) - (Candidate2_threshold_4 - Candidate2_threshold_3) - (Candidate2_threshold_3 - Candidate2_threshold_2) - (Candidate2_threshold_2 - Candidate2_threshold_1) - Candidate2_threshold_1) * Candidate2_rate_9) + ((income - extraRateThreshold) * extraRate);


                    Tax.Text = ($"{currentTax:C}");
                    marginalR.Text = ($"{marginalRate:P1}");
                    Plan.Text = ("Candidate 2");
                }
                else if (income > Candidate2_threshold_91)
                {
                    marginalRate = Candidate2_rate_10;
                    currentTax = ((Candidate2_threshold_1 * Candidate2_rate_1) + ((Candidate2_threshold_2 - Candidate2_threshold_1) * Candidate2_rate_2) + ((Candidate2_threshold_3 - Candidate2_threshold_2) * Candidate2_rate_3) + ((Candidate2_threshold_4 - Candidate2_threshold_3) * Candidate2_rate_4) + ((Candidate2_threshold_5 - Candidate2_threshold_4) * Candidate2_rate_5) + ((Candidate2_threshold_6 - Candidate2_threshold_5) * Candidate2_rate_6) + ((Candidate2_threshold_7 - Candidate2_threshold_6) * Candidate2_rate_7) + ((Candidate2_threshold_8 - Candidate2_threshold_7) * Candidate2_rate_8) + ((Candidate2_threshold_91 - Candidate2_threshold_8) * Candidate2_rate_9) + (income - (Candidate2_threshold_91 - Candidate2_threshold_8) - (Candidate2_threshold_8 - Candidate2_threshold_7) - (Candidate2_threshold_7 - Candidate2_threshold_6) - (Candidate2_threshold_6 - Candidate2_threshold_5) - (Candidate2_threshold_5 - Candidate2_threshold_4) - (Candidate2_threshold_4 - Candidate2_threshold_3) - (Candidate2_threshold_3 - Candidate2_threshold_2) - (Candidate2_threshold_2 - Candidate2_threshold_1) - Candidate2_threshold_1) * Candidate2_rate_10) + ((income - extraRateThreshold) * extraRate);


                    Tax.Text = ($"{currentTax:C}");
                    marginalR.Text = ($"{marginalRate:P1}");
                    Plan.Text = ("Candidate 2");
                }
            }
            else if (int.TryParse(Income.Text, out income) && (candidate3Button.Checked))
            {
                if (income <= Candidate13_threshold_1)
                {
                    marginalRate = Candidate13_rate_1;
                    currentTax = (income * (Candidate13_rate_1 -(Candidate13_rate_1 * reductionRate)));


                    Tax.Text = ($"{currentTax:C}");
                    marginalR.Text = ($"{marginalRate:P1}");
                    Plan.Text = ("Candidate 3");
                }

                else if (income <= Candidate13_threshold_2)
                {
                    marginalRate = Candidate13_rate_2;
                    currentTax = ((Candidate13_threshold_1 * (Candidate13_rate_1 -(Candidate13_rate_1 * reductionRate)) + ((income - Candidate13_threshold_1) * (Candidate13_rate_2 -(Candidate13_rate_2 * reductionRate)))));


                    Tax.Text = ($"{currentTax:C}");
                    marginalR.Text = ($"{marginalRate:P1}");
                    Plan.Text = ("Candidate 3");
                }
                else if (income <= Candidate13_threshold_3)
                {
                    marginalRate = Candidate13_rate_3;
                    currentTax = ((Candidate13_threshold_1 * (Candidate13_rate_1 - (Candidate13_rate_1 * reductionRate))) + ((Candidate13_threshold_2 - Candidate13_threshold_1) * (Candidate13_rate_2 - (Candidate13_rate_2 * reductionRate))) + (income - (Candidate13_threshold_2 - Candidate13_threshold_1) - Candidate13_threshold_1) * (Candidate13_rate_3 - (Candidate13_rate_3 * reductionRate)));


                    Tax.Text = ($"{currentTax:C}");
                    marginalR.Text = ($"{marginalRate:P1}");
                    Plan.Text = ("Candidate 3");
                }
                else if (income <= Candidate13_threshold_4)
                {
                    marginalRate = Candidate13_rate_4;
                    currentTax = ((Candidate13_threshold_1 * (Candidate13_rate_1 - (Candidate13_rate_1 * reductionRate))) + ((Candidate13_threshold_2 - Candidate13_threshold_1) * (Candidate13_rate_2 - (Candidate13_rate_2 * reductionRate))) + ((Candidate13_threshold_3 - Candidate13_threshold_2) * (Candidate13_rate_3 - (Candidate13_rate_3 * reductionRate))) + (income - (Candidate13_threshold_3 - Candidate13_threshold_2) - (Candidate13_threshold_2 - Candidate13_threshold_1) - Candidate13_threshold_1) * (Candidate13_rate_4 - (Candidate13_rate_4 * reductionRate)));


                    Tax.Text = ($"{currentTax:C}");
                    marginalR.Text = ($"{marginalRate:P1}");
                    Plan.Text = ("Candidate 3");
                }
                else if (income <= Candidate13_threshold_5)
                {
                    marginalRate = Candidate13_rate_5;
                    currentTax = ((Candidate13_threshold_1 * (Candidate13_rate_1 - (Candidate13_rate_1 * reductionRate))) + ((Candidate13_threshold_2 - Candidate13_threshold_1) * (Candidate13_rate_2 - (Candidate13_rate_2 * reductionRate))) + ((Candidate13_threshold_3 - Candidate13_threshold_2) * (Candidate13_rate_3 - (Candidate13_rate_3 * reductionRate))) + ((Candidate13_threshold_4 - Candidate13_threshold_3) * (Candidate13_rate_4 - (Candidate13_rate_4 * reductionRate))) + (income - (Candidate13_threshold_4 - Candidate13_threshold_3) - (Candidate13_threshold_3 - Candidate13_threshold_2) - (Candidate13_threshold_2 - Candidate13_threshold_1) - Candidate13_threshold_1) * (Candidate13_rate_5 - (Candidate13_rate_5 * reductionRate)));


                    Tax.Text = ($"{currentTax:C}");
                    marginalR.Text = ($"{marginalRate:P1}");
                    Plan.Text = ("Candidate 3");
                }
                else if (income <= Candidate13_threshold_67)
                {
                    marginalRate = Candidate13_rate_6;
                    currentTax = ((Candidate13_threshold_1 * (Candidate13_rate_1 - (Candidate13_rate_1 * reductionRate))) + ((Candidate13_threshold_2 - Candidate13_threshold_1) * (Candidate13_rate_2 - (Candidate13_rate_2 * reductionRate))) + ((Candidate13_threshold_3 - Candidate13_threshold_2) * (Candidate13_rate_3 - (Candidate13_rate_3 * reductionRate))) + ((Candidate13_threshold_4 - Candidate13_threshold_3) * (Candidate13_rate_4 - (Candidate13_rate_4 * reductionRate))) + ((Candidate13_threshold_5 - Candidate13_threshold_4) * (Candidate13_rate_5 - (Candidate13_rate_5 * reductionRate))) + (income - (Candidate13_threshold_5 - Candidate13_threshold_4) - (Candidate13_threshold_4 - Candidate13_threshold_3) - (Candidate13_threshold_3 - Candidate13_threshold_2) - (Candidate13_threshold_2 - Candidate13_threshold_1) - Candidate13_threshold_1) * Candidate13_rate_6);


                    Tax.Text = ($"{currentTax:C}");
                    marginalR.Text = ($"{marginalRate:P1}");
                    Plan.Text = ("Candidate 3");
                }
                else if (income > Candidate13_threshold_67)
                {
                    marginalRate = Candidate13_rate_7;
                    currentTax = ((Candidate13_threshold_1 * (Candidate13_rate_1 - (Candidate13_rate_1 * reductionRate))) + ((Candidate13_threshold_2 - Candidate13_threshold_1) * (Candidate13_rate_2 - (Candidate13_rate_2 * reductionRate))) + ((Candidate13_threshold_3 - Candidate13_threshold_2) * (Candidate13_rate_3 - (Candidate13_rate_3 * reductionRate))) + ((Candidate13_threshold_4 - Candidate13_threshold_3) * (Candidate13_rate_4 - (Candidate13_rate_4 * reductionRate))) + ((Candidate13_threshold_5 - Candidate13_threshold_4) * (Candidate13_rate_5 - (Candidate13_rate_5 * reductionRate))) + ((Candidate13_threshold_67 - Candidate13_threshold_5) * Candidate13_rate_6) + (income - (Candidate13_threshold_67 - Candidate13_threshold_5) - (Candidate13_threshold_5 - Candidate13_threshold_4) - (Candidate13_threshold_4 - Candidate13_threshold_3) - (Candidate13_threshold_3 - Candidate13_threshold_2) - (Candidate13_threshold_2 - Candidate13_threshold_1) - Candidate13_threshold_1) * Candidate13_rate_7);


                    Tax.Text = ($"{currentTax:C}");
                    marginalR.Text = ($"{marginalRate:P1}");
                    Plan.Text = ("Candidate 3");
                }
            }
        }
    }
}
 

