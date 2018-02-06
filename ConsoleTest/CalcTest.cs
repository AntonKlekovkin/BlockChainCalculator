using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleCalc;

namespace ConsoleTest
{
    [TestClass]
    public class CalcTest
    {
        [TestMethod]
        public void TestSum()
        {
            // Arrange
            var calc = new Calc();
            var x = 10;
            var y = 5;
            
            // Act
            var res_sum = calc.sum(x, y);
            
            //Assert
            Assert.AreEqual(15, res_sum);
        }

        [TestMethod]
        public void TestSub()
        {
            // Arrange
            var calc = new Calc();
            var x = 10;
            var y = 5;

            // Act
            var res_sub = calc.sub(x, y);

            //Assert
            Assert.AreEqual(5, res_sub);
        }

        [TestMethod]
        public void TestMul()
        {
            // Arrange
            var calc = new Calc();
            var x = 10;
            var y = 5;
            
            // Act
            var res_mul = calc.mul(x, y);
            
            //Assert
            Assert.AreEqual(50, res_mul);
         }

        [TestMethod]
        public void TestDiv()
        {
            // Arrange
            var calc = new Calc();
            var x = 10;
            var y = 5;
            
            // Act
            var res_div = calc.div(x, y);
            
            //Assert
            Assert.AreEqual(2, res_div);
        }

        [TestMethod]
        public void TestSqrt()
        {
            // Arrange
            var calc = new Calc();
            var z = 25;

            // Act
            var res_sqrt = calc.sqrt(z);

            //Assert
            Assert.AreEqual(5, res_sqrt);
        }
    }
}
