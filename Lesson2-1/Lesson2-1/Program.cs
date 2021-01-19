using System;

namespace Lesson2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Решение задачи №1
            */
            int n, i = 2, d = 0;
            Console.WriteLine("Введите число");
            n = Convert.ToInt32(Console.ReadLine());
            while (i < n)
                {
                    if (n % i == 0)
                    {
                        d++;
                    }
                    i++;
                }
            if (d == 0)
            {
                Console.WriteLine("Число простое");
            }
            else Console.WriteLine("Число сложное");
        }
    }

    //Дальше идёт подсчёт асимптотической сложности задачи №2

    /*
    public static int  StrangeSum(int[] inputArray)
    {
       int sum = 0; 
       for (int i = 0; i < inputArray.Length; i++) //O(n)
       {
           for (int j = 0; j < inputArray.Length; j++) //O(n)
           {
               for (int k = 0; k < inputArray.Length; k++) //O(n)
               {
                   int y = 0; 

                   if (j != 0) 
                   {
                       y = k / j; 
                   }

                   sum += inputArray[i] + i + k + j + y; 
               }
           }
       }

       return sum;
    }
    Сложность алгоритма = O(N*N*N)
    */
}
