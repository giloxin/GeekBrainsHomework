using System;
using System.Globalization;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте, молодой человек! Как я могу к Вам обращаться?");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}, сегодня {DateTime.Today.ToString("d")}, {DateTime.Today.DayOfWeek}");
        }
    }
}
