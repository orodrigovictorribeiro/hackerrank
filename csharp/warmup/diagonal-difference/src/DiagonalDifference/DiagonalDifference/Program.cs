using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DiagonalDifference
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int matrixQuantity = 0;
            List<string> maxtriValues = new List<string>();
            
            Console.WriteLine("Enter the number of square matrix to calculate the diagonal difference for each one");
            matrixQuantity = Convert.ToInt32(Console.ReadLine() ?? "");
            
            if (matrixQuantity == 0)
                return;
            
            for (int i = 0; i < matrixQuantity; i++)
            {
                Console.WriteLine("Enter the integer numbers separated by space");
                maxtriValues.Add(Regex.Replace(Console.ReadLine(), @"[^\d]", ""));
            }

            var ratios = CalculateSquareMatrixSumDifference(maxtriValues);
        }

        public static int CalculateSquareMatrixSumDifference(List<string> matrixValues)
        {
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < matrixValues.Count; i++)
            {
                string[] matrix = matrixValues[i].Trim().Split(' ');
                leftSum+= Convert.ToInt32(matrix[(i+1)]);
                rightSum += Convert.ToInt32(matrix[matrix.Length - (1 + i)]);
            }

            return Math.Abs(leftSum - rightSum);
        }
    }
}
