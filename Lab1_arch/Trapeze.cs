using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_arch
{
    class Trapeze
    {
        private const double a = 1.0;
        private const double b = 100000.0;
        private static double n;
        private double h = (a - b) / n;

        public double Func(double x)
        {
            return (10 * x) - Math.Log(14 * x);
        }

        public void GetN()
        {

        }
    }
}