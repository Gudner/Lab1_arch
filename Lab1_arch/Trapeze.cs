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

        public double Func(double x)
        {
            return (10 * x) - Math.Log(14 * x);
        }

        public double T(int n)
        {
            double h = (b - a) / n;
            double res = 0;
            
            for (int i = 1; i < n - 1; i++)
            {
                res += h * (Func(a + h * i));
            }

            res += (h * ((Func(a) + Func(b)) / 2));

            return res;
        }
    }
}