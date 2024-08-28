using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatorv1._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable for entry numbers
            int num1;
            int num2;
            string answer;
            int result;


            //Welcome text
            Console.WriteLine("Welcome to the calculator program");

            //code to insert num1
            Console.WriteLine("Enter your first number");
            num1 = Convert.ToInt32(Console.ReadLine());

            //code to insert num2
            Console.WriteLine("Enter your second number");
            num2 = Convert.ToInt32(Console.ReadLine());

            //code for operation
            Console.WriteLine("What type of operation would you like to do?");
            Console.WriteLine("Enter a for addition, s for subtraction, m for multiplication, any other key for division");
            answer = Console.ReadLine();

            if(answer == "a")
            {
                result = num1 + num2;
            } 
            else if(answer == "s") {
                result = num1 - num2;
            }
            else if(answer == "m") {
                result = num1 * num2;
            }
            else
            {
               result = num1 / num2;
            }
           
            Console.WriteLine("The result is " + result);
            Console.WriteLine("Thank you for using me, calculatorv1.0");
            Console.ReadKey();

        }
    }
}
