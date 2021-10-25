using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dop2
{
    class Program
    {
        static double P(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            // вычисляем длины сторон
            double a = Math.Pow((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)), 0.5);
            double b = Math.Pow((Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2)), 0.5);
            double c = Math.Pow((Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2)), 0.5);

            return Math.Round((a + b + c), 2);
        }

        static double S(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            double a = Math.Pow((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)), 0.5);
            double b = Math.Pow((Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2)), 0.5);
            double c = Math.Pow((Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2)), 0.5);

            double p = (a + b + c) / 2;

            return Math.Pow((p * (p - a) * (p - b) * (p - c)), 0.5);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты вершин треугольника");
            Console.Write("Точка А: x = ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("\t y = ");
            double y1 = double.Parse(Console.ReadLine());

            Console.Write("Точка B: x = ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("\t y = ");
            double y2 = double.Parse(Console.ReadLine());

            Console.Write("Точка C: x = ");
            double x3 = double.Parse(Console.ReadLine());
            Console.Write("\t y = ");
            double y3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Периметр треугольника с заданными вершинами равен {0}", P(x1, y1, x2, y2, x3, y3));
            Console.WriteLine("Площадь треугольника с заданными вершинами равна {0}", S(x1, y1, x2, y2, x3, y3));

        }
    }
}
