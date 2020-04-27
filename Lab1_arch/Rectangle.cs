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

        public override double Calculate(int n, int a, int b, Func<double, double> func)
        {
            try
            {
                if ((a < b) && (n > 0))
                {
                    double h = (double)((b - a)) / n;
                    double res = 0;
                    for (int i = 0; i < n; i++)
                        res += 0.5 * (func(a + h * i) + func(a + h * (i + 1)));
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
        }

        public override double PCalculate(int n, int a, int b, Func<double, double> func)
        {
            try
            {
                if ((a < b) && (n > 0))
                {
                    double h = (double)((b - a)) / n;
                    var bag = new ConcurrentBag<double>();

                    Parallel.For<double>(0, n, () => 0, (i, state, subres) =>
                    {
                        double tmp;
                        tmp = h *( 0.5 * (func(a + h * i) + func(a + h * (i + 1))));
                        
                        subres += tmp;
                        return subres;

                    },(x) => bag.Add(x));

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
        }
    }
}
