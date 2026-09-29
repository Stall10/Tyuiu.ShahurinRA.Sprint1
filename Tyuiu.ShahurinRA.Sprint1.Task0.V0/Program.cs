using Tyuiu.ShahurinRA.Sprint1.Task1.V0.Lib;

namespace Tyuiu.ShahurinRA.Sprint1.Task1.V0
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
            Console.WriteLine("48/12-48/6/4 = " + Class1.Otvet());
        }
    }
}