using System;
using System.Linq;

namespace compare_the_triplets
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Alice ratings:");
            string[] tripletAlice = (Console.ReadLine() ?? "").Trim().Split(' ');
            
            Console.WriteLine("Enter Bob ratings:");
            string[] tripletBob = (Console.ReadLine() ?? "").Trim().Split(' ');

            Console.WriteLine(CompareTriplets(tripletAlice, tripletBob));
        }

        public static string CompareTriplets(string[] tripletAliceTokens, string[] tripletBobTokens)
        {
            tripletAliceTokens = tripletAliceTokens.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            tripletBobTokens = tripletBobTokens.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            
            if (tripletAliceTokens == null || 
                tripletAliceTokens.Length < 3 || 
                tripletBobTokens == null || 
                tripletBobTokens.Length < 3 ||
                tripletAliceTokens.Length != tripletBobTokens.Length
            )
                return $"0 0";

            int aliceScore = 0;
            int bobScore = 0;
            int[] tripletAlice = Array.ConvertAll(tripletAliceTokens, s => int.Parse(s));
            int[] tripletBob = Array.ConvertAll(tripletBobTokens, s => int.Parse(s));

            for (int index = 0; index < tripletAlice.Length; index ++)
            {
                if (tripletAlice[index] > tripletBob[index])
                    aliceScore += 1;
                
                if (tripletBob[index] > tripletAlice[index])
                    bobScore += 1;
            }

            return $"{aliceScore} {bobScore}";
        }
    }
}
