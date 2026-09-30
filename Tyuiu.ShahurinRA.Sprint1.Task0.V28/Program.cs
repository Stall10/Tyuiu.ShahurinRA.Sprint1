using Tyuiu.ShahurinRA.Sprint1.Task0.V28.Lib;

namespace Tyuiu.ShahurinRA.Sprint1.Task0.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Шахурин Р. А. | ИБКСб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                             *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                         *");
            Console.WriteLine("* Задание #1                                                          *");
            Console.WriteLine("* Выполнил: Шахурин Роман Алексеевич | ИБКСб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                            *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение 48/12-48/6/4 и печатает результат на экране *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("***************************************************************************");
            DataService ds = new DataService();

            Console.WriteLine("48/12-48/6/4 = " + ds.Calculate(0));
        }
    }
}