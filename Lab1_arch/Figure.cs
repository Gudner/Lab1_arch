using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_arch
{
    abstract class Figure
    {
        protected double Func(double x)
        {
            return (10 * x) - Math.Log(14 * x);
        }

        public abstract double Calculate(int n);
    }
}
