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
            int min, max, input;
            bool condition = false;
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
        }
    }
}
