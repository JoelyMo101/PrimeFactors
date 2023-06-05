using NUnit.Framework;
using System.Collections.Generic;
using Moq;
using PrimeFactors;

namespace PrimeFactorsTestProject
{
    public class DirectSearchFactorisationTests
    {
        [Test]
        public void GetPrimeFactors_InputIsPrimeNumber_ReturnsInputAsFactor()
        {
            // Arrange
            var model = new DirectSearchFactorisation();
            var inputNumber = 17;
            var expectedResult = new List<int> { inputNumber };

            // Act
            var result = model.GetPrimeFactors(inputNumber);

            // Assert
            CollectionAssert.AreEqual(expectedResult, result);
        }

        [Test]
        public void GetPrimeFactors_InputHasRepeatedPrimeFactors_ReturnsCorrectFactors()
        {
            // Arrange
            var model = new DirectSearchFactorisation();
            var inputNumber = 32;
            var expectedResult = new List<int> { 2, 2, 2, 2, 2 };

            // Act
            var result = model.GetPrimeFactors(inputNumber);

            // Assert
            CollectionAssert.AreEqual(expectedResult, result);
        }

        [Test]
        public void GetPrimeFactors_InputIsNegative_ReturnsEmpty()
        {
            // Arrange
            var model = new DirectSearchFactorisation();
            var inputNumber = -5;
            var expectedResult = new List<int>();

            // Act
            var result = model.GetPrimeFactors(inputNumber);

            // Assert
            CollectionAssert.AreEqual(expectedResult, result);
        }

        [Test]
        public void CalculatePrimeFactors_InputIsZero_ReturnsEmpty()
        {
            // Arrange
            var model = new DirectSearchFactorisation();
            var inputNumber = 0;
            var expectedResult = new List<int>();

            // Act
            var result = model.GetPrimeFactors(inputNumber);

            // Assert
            CollectionAssert.AreEqual(expectedResult, result);
        }

        [Test]
        public void GetPrimeFactors_InputIsOne_ReturnsEmpty()
        {
            // Arrange
            var model = new DirectSearchFactorisation();
            var inputNumber = 1;
            var expectedResult = new List<int>();

            // Act
            var result = model.GetPrimeFactors(inputNumber);

            // Assert
            CollectionAssert.AreEqual(expectedResult, result);
        }
    }
}