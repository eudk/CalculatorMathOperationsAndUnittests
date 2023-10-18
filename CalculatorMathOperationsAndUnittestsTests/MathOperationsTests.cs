using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{

    [TestClass]
    public class MathOperationsTests
    {
        [TestMethod]
        public void TestAddition()
        {
            // Arrange
            MathOperations math = new MathOperations();
            int a = 5;
            int b = 3;

            // Act
            int result = math.Add(a, b);

            // Assert
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void TestSubtraction()
        {
            // Arrange
            MathOperations math = new MathOperations();
            int a = 8;
            int b = 3;

            // Act
            int result = math.Subtract(a, b);

            // Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestMultiplication()
        {
            // Arrange
            MathOperations math = new MathOperations();
            int a = 6;
            int b = 4;

            // Act
            int result = math.Multiply(a, b);

            // Assert
            Assert.AreEqual(24, result);
        }

        [TestMethod]
        public void TestDivision()
        {
            // Arrange
            MathOperations math = new MathOperations();
            int a = 10;
            int b = 2;

            // Act
            double result = math.Divide(a, b);

            // Assert
            Assert.AreEqual(5.0, result, 0.001); //testing doubles
        }

        [TestMethod]
        public void TestDivisionByZero()
        {
            // Arrange
            MathOperations math = new MathOperations();
            int a = 5;
            int b = 0;

            // Act and Assert
            Assert.ThrowsException<DivideByZeroException>(() => math.Divide(a, b)); //testing exceptions
        }
    }
}