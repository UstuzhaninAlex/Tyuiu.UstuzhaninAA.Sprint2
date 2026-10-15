using System;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.UstuzhaninAA.Sprint2.Task2.V7.Lib
{
    public class DataService : ISprint2Task2V7
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            // Проверка границ
            if (x < 1 || x > 15 || y < 1 || y > 15)
            {
                return false;
            }

            //Условия
            if ((y == 3 || y == 4) && ((x >= 4 && x <= 5) || (x >= 9 && x <= 12))) return true;
            if (y == 5 && (x >= 4 && x <= 12)) return true;
            if ((y == 6 || y == 7) && (x >= 4 && x <= 13)) return true;
            if (y == 8 && (x >= 4 && x <= 12)) return true;
            if ((y == 9 || y == 10) && ((x >= 5 && x <= 6) || (x >= 10 && x <= 12))) return true;
            if (y == 11 && ((x >= 4 && x <= 6) || (x >= 10 && x <= 12))) return true;
            if (y == 12 && ((x >= 5 && x <= 7) || x == 10)) return true;
            if (y == 13 && (x >= 5 && x <= 7)) return true;

            // Если ни одно условие не выполнилось, точка вне заштрихованной зоны
            return false;
        }
    }
}
