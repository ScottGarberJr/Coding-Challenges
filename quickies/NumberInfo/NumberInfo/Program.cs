using System;

namespace NumberInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            char status = 'y';
            while (status == 'y')
            {
                Console.WriteLine("This program can tell you info about the number you input \nInput a number: ");
                try
                {
                    double numInput = Convert.ToDouble(Console.ReadLine());
                    GetNumInfo(numInput);
                }
                catch
                {
                    Console.WriteLine("Invalid entry. Needs to be a number.");
                }

                Console.WriteLine("Would you like to continue? (y or n): ");
                status = Convert.ToChar(Console.ReadLine());
            }
            
        }
        static void GetNumInfo(double num)
        {
            string posNeg = "";
            string evenOdd = "";

            if(num < 0) { posNeg = "a negative,"; }
            else if (num == 0) { posNeg = "an"; }
            else { posNeg = "a positive,"; }

            if (num % 2 == 0) { evenOdd = "even"; }
            else { evenOdd = "odd"; }

            Console.WriteLine($"{num} is {posNeg} {evenOdd} number.");
        }
    }
}

