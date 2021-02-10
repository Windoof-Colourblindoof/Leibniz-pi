using DecimalMath;
using System;
using System.Globalization;

namespace Leibnizreihe
{
    class Leibnizreihe
    {
        static void Main()
        {
            Console.Title = "Leibniz formula for Pi in C#";
            decimal Pi;
            while (true)
            {
                decimal UserInput = GetInput();
                Pi = CalPi(UserInput);
                Console.WriteLine("Pi = " + Pi + "\n");
            }
        }

        private static decimal GetInput()
        {
            decimal Input;
            while (true)
            {
                try
                {
                    Console.WriteLine("How many iterations should be executed?");
                    Input = Convert.ToDecimal(Console.ReadLine());
                    return Input;
                }
                catch
                {
                    Console.WriteLine("Your input was not valid, please try again.\n");
                }
            }
        }

        private static decimal CalPi(decimal Input)
        {
            decimal Pi = 0;
            Console.WriteLine("Pi is getting approximated, please wait...\n");
            for (decimal Iterations = 0; Iterations < Input; Iterations++)
            {
                Pi += DecimalEx.Pow(-1, Iterations) / (2 * Iterations + 1);
            }
            return Pi * 4;
        }
    }
}
