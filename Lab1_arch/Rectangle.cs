namespace Lab1_arch
{
    public class Rectangle : Figure
    {

        public override double Calculate(int n, int a, int b)
        {
            double h = (double)((b - a)) / n;
            double res = 0;
            for (int i = 0; i < n; i++)
                res += Function(a + h * (i + 0.5));
            res *= h;
            return res;
        }
    }
}
