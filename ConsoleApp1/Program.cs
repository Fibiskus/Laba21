using System;

namespace ConsoleApp2._1
{
    public class Program
    {
        static public double Calculation(double x)
        {
            double p = (2 + x * 3) / (x + Math.Sqrt(13 * Math.Abs(x)));
            return p;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Resultat y = f(x)  dx = 0.5.\n\tx\t\ty = f(x)");
            double x = -3;
            double y;
            while (x <= 3)
            {
                y = Calculation(x);
                Console.WriteLine("\t{0}\t\t{1}", x, y);
                x += 0.5;
            }
        }
    }
}
