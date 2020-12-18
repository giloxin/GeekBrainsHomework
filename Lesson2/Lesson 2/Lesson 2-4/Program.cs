using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_4
{
    class Program
    {
        enum Month //Создаём наш год, задаём соответствие введённого числа с месяцем
        {
            Jan = 1,
            Fab = 2,
            Mar = 3,
            Apr = 4,
            May = 5,
            Jun = 6,
            Jul = 7,
            Aug = 8,
            Sep = 9,
            Oct = 10,
            Nov = 11,
            Dec = 12,
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"Эта программа скажет какая у вас зима :){"\n"}Введите номер месяца:");
            int a = Convert.ToInt32(Console.ReadLine());

            //проверяем, входит ли введённый номер в диапазон номеров месяцев
            if (a > 0 && a < 13)
            {
                //приводим введённый номер месяца к типу Month
                Month CurrentMonth = (Month)a;

                //если номер месяца соответствует зимнему сезону - выполняем код
                if (CurrentMonth == Month.Dec || CurrentMonth == Month.Jan || CurrentMonth == Month.Fab)
                {
                    Console.WriteLine("Введите температуру воздуха (С)");
                    int t = Convert.ToInt32(Console.ReadLine());
                    //если температура выше нуля - задача решена, выводим результат
                    if (t > 0)
                    {
                        switch (CurrentMonth)
                        {
                            case Month.Dec:
                                Console.Clear();
                                Console.WriteLine($"Месяц декабрь, температура воздуха равна {t}, ДОЖДЛИВАЯ ЗИМА");
                                break;
                            case Month.Jan:
                                Console.Clear();
                                Console.WriteLine($"Месяц январь, температура воздуха равна {t}, ДОЖДЛИВАЯ ЗИМА");
                                break;
                            case Month.Fab:
                                Console.Clear();
                                Console.WriteLine($"Месяц февраль, температура воздуха равна {t}, ДОЖДЛИВАЯ ЗИМА");
                                break;
                        }
                    }
                    else Console.WriteLine("Холодная зима"); //если температура была ниже нуля - выводим результат
                }
                else Console.WriteLine("Это не зима"); //если номер месяца не соответствует зимнему сезону - выводим результат
            }
            else Console.WriteLine("Номер месяца введён неверно"); //если номер месяца не соответствует списку месяцев - выводим сообщение об ошибке
        }
    }
}
