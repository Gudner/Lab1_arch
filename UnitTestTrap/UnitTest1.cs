using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab1_arch;

namespace UnitTestTrap
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int a = 1;
            int b = 50;
            double exp_res = 12219.0850405774;
            int n = 10000;
            Trapeze trap1 = new Trapeze();
            double h = (b - a) / n;

            //Act
            Func<double, double> x = y => trap1.Calculate(n, a, b);

            //Assert
            double actual = x(n);
            Assert.AreEqual(exp_res, actual, 0.01);
        }
    }
}
