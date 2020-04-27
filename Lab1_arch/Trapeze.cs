using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1_arch
{
    public class Trapeze : Figure
    {
        public string ErrorInformation;
        public override double Calculate(int n, int a, int b)
        {
            try
            {
                if ((a < b) && (n > 0))
                {
                    double h = (double)((b - a)) / n;
                    double res = 0;
                    for (int i = 0; i < n; i++)
                        res += Function(a + h * (i + 0.5));
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

        public override double PCalculate(int n, int a, int b)
        {
            double res = 0;
            try
            {
                if ((a < b) && (n > 0))
                {
                    double h = (double)((b - a)) / n;
                    var bag = new ConcurrentBag<double>();

                    Parallel.For(0, n, i =>
                    {
                        res += Function(a + h * (i + 0.5));
                        res *= h;
                    });
                    
                }
                else
                {
                    throw new ArgumentException();
                }
                
            }
            catch (ArgumentException ex)
            {
                ErrorInformation = ($"{ex.Message}");
                res = 0.0;
            }
            return res;

        }
    }
}