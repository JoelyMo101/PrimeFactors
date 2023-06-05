using System;
using Unity;

namespace PrimeFactors
{
    public class Program
    {
        static void Main()
        {
            var container = new UnityContainer();
            container.RegisterType<IPrimeFactorsView, PrimeFactorsView>();
            container.RegisterType<IPrimeFactorsViewModel, PrimeFactorsViewModel>();
            container.RegisterType<IPrimeFactorsModel, DirectSearchFactorisation>();

            var viewModel = container.Resolve<IPrimeFactorsViewModel>();

            Console.WriteLine("Enter a number to factorize:");

            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
                viewModel.CalculatePrimeFactors(number);
            }
            catch (FormatException)
            {
                Console.WriteLine("Not a valid number");
            }
        }
    }
}