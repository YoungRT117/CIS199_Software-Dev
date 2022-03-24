/*Grading ID: R3555
Lab#:Lab 7
Due Date: 03/29/2020
Course Section: CIS 199-01
Brief Description: You will enter the parameter which is the stars per side, and then the "parameter" will convert it to
an int within the "do" method then you'll have a "while" method if parameter is greater than 0 which in turn starts 
the void "ShowSquareOfStars" method. Then within this method it'll run two for methods stating the x and y are both greater
then the parameter, thus outputting the 4 rows and columns of stars.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            int parameter = 0;
            char numStars = '*';

            do
            {
                Console.Write("Enter number of stars per side desired: ");
                parameter = Convert.ToInt32(Console.ReadLine());
                ShowSquareOfStars(parameter, numStars);
            }
            while (parameter > 0);
        }
        
        public static void ShowSquareOfStars(int parameter, char numStars)
        {
            for (int x = 0; x < parameter; x++)
            {
                for (int y = 0; y < parameter; y++)
                {
                    Console.Write(numStars);
                }
                Console.WriteLine();
            }
        }
    }
}
    
