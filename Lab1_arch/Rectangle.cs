using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Lab1_arch
{
    public class Rectangle : Figure
    {
        public string ErrorInformation;

        public double Result;

        public override Task<double> Calculate(int n, int a, int b, CancellationToken token, IProgress<int> progress, Func<double, double> func)
        {
            return Task<double>.Factory.StartNew(() =>
            {
                try
                {

                    if ((a < b) && (n > 0))
                    {
                        int count = 0;
                        double h = (double)((b - a)) / n;
                        double res = 0;
                        for (int i = 0; i < n; i++)
                        {
                            token.ThrowIfCancellationRequested();
                            Thread.Sleep(3);
                            res += 0.5 * (func(a + h * i) + func(a + h * (i + 1)));
                            Interlocked.Increment(ref count);
                            progress.Report(count * 100 / n);
                        }
                            
                        res *= h;
                        return res;
                    }
                    else
                    {
                        throw new ArgumentException();
                    }

                }
                catch (ArgumentException ex)
                {
                    ErrorInformation = ($"{ex.Message}");
                }
                return 0.0;

            },token);
        }
        public override Task<double> PCalculate(int n, int a, int b, CancellationToken token, IProgress<int> progress, Func<double, double> func)
        {
            return Task<double>.Factory.StartNew(() =>
            {
                try
                {
                    if ((a < b) && (n > 0))
                    {
                        double h = (double)((b - a)) / n;
                        int count = 0;
                        var bag = new ConcurrentBag<double>();

                        Parallel.For<double>(0, n, new ParallelOptions() { CancellationToken = token }, () => 0,  (i, state, subres) =>
                        {
                            token.ThrowIfCancellationRequested();
                            Thread.Sleep(3);
                            double tmp;
                            tmp = h * (0.5 * (func(a + h * i) + func(a + h * (i + 1))));
                            subres += tmp;
                            Interlocked.Increment(ref count);
                            progress.Report(count * 100 / n);
                            return subres;

                        }, (x) => bag.Add(x));

                        Result = bag.Sum();

                    }
                    else
                    {
                        throw new ArgumentException();
                    }

                }
                catch (ArgumentException ex)
                {
                    ErrorInformation = ($"{ex.Message}");
                    Result = 0.0;
                }
                return Result;
            }, token);
        }
    }
}
