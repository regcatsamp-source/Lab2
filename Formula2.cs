﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Formula2
    {
        public static double Calculate(double a, double b, double f)
        {
            return Math.Cos(f * a) + Math.Sin(f * b);
        }
    }
}