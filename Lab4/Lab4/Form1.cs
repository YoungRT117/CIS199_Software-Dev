/*Grading ID: R3555
Lab#:Lab 4
Due Date: 02/16/2020
Course Section: CIS 199-01
Brief Description:
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

namespace Lab4
{
    public partial class Admission : Form
    {
        public Admission()
        {
            InitializeComponent();          
        }
        /*Event Handler is created so that when you click the calculate button, it will run the program
         * and calculate if your application is rejected or approved and display a message within the
         * "AcceptOReject" Label.*/
        private void Calculate_Click(object sender, EventArgs e)
        {
            double GPA; //TryParse if statement for error message if incorrect gpa values are given
            uint Admin; //TryParse if statement for error message if incorrect admission values are given
            double GPAInput; //Convert inputed GPA to floating-point value
            uint AdminInput; //Convert inputed Admission to Non-Negative integer
#pragma warning disable CS0168 // The variable 'AcceptedT' is declared but never used
            float AcceptedT; //Calculate running total for Accepted Applications
#pragma warning restore CS0168 // The variable 'AcceptedT' is declared but never used
#pragma warning disable CS0168 // The variable 'RejectedT' is declared but never used
            float RejectedT; //Calculate running total for Rejected Applications
#pragma warning restore CS0168 // The variable 'RejectedT' is declared but never used


            GPAInput = Convert.ToDouble(HSGpaInput.Text);
            AdminInput = Convert.ToUInt32(ATSInput.Text);


            if (double.TryParse(HSGpaInput.Text, out GPA))
                if (GPA < 0.0 || GPA > 4.0)
                    MessageBox.Show("Error! Please input a valid GPA");
            if (uint.TryParse(ATSInput.Text, out Admin))
                if (Admin < 0 || Admin > 100)
                    MessageBox.Show("Error! Please input a valid Admission Test Score");

            if ((GPAInput >= 3.0 && AdminInput >= 60) || GPAInput < 3.0 && AdminInput >= 80)
                AcceptOrReject.Text = "Accept";
            else
                AcceptOrReject.Text = "Reject";

            

        }
    }
}
