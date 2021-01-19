using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_1_2
{
    class Program
    {
        public static int fibo (int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
               return fibo(n - 1) + fibo(n - 2);
            }
        }
        static void Main(string[] args)
        {
            //Решение задачи №3 на числа фибоначчи
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 2)
            {
                Console.WriteLine("Для расчёта числа фибоначчи рекурсией - 1, для цикла - 2");
                int fib = 0;
                int h = Convert.ToInt32(Console.ReadLine());
                switch (h)
                {
                    case 1:
                            Console.WriteLine($"Число фибоначчи для {n} = {fibo(n)}");
                    break;
                    case 2:
                        for (int i = 0; i < n; i++)
                            {
                                fib = (n-1)+(n-2);
                            }
                    Console.WriteLine($"Число фибоначчи для {n} = {fib}");
                    break;
                }
                Console.ReadLine();
            }
        }
    }
}
