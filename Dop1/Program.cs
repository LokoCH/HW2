using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dop1
{
    class Program
    {
        static double FtoC(double f)
        {
            double c;

            c = Math.Round(((f - 32) * 5.0 / 9.0), 2);

            return c;
        }
        static void Main(string[] args)
        {
            Console.Write("Укажите температуру в Фаренгейтах: > ");
            double f = double.Parse(Console.ReadLine());
            Console.WriteLine("{0} градусов по Фаренгейту равны {1} градусам по Цельсию", f, FtoC(f));
        }
    }
}
