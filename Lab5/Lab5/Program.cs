/*Grading ID: R3555
Lab#:Lab 5
Due Date: 03/02/2020
Course Section: CIS 199-01
Brief Description: This code creates a loop to enter a temperature from -20 to 130 and 999 to stop.
                   We use the while method and if else for each possible given input. To continue within the
                   if statement we make sure that the inputs are valid and if not it will result in an error
                   and ask the user to input a value temperature. At the end of the if statement we add to the count 
                   of temperatures so in the end it'll display the amount of valid temperatures inputted and the
                   average of those temperatures!
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalTemp = 0.0;
            int count = 0;

            Console.WriteLine("Enter temperature from -20 to 130 (999 to stop)");

            while (true)
            { 
                Console.Write("Enter Temperature: ");

                int temp = Int32.Parse(Console.ReadLine());

                if (temp == 999)
                    break;
                else if (temp < -20 || temp > 130 ) 
                {
                    Console.Write("Valid temperatures range from -20 to 130. Please reenter temperature.\n");
                    continue; 
                }
                else
                    totalTemp += temp;
                count++;
            }
            double average = totalTemp / (double)count;
            
            Console.WriteLine($"You entered {count} valid temperatures.");
            Console.WriteLine($"The mean temperature is {average} degrees.");

        }           
    }
}
