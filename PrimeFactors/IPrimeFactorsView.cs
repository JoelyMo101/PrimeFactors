using System.Collections.Generic;

namespace PrimeFactors
{
    public interface IPrimeFactorsView
    {
        void DisplayAlgorithmName(string name);
        void DisplayPrimeFactors(int number, List<int> factors);
    }
}