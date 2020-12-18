using System;


namespace Lesson_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = null;
            Console.WriteLine($"Эта программа выведет название месяца по его номеру. {"\n"}Для начала - введите номер месяца от 1 до 12");
            int a = Convert.ToInt32(Console.ReadLine());

            /*
            В данном решении задача была выполнена с использованием Switch-case
            Сначала проверяем, выходи ли введённое пользователем число в диапазон, месяцев и затем выводим результат
            */
            if (a > 0 && a < 13)
            {
                switch (a)
                {
                    case 1:
                        month = "Январь";
                        break;
                    case 2:
                        month = "Февраль";
                        break;
                    case 3:
                        month = "Март";
                        break;
                    case 4:
                        month = "Апрель";
                        break;
                    case 5:
                        month = "Май";
                        break;
                    case 6:
                        month = "Июнь";
                        break;
                    case 7:
                        month = "Июль";
                        break;
                    case 8:
                        month = "Август";
                        break;
                    case 9:
                        month = "Сентябрь";
                        break;
                    case 10:
                        month = "Октябрь";
                        break;
                    case 11:
                        month = "Ноябрь";
                        break;
                    case 12:
                        month = "Декабрь";
                        break;

                }
                Console.Clear();
                Console.WriteLine(month);
            }
            else //если пользователь ввёл номер месяца некорректно
            {
                Console.Clear();
                Console.WriteLine($"Данные введены некорректно");
            }
        }
    }
}
