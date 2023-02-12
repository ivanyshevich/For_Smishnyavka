using System;
using System.Text;

namespace EquationEvaluation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double x = -100;
            do
            {
                Console.WriteLine("Введіть x: ");
                x = Double.Parse(Console.ReadLine());
                switch (x)
                {
                    case < -10:
                        Console.WriteLine("Менш за -10");
                        break;
                    case < -1 and > -10:
                        Console.WriteLine("Менш за -1");
                        break;
                    case > 1 and < 10:
                        Console.WriteLine("Більш за 1");
                        break;
                    case > 10:
                        Console.WriteLine("Більш за 10");
                        break;
                }
                Console.WriteLine("Введіть y: ");
                double y = Double.Parse(Console.ReadLine());
                Console.WriteLine("Введіть z: ");
                double z = Double.Parse(Console.ReadLine());
                Console.WriteLine(CalculateA(x, y, z));
            } while (x != 0);
        }
        static double CalculateA(double x, double y, double z)
        {
            double a = Math.Pow(x, 2) * Math.Pow(Math.Pow(z, 2) + Math.Abs(y), 0.25);
            if (a >= 0)
                Console.WriteLine("Позитивне");
            else
                Console.WriteLine("Негативне");
            return a;
        }
    }
}