using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolvingTheEquation
{
    class Method
    {
        public delegate double Func(double x);
        public delegate double DFunc(double x);

        public static double Function1(double x) => Math.Pow(2 - x, x) - Math.Sin(x);
        public static double Function2(double x) => Math.Sin(x) / x;
        public static double Function3(double x) => Math.Cos(x) / x;
        public static double Function4(double x) => Math.Sin(Math.Sqrt(x)) / x;
        public static double Function5(double x) => Math.Tan(x) - x;
        public static double Function6(double x) => (1 / Math.Tan(x) - x;   
        public static double Function7(double x) => Math.Cos(x) + Math.Log(Math.Cos(x));
        public static double Function8(double x) => Math.Sin(x) + Math.Log(Math.Sin(x));
        public static double Function9(double x) => Math.Tanh(Math.Sin(x));
        public static double Function10(double x) => Math.Tanh(Math.Cos(x));
        public static double Function11(double x) => Math.Sqrt(Math.Sin(x)) - 0.5;
        public static double Function12(double x) => Math.Sqrt(Math.Cos(x)) - 0.5;
        public static double Function13(double x) => Math.Pow(2 - x, x) - Math.Cos(x);
        //
        // dF/dx
        //
        public static double DFunction1(double x) => -Math.Cos(x) - x * Math.Pow(2 - x, x - 1) + Math.Log(2 - x) * Math.Pow(2 - x, x);
        public static double DFunction2(double x) => Math.Cos(x) / x - Math.Sin(x) / x / x;
        public static double DFunction3(double x) => -Math.Sin(x) / x - Math.Cos(x) / x / x;
        public static double DFunction4(double x) => Math.Cos(Math.Sqrt(x)) / 2 / Math.Pow(x, 1.5) - Math.Sin(Math.Sqrt(x)) / x / x;
        public static double DFunction5(double x) => Math.Pow(Math.Tan(x), 2);
        public static double DFunction6(double x) => -Math.Pow(1 / Math.Tan(x), 2) - 2;
        public static double DFunction7(double x) => -Math.Sin(x) - Math.Tan(x);
        public static double DFunction8(double x) => Math.Cos(x) + 1 / Math.Tan(x);
        public static double DFunction9(double x) => -Math.Cos(x) * (Math.Pow(Math.Tanh(Math.Sin(x)), 2) - 1);
        public static double DFunction10(double x) => Math.Sin(x) * (Math.Pow(Math.Tanh(Math.Cos(x)), 2) - 1);
        public static double DFunction11(double x) => Math.Cos(x / 2 / Math.Sqrt(Math.Sin(x)));
        public static double DFunction12(double x) => -Math.Sin(x / 2 / Math.Sqrt(Math.Cos(x)));
        public static double DFunction13(double x) => Math.Sin(x) - x * Math.Pow(2 - x, x - 1) + Math.Log(2 - x) * Math.Pow(2 - x, x);
        //
        public static double Bisection(Func F, double x1, double x2, double eps)
        {
            double c = double.NaN;
            while (F(x1) * F(x2) <= 0 && Math.Abs(x1 - x2) > eps)
            {
                if (F(x1) == 0) return x1;
                if (F(x2) == 0) return x2;
                c = (x1 + x2) / 2;
                if (F(c) == 0) return c;
                else
                if (F(x1) * F(c) < 0) x2 = c;
                else x1 = c;
            }
            return c;
        }
        public static double Newton(Func F, DFunc DF, double x1, double x2, double eps)
        {
            while (Math.Abs(F(x1)) > eps && x1 < x2)
                x1 -= F(x1) / DF(x1);
            return x1;
        }
        public static double Chord(Func F, double x1, double x2, double eps)
        {
            while (Math.Abs(F(x1)) > eps)
                x1 -= F(x1) * (x2 - x1)/ (F(x2) - F(x1));
            return x1;
        }

    }
}
