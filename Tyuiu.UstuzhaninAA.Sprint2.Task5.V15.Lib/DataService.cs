using System;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.UstuzhaninAA.Sprint2.Task5.V15.Lib
{
    public class DataService : ISprint2Task5V15
    {
        public string FindDayName(int k)
        {
            // Проверка правильности данных по условию
            if (k < 1 || k > 365)
            {
                throw new ArgumentOutOfRangeException("Номер дня должен быть в диапазоне от 1 до 365.");
            }

            // Вычисляем остаток от деления на 7 для определения дня
            int dayIndex = k % 7;
            string dayName;

            // Использование switch для сопоставления с названием дня
            switch (dayIndex)
            {
                case 1:
                    dayName = "Понедельник";
                    break;
                case 2:
                    dayName = "Вторник";
                    break;
                case 3:
                    dayName = "Среда";
                    break;
                case 4:
                    dayName = "Четверг";
                    break;
                case 5:
                    dayName = "Пятница";
                    break;
                case 6:
                    dayName = "Суббота";
                    break;
                case 0:
                    dayName = "Воскресенье";
                    break;
                default:
                    dayName = "Ошибка";
                    break;
            }

            return dayName;
        }
    }
}