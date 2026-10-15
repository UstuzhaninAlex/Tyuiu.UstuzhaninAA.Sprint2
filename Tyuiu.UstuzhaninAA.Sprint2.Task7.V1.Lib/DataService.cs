using System;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.UstuzhaninAA.Sprint2.Task7.V1.Lib
{
    public class DataService : ISprint2Task7V1
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            // Проверяем три условия
            // 1. Точка находится внутри или на границе круга радиуса
            // 2. Точка находится выше или на линии
            // 3. Точка находится ниже или на линии
            if ((Math.Pow(x, 2) + Math.Pow(y, 2) <= 1) && (y >= x) && (y >= -x))
            {
                return true;
            }

            return false;
        }
    }
}