using System;
using System.Collections.Generic;

namespace PrimeFactors
{
    public class PrimeFactorsView : IPrimeFactorsView
    {
        public void DisplayAlgorithmName(string name)
        {
            Console.WriteLine($"Using {name}");
        }

        public void DisplayPrimeFactors(int number, List<int> factors)
        {
            Console.WriteLine($"Prime factors of {number}: [{string.Join(", ", factors)}]");
        }
    }
}