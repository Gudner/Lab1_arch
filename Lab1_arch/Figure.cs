using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_arch
{
    public abstract class Figure
    {
        public double Function(double x)
        {
            return (10 * x) - Math.Log(14 * x);
        }

        public abstract double Calculate(int n, double a, double b);
    }
}
