using System;
using Tyuiu.UstuzhaninAA.Sprint2.Task1.V21.Lib;

namespace Tyuiu.UstuzhaninAA.Sprint2.Task1.V21
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();


            int a = 696;
            int b = 987;
            int c = 696;
            int d = 155;


            Console.Title = "Спринт #2 | Выполнил: Устюжанин А.А. | Задание 1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Логические операции                                               *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Устюжанин Алексей Андреевич | ИСПб-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений и логических операций          *");
            Console.WriteLine("* (|, &, ||, &&, !, ^), которая вернет логическую последовательность      *");
            Console.WriteLine("* (False, False, False, False, True, False)                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine($"c = {c}");
            Console.WriteLine($"d = {d}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            // Получение результата
            bool[] res = ds.GetLogicOperations(a, b, c, d);

            // Построчный вывод элементов
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }


            Console.ReadKey();
        }
    }
}