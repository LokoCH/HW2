using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dop3
{
    class Program
    {
        static string ConvertToStr(int num)
        {
            string[] to100 = { "", "Сто", "Двести", "Тристо", "Четыресто", "Пятьсот", "Шестьсот", "Семьсот", "Восемьсот", "Девятьсот" };
            string[] to10 = { "", "", "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семьдесят", "восемьдесят", "девяносто" };
            string[] to1 = { "", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };
            string[] other = {"десять", "одиннадцать", "двенадцать", "тринадцать", "четырнадцать", "пятнадцать",
                             "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать" };

            if (num < 100 || num > 999)
            {
                return "Число должно находиться между 100 и 999";

            }

            int first = (num / 100);
            int second = ((num / 10) % 10);
            int third = (num % 10);

            // если второе число равно единице, то берем данные из другого массива
            if (second == 1)
                return to100[first].ToString() + " " + other[third].ToString();
            else if (second == 0)
                return to100[first].ToString() + " " + to1[third].ToString();

            else
                return to100[first].ToString() + " " + to10[second].ToString() + " " + to1[third].ToString();
        }

        static void Main(string[] args)
        {

            for (int i = 99; i < 1000; i++)
            {
                Console.WriteLine("{0} - " + ConvertToStr(i), i);
            }


        }
    }
}
