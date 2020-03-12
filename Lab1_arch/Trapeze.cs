using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_arch
{
    public class Trapeze : Figure
    {

        public override double Calculate(int n, int a, int b)
        {
            double h = (double)((b - a)) / n;
            double res = 0;
            
            for (int i = 1; i < n - 1; i++)
            {
                res += h * (Function(a + (h * i)));
            }

            res += (h * ((Function(a) + Function(b)) / 2));

            return res;
        }
    }
}