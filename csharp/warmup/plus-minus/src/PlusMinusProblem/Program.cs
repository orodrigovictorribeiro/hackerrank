using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace PlusMinusProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the integer numbers separated by space");

            var input = Console.ReadLine();
            input = new Regex(@"[^\d]").Replace(input, "");
            
            var ratios = CalculateRatioOfNegativePositiveAndZero(input.Trim().Split(' '));

            foreach (var ratio in ratios)
                Console.WriteLine(ratio);
        }

        public static string[] CalculateRatioOfNegativePositiveAndZero(string[] inputNumbers)
        {
            float size = (float)inputNumbers.Length;
            int[] numbers = Array.ConvertAll(inputNumbers, s => int.Parse(s));

            return new string[3] { 

                ((float)numbers.Count(x => x > 0) / size).ToString("F6"),
                ((float)numbers.Count(x => x < 0) / size).ToString("F6"),
                ((float)numbers.Count(x => x == 0) / size).ToString("F6")
            };
        }
    }
}
