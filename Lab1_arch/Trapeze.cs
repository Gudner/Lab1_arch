namespace Lab1_arch
{
    public class Trapeze : Figure
    {
       
        public override double Calculate(int n, int a, int b)
        {
            double h = (double)((b - a)) / n;
            double res = 0;
            for (int i = 0; i < n; i++)
                res += 0.5 * (Function(a + h * i) + Function(a + h * (i + 1)));
            res *= h;
            return res;
        }
    }
}