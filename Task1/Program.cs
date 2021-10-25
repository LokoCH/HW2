using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = '0';
            int n = 0;
            do
            {
                Console.Write("Введите символ (для выхода .) > ");
                try
                {
                   
                    symbol = char.Parse(Console.ReadLine());
                    if (symbol == ' ')
                        ++n;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (symbol != '.');

            Console.WriteLine("Количество пробелов = {0}", n);
        }
    }
}
