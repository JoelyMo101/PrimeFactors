using System;
using System.Collections;
using System.Collections.Generic;

namespace PrimeFactors
{
    public class DirectSearchFactorisation : IPrimeFactorsModel
    {
        public string Name => "Direct search factorisation";

        public List<int> GetPrimeFactors(int number)
        {
            Eratosthenes eratosthenes = new();
            List<int> factors = new();
            if (number < 1)
            {
                return factors;
            }
            foreach (int prime in eratosthenes)
            {
                while (number % prime == 0)
                {
                    number /= prime;
                    factors.Add(prime);
                }

                if (number == 1)
                {
                    break;
                }
            }
            return factors;
        }
    }

    public class Eratosthenes : IEnumerable<int>
    {
        private static List<int> _primes = new();
        private int _lastChecked;

        public Eratosthenes()
        {
            _primes.Add(2);
            _lastChecked = 2;
        }

        private static bool IsPrime(int checkValue)
        {
            bool isPrime = true;

            foreach (int prime in _primes)
            {
                if ((checkValue % prime) == 0 && prime <= Math.Sqrt(checkValue))
                {
                    isPrime = false;
                    break;
                }
            }

            return isPrime;
        }

        public IEnumerator<int> GetEnumerator()
        {
            foreach (int prime in _primes)
            {
                yield return prime;
            }

            while (_lastChecked < int.MaxValue)
            {
                _lastChecked++;

                if (IsPrime(_lastChecked))
                {
                    _primes.Add(_lastChecked);
                    yield return _lastChecked;
                }
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}