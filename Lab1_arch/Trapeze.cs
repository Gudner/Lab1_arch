﻿using System;

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
                        res += 0.5 * (Function(a + h * i) + Function(a + h * (i + 1)));
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
    }
}