using dotnet_core_xunit.Helpers;
using Xunit;

namespace dotnet_core_xunit_test
{
    /// <summary>
    /// Standalone dummy tests (no fixtures, independent of UserControllerTest) so Test
    /// Intelligence has a second test file with its own call-graph chain
    /// (DummyCalculatorTests.cs -> Helpers/Calculator.cs). All of these are expected to pass.
    /// </summary>
    public class DummyCalculatorTests
    {
        [Fact]
        public void Add_ReturnsSum_Test()
        {
            var calculator = new Calculator();

            Assert.Equal(5, calculator.Add(2, 3));
            Assert.Equal(0, calculator.Add(-4, 4));
        }

        [Fact]
        public void Multiply_ReturnsProduct_Test()
        {
            var calculator = new Calculator();

            Assert.Equal(12, calculator.Multiply(3, 4));
            Assert.Equal(0, calculator.Multiply(0, 99));
        }

        [Fact]
        public void IsEven_DetectsParity_Test()
        {
            var calculator = new Calculator();

            Assert.True(calculator.IsEven(10));
            Assert.False(calculator.IsEven(7));
        }
    }
}
