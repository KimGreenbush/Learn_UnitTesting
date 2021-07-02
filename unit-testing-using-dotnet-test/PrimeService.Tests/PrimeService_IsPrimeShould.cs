using System;
using Xunit;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    public class PrimeService_IsPrimeShould
    {
        // private instance to use for test
        private readonly PrimeService _primeService;

        // constructor to set private instance field
        public PrimeService_IsPrimeShould()
        {
            _primeService = new PrimeService();
        }

        // tests a method with multiple input values
        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void IsPrime_ValLessThan2_ReturnFalse(int value)
        {
            bool result = _primeService.IsPrime(value);

            Assert.False(result, $"{value} should not be prime");
        }
    }
}
