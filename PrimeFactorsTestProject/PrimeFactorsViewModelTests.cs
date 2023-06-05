using NUnit.Framework;
using System.Collections.Generic;
using Moq;
using PrimeFactors;

namespace PrimeFactorsTestProject
{
    public class PrimeFactorsViewModelTests
    {
        [Test]
        public void CalculatePrimeFactors_ValidNumber_CallsModelAndUpdatesView()
        {
            // Arrange
            var mockView = new Mock<IPrimeFactorsView>();
            var mockModel = new Mock<IPrimeFactorsModel>();
            mockModel.Setup(m => m.GetPrimeFactors(It.IsAny<int>())).Returns(new List<int> { 2, 2, 2, 3 });

            var viewModel = new PrimeFactorsViewModel(mockView.Object, mockModel.Object);

            // Act
            viewModel.CalculatePrimeFactors(24);

            // Assert
            mockModel.Verify(m => m.GetPrimeFactors(24), Times.Once);
            mockView.Verify(v => v.DisplayPrimeFactors(24, new List<int> { 2, 2, 2, 3 }), Times.Once);
        }
    }
}