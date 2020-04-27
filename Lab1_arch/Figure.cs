using System;

namespace Lab1_arch
{
    public abstract class Figure
    {
        public double Function(double x)
        {
            return (10 * x) - Math.Log(14 * x);
        }

        public abstract double Calculate(int n, int a, int b);
        public abstract double PCalculate(int n, int a, int b);
    }
}
