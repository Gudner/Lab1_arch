using Lab1_arch;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace UnitTestTrap
{
    [TestClass]
    public class UnitTestTrap
    {
        [TestMethod]
        public async Task Integral_a1_b50_n10000()
        {
            //Arrange
            int a = 1;
            int b = 50;
            CancellationToken token;
            Progress<int> progress = new Progress<int>();
            double exp_res = 12219.0850405774;
            int n = 10000;
            Trapeze trap1 = new Trapeze();
            double h = (double)(b - a) / n;

            //Act
            double actual = await trap1.PCalculate(n, a, b, token, progress, (z) =>
            {
                return (10 * z) - Math.Log(14 * z);
            });

            //Assert
            Assert.AreEqual(exp_res, actual, 0.01);
        }

        [TestMethod]

        public void Integral_aIsBiggerThanb_ReturnException()
        {
            //Arrange
            int a = 50;
            int b = 1;
            CancellationToken token;
            Progress<int> progress = new Progress<int>();
            string exp_res = "Значение не попадает в ожидаемый диапазон.";
            int n = 10000;
            Trapeze trap1 = new Trapeze();

            //Act
            double act = trap1.Calculate(n, a, b, token, progress, (z) =>
            {
                return (10 * z) - Math.Log(14 * z);
            }).Result;
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
            CancellationToken token;
            Progress<int> progress = new Progress<int>();
            string exp_res = "Значение не попадает в ожидаемый диапазон.";
            int n = 0;
            Trapeze trap1 = new Trapeze();

            //Act
            double act = trap1.Calculate(n, a, b, token, progress, (z) =>
            {
                return (10 * z) - Math.Log(14 * z);
            }).Result;
            //Assert
            string actual = trap1.ErrorInformation;
            Assert.AreEqual(exp_res, actual);
        }
        
    }
}
