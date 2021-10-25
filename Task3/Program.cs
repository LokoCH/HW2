using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static string ConvertString(string str)
        {
            // создаём массив char и записываем в него посимвольно переданную строку
            char[] tmp = new char[str.Length];
            int idx = 0;

            foreach (char ch in str)
            {
                if ((ch > 'a' && ch < 'z') || (ch > 'а' && ch < 'я'))
                    tmp[idx] = (char)(ch - 32);

                else if ((ch > 'A' && ch < 'Z') || (ch > 'А' && ch < 'Я'))
                    tmp[idx] = (char)(ch + 32);

                else
                    tmp[idx] = ch;
                ++idx;
            }

            //преобразуем char в string
            return new string(tmp);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст");
            string str = Console.ReadLine();

            str = ConvertString(str);
            Console.WriteLine(str);
            
            
        }
    }
}
