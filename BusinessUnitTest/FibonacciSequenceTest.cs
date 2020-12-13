using Microsoft.VisualStudio.TestTools.UnitTesting;
using FibonnaciSequence.ClassLibrary;

namespace BusinessUnitTest
{
    [TestClass]
    public class FibonacciSequenceUnitTest
    {
        [TestMethod]
        public void ReturnFibonacciNumberWhenInputIsLessThanOne ()
        {
            FibonacciCalculator fibonacciCalculator = new FibonacciCalculator();
            const int ExpectedResult = -1;
            var result = fibonacciCalculator.Fibonacci(0);
            Assert.AreEqual(ExpectedResult, result);
        }

        [TestMethod]
        public void ReturnFibonacciNumberWhenInputIsGreaterThanOneHundred()
        {
            FibonacciCalculator fibonacciCalculator = new FibonacciCalculator();
            const int ExpectedResult = -1;
            var result = fibonacciCalculator.Fibonacci(1000);
            Assert.AreEqual(ExpectedResult, result);
        }

        [TestMethod]
        public void ReturnFibonacciNumberWhenRegularCase()
        {
            FibonacciCalculator fibonacciCalculator = new FibonacciCalculator();
            const int ExpectedResult = 2;
            var result = fibonacciCalculator.Fibonacci(3);
            Assert.AreEqual(ExpectedResult, result);
        }
        [TestMethod]
        public void ReturnFibonacciNumberWhenTestFails()
        {
            FibonacciCalculator fibonacciCalculator = new FibonacciCalculator();
            const int ExpectedResult = -1;
            var result = fibonacciCalculator.Fibonacci(10);
            Assert.AreEqual(ExpectedResult, result);
        }
    }
}
