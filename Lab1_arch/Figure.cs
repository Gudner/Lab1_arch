using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lab1_arch
{
    public abstract class Figure
    {
        public double Function(double x)
        {
            return (10 * x) - Math.Log(14 * x);
        }

        public abstract Task<double> Calculate(int n, int a, int b, CancellationToken token, IProgress<int> progress, Func<double, double> func);
        public abstract Task<double> PCalculate(int n, int a, int b, CancellationToken token, IProgress<int> progress, Func<double, double> func);
    }
}
