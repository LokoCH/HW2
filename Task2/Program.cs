using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите шестизначный номер");

            string number = "";
            while (true)
            {
                try
                {
                    number = Console.ReadLine();
                    if (number.Length != 6)
                        throw new Exception("Должно быть 6 цифр");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            int sumLeft = 0;
            int sumRight = 0;

            try
            {
                for (int i = 0; i < number.Length / 2; i++)
                {
                    if (char.IsDigit(number[i]))
                        sumLeft += (int)number[i];
                    else
                        throw new Exception("Нужно вводить только цыфры");
                }

                for (int i = number.Length / 2; i < number.Length; i++)
                {
                    if (char.IsDigit(number[i]))
                        sumRight += (int)number[i];
                    else
                        throw new Exception("Нужно вводить только цыфры");
                }

                if (sumLeft == sumRight)
                    Console.WriteLine("Билет счастливый");
                else
                    Console.WriteLine("Билет НЕсчастливый");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}