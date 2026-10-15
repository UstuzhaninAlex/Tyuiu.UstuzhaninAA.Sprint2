using System;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.UstuzhaninAA.Sprint2.Task6.V13.Lib
{
    public class DataService : ISprint2Task6V13
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {

            int daysInMonth = m switch
            {
                1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
                4 or 6 or 9 or 11 => 30,
                2 => 29, // Год високосный
                _ => throw new ArgumentException("Некорректный номер месяца.")
            };

            // Проверка введенного дня для данного месяца
            if (n < 1 || n > daysInMonth)
            {
                throw new ArgumentException("Некорректный день для указанного месяца.");
            }

            int nextYear = g;
            int nextMonth = m;
            int nextDay = n + 1;

            // Если выбраный день был последним в месяце
            if (n == daysInMonth)
            {
                nextDay = 1;
                if (m == 12) // Если конец года
                {
                    nextMonth = 1;
                    nextYear++;
                }
                else
                {
                    nextMonth++;
                }
            }

            // Возвращаем дату в форме день месяц год
            return $"{nextDay:D2}.{nextMonth:D2}.{nextYear}";
        }
    }
}