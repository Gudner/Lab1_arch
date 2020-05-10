using Lab1_arch;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace UnitTestRec
{
    [TestClass]
    public class UnitTestRec
    {
        [TestMethod]
        public void Integral_a1_b50_n1000()
        {
            //Arrange
            int a = 1;
            int b = 50;
            CancellationToken token;
            Progress<int> progress = new Progress<int>();
            double exp_res = 12219.0850405774;
            int n = 1000;
            Rectangle rec1 = new Rectangle();
            double h = (double)(b - a) / n;

            //Act
            double actual = rec1.Calculate(n, a, b, token, progress, (z) =>
            {
                return (10 * z) - Math.Log(14 * z);
            }).Result;

            //Assert
            Assert.AreEqual(exp_res, actual, 0.01);
        }

        [TestMethod]
        public void Integral_a1_b1000_n100000()
        {
            //Arrange
            int a = 1;
            int b = 1000;
            CancellationToken token;
            Progress<int> progress = new Progress<int>();
            double exp_res = 4991449.82644873;
            int n = 100000;
            Rectangle rec1 = new Rectangle();
            double h = (double)(b - a) / n;

            //Act
            double actual = rec1.Calculate(n, a, b, token, progress, (z) =>
            {
                return (10 * z) - Math.Log(14 * z);
            }).Result;

            //Assert
            Assert.AreEqual(exp_res, actual, 0.01);
        }
    }

}
