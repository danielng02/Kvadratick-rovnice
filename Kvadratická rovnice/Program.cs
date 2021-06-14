using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KvadratickaRovnice
{
    public class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            Koren koren = new Koren(Koren.Equation(a, b, c));

            double x1 = koren.x1;
            double x2 = koren.x2;

            Console.WriteLine(x1 + "\n" + x2);

            Console.ReadKey();
        }
    }
    public class Koren
    {
        public double x1;
        public double x2;
        public static Koren Equation(double a, double b, double c)
        {
            Koren koren = new Koren();

            double diskriminant = Math.Sqrt(Math.Pow(b, 2) - (4 * a * c));

            if (diskriminant == 0)
            {
                koren.x1 = koren.x2 = -b / (2 * a);
            }

            if (diskriminant > 0)
            {
                koren.x1 = (b * (-1) + diskriminant) / (2 * a);
                koren.x2 = (b * (-1) - diskriminant) / (2 * a);
            }

            return koren;

        }

        public Koren() { }

        public Koren(Koren koren)
        {
            x1 = koren.x1;
            x2 = koren.x2;
        }
    }
}
