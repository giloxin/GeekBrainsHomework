using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Привет! Эта программа определит, является ли число чётным. {"\n"}Введите число:");
            int a = Convert.ToInt32(Console.ReadLine()); //ввод числа

            //проверка на чётность делением без остатка
            if (a % 2 == 0)
            {
                Console.WriteLine($"Число {a} чётное");
            }
            else
                Console.WriteLine($"Число {a} нечётное");
        }
    }
}
