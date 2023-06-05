
using System.Collections.Generic;

namespace PrimeFactors
{
    public interface IPrimeFactorsModel
    {
        string Name { get; }
        List<int> GetPrimeFactors(int number);
    }
}