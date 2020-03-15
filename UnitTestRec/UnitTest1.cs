using Lab1_arch;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestRec
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestRec()
        {
            //Arrange
            int a = 1;
            int b = 50;
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

        [TestMethod]
        public void TestRec2()
        {
            //Arrange
            int a = 1;
            int b = 1000;
            double exp_res = 4991449.82644873;
            int n = 100000;
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
