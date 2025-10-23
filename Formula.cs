using System;

namespace Lab2
{
    public class Formula
    {
        public double Formula1(double a, double b, double x)
        {
            return a * x + b;
        }

        public double Formula2(double a, double b, double c, double x)
        {
            return a * x * x + b * x + c;
        }

        public double Formula3(double a, double x)
        {
            return Math.Sin(x) + a;
        }

        public double Formula4(double a, double x)
        {
            return Math.Log(x + a);
        }

        public double Variant2(double a, double b, double c, double x)
        {
            return Math.Exp(a * x) + b * Math.Log(x + c);
        }
    }
}