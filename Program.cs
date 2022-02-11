// Author: Vanny Ches
// Date: 2/8/2022
using System;

namespace T3_UsingIterativeStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            double usd;
            double conversion;
            //Ask customer to input integer value between 5 and 25
            Console.Write("Enter a Canadian Dollars increment value:");
            
            //Use try catch to confirm user input
            try 
            {
             string input = Console.ReadLine();
             int inputvalue = int.Parse(input);
                if (inputvalue > 5 && inputvalue <= 25)
                {
                    conversion = 0.792367;
                    Console.WriteLine("CAD Increment Value = " + inputvalue.ToString() + "\n");
                    //Table of Header
                    Console.WriteLine("CAD" + "\t" + "US$");

                    //Here is the For loop
                    for (int i = 0; i <= 200; i = i + inputvalue)
                    {
                        usd = i * conversion;
                        string message = i.ToString() + "\t" + usd;
                        Console.WriteLine(message);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Please enter a CAD increment between 5 and 25");
                Console.WriteLine("Press any key to exit the program.");
                Console.ReadKey(true);
            }//End of catch
        }
    }
}
