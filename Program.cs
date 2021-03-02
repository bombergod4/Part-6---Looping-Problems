using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_6___Looping_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            int min, max, input, scoreTotal, scorePass, score, odd;
            bool condition = false;
            string percent = "Sample Text";
            Random generator = new Random();
            Console.WriteLine("");
            Console.WriteLine("Prompter");
            while (condition == false)
            {
                Console.WriteLine("");
                Console.WriteLine("Please enter a minimum integer");
                if (Int32.TryParse(Console.ReadLine(), out min) == true)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Please enter a maximum integer");
                }
                else
                {
                    Console.WriteLine("Error: Valid Integer not inputted");
                }
                if ((Int32.TryParse(Console.ReadLine(), out max) == true) && min < max)
                {
                    while (condition == false)
                    {
                        Console.WriteLine("Please enter an integer between " + min + " and " + max);
                        if (((Int32.TryParse(Console.ReadLine(), out input) == true) && input >= min) && input <= max)
                        {
                            Console.WriteLine("Congratulations!");
                            condition = true;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid number");
                            Console.WriteLine("");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Error: Valid Integer not inputted");
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Percent Passing");
            condition = false;
            scorePass = 0;
            scoreTotal = 0;
            while (condition == false)
            {
                Console.WriteLine("Please enter your scores (between 0-100). Type 'done' to finish.");
                percent = Console.ReadLine();
                if (((Int32.TryParse(percent, out score) == true) && score >= 70) && score <= 100)
                {
                    scoreTotal += 1;
                    scorePass += 1;
                    Console.WriteLine("You've entered " + scoreTotal + " scores.");
                }
                else if (((Int32.TryParse(percent, out score) == true) && score >= 0) && score <= 100)
                {
                    scoreTotal += 1;
                    Console.WriteLine("You've entered " + scoreTotal + " scores.");
                }
                else if (percent == "done")
                {
                    Console.WriteLine("You passed " + ((double)scorePass / scoreTotal * 100) + "% of your courses");
                    condition = true;
                }
                else
                    Console.WriteLine("Enter a number between 0 and 100");
            }
            Console.WriteLine("");
            Console.WriteLine("Odd Sum");
            odd = 1;
            Console.WriteLine("Please enter an integer");
            if (Int32.TryParse(Console.ReadLine(), out max) == true)
            {
                for (int i = 1; i <= max/2; i += 2)
                {
                    odd += 2;
                    Console.WriteLine(odd);
                }
                Console.WriteLine("The sum of all odd numbers below " + max + " is " + odd);
            }
            else
                Console.WriteLine("Enter a number");





            //Console.WriteLine("");
            //Console.WriteLine("Random Numbers");
            //while (condition == false)
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine("Please enter a minimum integer");
            //    if (Int32.TryParse(Console.ReadLine(), out min) == true)
            //    {
            //        Console.WriteLine("");
            //        Console.WriteLine("Please enter a maximum integer");

            //    }
            //    else
            //    {
            //        Console.WriteLine("Error: Valid Integer not inputted");

            //    }
            //    if ((Int32.TryParse(Console.ReadLine(), out max) == true) && min < max)

            
        }
    }
}
