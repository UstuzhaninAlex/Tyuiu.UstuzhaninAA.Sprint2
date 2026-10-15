using System;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.UstuzhaninAA.Sprint2.Task0.V18.Lib
{
    public class DataService : ISprint2Task0V18
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            
            
            bool[] res = new bool[6];

            res[0] = x == y;  // == (False)
            res[1] = x != y;  // != (True)
            res[2] = y < x;   // <  (True)
            res[3] = x > y;   // >  (True)
            res[4] = y <= x;  // <= (True)
            res[5] = y >= x;  // >= (False)

            return res;
        }
    }
}
