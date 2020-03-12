using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab1_arch;

namespace UnitTestRec
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestRec()
        {
            //Arrange
            double a = 1;
            double b = 50;
            double exp_res = 12219.0850405774;
            int n = 1000;
            Rectangle rec1 = new Rectangle();
            double h = (b - a) / n;

            //Act
            Func<double, double> x = y => rec1.Calculate(n, a, b);

            //Assert
            double actual = x(n);
            Assert.AreEqual(exp_res, actual, 0.01);
        }
    }
}
