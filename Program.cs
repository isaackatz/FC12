using System;

namespace FC12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("    x        exp(x)       Texp");
            Console.WriteLine("         |exp-Texp|");
            double dx = 1.0;
            for (double x = 0.0; x < 10.0 + dx / 2.0; x += dx)
            {
                Console.Write("{0,9:F6}", x);
                double p = Math.Exp(x);
                Console.Write("{0,14:F6}", p);
                double t = Texp(x);
                Console.Write("{0,14:F6}", t);
                Console.WriteLine("{0,12:F6}", Math.Abs(p - t));
            }
            Console.ReadKey();
        }
        //-----------------------------------------------------------------------------------------------
        static double Texp(double x)
        {
            double e = 1.0E-4;
            double r = x;
            double n = 1.0;
            double f = 1 + r;
            do
            {
                n += 1.0;
                r *= x / n;
                f += r;
            } while (Math.Abs(r) > e);
            return f;
        }
    }
}
