using System.Collections.Generic;

namespace PrimeFactors
{
    public class PrimeFactorsViewModel : IPrimeFactorsViewModel
    {
        private readonly IPrimeFactorsView _view;
        private readonly IPrimeFactorsModel _model;

        public PrimeFactorsViewModel(IPrimeFactorsView view, IPrimeFactorsModel model)
        {
            _view = view;
            _model = model;
        }

        public void CalculatePrimeFactors(int number)
        {
            List<int> factors = _model.GetPrimeFactors(number);
            _view.DisplayAlgorithmName(_model.Name);
            _view.DisplayPrimeFactors(number, factors);
        }
    }
}