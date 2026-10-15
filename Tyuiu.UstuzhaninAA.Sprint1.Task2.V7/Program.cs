using System;
using Tyuiu.UstuzhaninAA.Sprint2.Task2.V7.Lib;

namespace Tyuiu.UstuzhaninAA.Sprint2.Task2.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Устюжанин А.А. | Задание 2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор if – полная и короткая форма записи                      *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вавиант #7                                                              *");
            Console.WriteLine("* Выполнил: Устюжанин Алексей Андреевич | ИСПб-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает целые значения с клавиатуры     *");
            Console.WriteLine("* и вычисляет, находится ли точка с координатами X, Y в области.          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            // Запрос ввода координат
            Console.Write("Введите координату X (от 1 до 15): ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите координату Y (от 1 до 15): ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool res = ds.CheckDotInShadedArea(x, y);

            if (res)
            {
                Console.WriteLine($"Точка с координатами ({x}, {y}) НАХОДИТСЯ в заштрихованной области.");
            }
            else
            {
                Console.WriteLine($"Точка с координатами ({x}, {y}) НЕ НАХОДИТСЯ в заштрихованной области.");
            }

            Console.ReadKey();
        }
    }
}