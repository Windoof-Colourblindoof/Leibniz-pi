using DecimalMath;
using System;
using System.Globalization;

namespace Leibnizreihe
{
    class Leibnizreihe
    {
        static void Main()
        {
            while (true)
            {
                decimal Sum = 0;
                decimal Pi;
                long Iterations;
                long UserInput;
                Console.Title = "Leibniz formula for Pi in C#";
                Console.WriteLine("How many iterations should be executed?");
                UserInput = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Pi is getting approximated, please wait...");
                var Stopwatch = System.Diagnostics.Stopwatch.StartNew();
                for (Iterations = 0; Iterations < UserInput; Iterations++)
                {
                    Sum += DecimalEx.Pow(-1, Iterations) / (2 * Iterations + 1);
                }
                Pi = Sum * 4;
                Stopwatch.Stop();
                Console.WriteLine("Pi = " + Pi + "\nWith " + Iterations.ToString("N0", new CultureInfo("de-DE")) + " added fractions.");
                Console.WriteLine("Algorithm was executed in: " + Stopwatch.ElapsedMilliseconds.ToString("N", new CultureInfo("de-DE")) + " milliseconds.");
            }
        }
    }
}
