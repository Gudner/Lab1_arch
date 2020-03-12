using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_arch
{
    class Rectangle : Figure
    {
        const double a = 1;
        const double b = 100000;

        public override double Calculate(int n)
        {
            double h = (b - a) / n;
            double res = 0;
            for (int i = 0; i < n; i++)
                res += Func(a + h * (i + 0.5));
            res *= h;
            return res;
        }
    }
}
