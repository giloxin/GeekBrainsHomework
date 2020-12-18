using System;


namespace Lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Привет! Эта программа подсчитает среднесуточную температуру воздуха. {"\n"}Для начала введите сегодняшнюю минимальную температуру :) {"\n"}(Градусы должны быть по Цельсию)");
            Double a = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Отлично! Теперь введите максимальную температуру (Также по Цельсию)");
            Double b = Convert.ToDouble(Console.ReadLine());
            Double mid = (a + b) / 2;
            Console.Clear();
            Console.WriteLine($"Среднесуточная температура составляет {mid} градусов Цельсия");

            //в случае нереалистичной температуры - выводим сообщение
            if (a < -80.0 || a > 56.7)
            {
                Console.WriteLine($"НО! значение минимальной  температуры {a}C выглядит подозрительно :/");
            }
            if (b < -80.0 || b > 56.7)
            {
                Console.WriteLine($"НО! значение максимальной температуры {b}C выглядит подозрительно :/");
            }
        }
    }
}

