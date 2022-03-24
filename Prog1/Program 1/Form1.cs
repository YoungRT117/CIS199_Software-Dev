/*Grading ID: R3555
Program #1
Due Date: 02/02/2020
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

namespace Program_1
{
    public partial class Program1 : Form
    {
        public Program1()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            double width; //Converts Width input data to Double
            double length; //Converts Legth input data to Double
            double price; //Converts Price input data to Double
            int LayerPadding; //Converts Padding input data to Double
            int Room; //Converts First Room input data to Double
            double SqYard; //Finds SqYards from the width and length
            double SqYard1; //Changes SqFeet to SqYard
            double CCost; //Computes Carpet Cost
            double PCost; //Computes Padding Cost
            double LCost; //Computes Labor Cost
            double TCost; //Computes Total Cost
            const double Excess = .10; //Named Constant for Excess Waste
            const double PPrice = 2.50; //Named Constant for Padding Constant
            const int conversion = 9; //Named Constant for SqFeet to SqYard
            const double FRoom = 75.00; //Named Constant for First Room Constant
            const double LPrice = 4.25; //Named Constant for Labor Constant


            width = Convert.ToDouble(MaxWidthInput.Text);
            length = Convert.ToDouble(MaxLengthInput.Text);
            SqYard = (width * length) / conversion;
            SqYard1 = Math.Round(SqYard, 1);
            YardOutput.Text = $"{SqYard1:F1}";

            price = Convert.ToDouble(CarpetInput.Text);
            CCost = ((price * SqYard) * Excess) + (price * SqYard);
            CarpetOutput.Text = $"{CCost:C}";

            LayerPadding = Convert.ToInt32(PaddingInput.Text);
            PCost = ((PPrice * SqYard * LayerPadding) * Excess) +(PPrice * SqYard * LayerPadding);
            PaddingOutput.Text = $"{PCost:C}";

            Room = Convert.ToInt32(FirstRoomInput.Text);
            LCost = (Room * FRoom) + (LPrice * SqYard);
            LaborOutput.Text = $"{LCost:C}";

            TCost = CCost + PCost + LCost;
            TotalOutput.Text = $"{TCost:C}";



        }
    }
}
