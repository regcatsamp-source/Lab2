using System;

namespace Lab2
{
    public class Formula5
    {
        public static double Calculate(double t, double x, double f, double y, int N, int K)
        {
            double z = 0;

            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= K; j++)
                {
                    double numerator = Math.Pow(t, i) * Math.Pow(x, i) + Math.Pow(f, j) * Math.Pow(y, j);
                    double denominator = t * i * j;
                    z += numerator / denominator;
                }
            }

            return z;
        }
    }
}
