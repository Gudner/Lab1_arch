using Lab1_arch;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestTrap
{
    [TestClass]
    public class UnitTestTrap
    {
        [TestMethod]
        public void Integral_a1_b50_n10000()
        {
            //Arrange
            int a = 1;
            int b = 50;
            double exp_res = 12219.0850405774;
            int n = 10000;
            Trapeze trap1 = new Trapeze();
            double h = (double)(b - a) / n;

            //Act
            Func<double, double> x = y => trap1.Calculate(n, a, b);

            //Assert
            double actual = x(n);
            Assert.AreEqual(exp_res, actual, 0.01);
        }

        [TestMethod]

        public void Integral_aIsBiggerThanb_ReturnException()
        {
            //Arrange
            int a = 50;
            int b = 1;
            string exp_res = "Значение не попадает в ожидаемый диапазон.";
            int n = 10000;
            Trapeze trap1 = new Trapeze();

            //Act
            Func<double, double> x = y => trap1.Calculate(n, a, b);
            x(n);
            //Assert
            string actual = trap1.ErrorInformation;
            Assert.AreEqual(exp_res, actual);
        }

        [TestMethod]

        public void Integral_nEqualsZero_ReturnException()
        {
            //Arrange
            int a = 1;
            int b = 50;
            string exp_res = "Значение не попадает в ожидаемый диапазон.";
            int n = 0;
            Trapeze trap1 = new Trapeze();

            //Act
            Func<double, double> x = y => trap1.Calculate(n, a, b);
            x(n);
            //Assert
            string actual = trap1.ErrorInformation;
            Assert.AreEqual(exp_res, actual);
        }
        
    }
}
