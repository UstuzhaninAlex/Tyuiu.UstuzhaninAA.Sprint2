using System;

namespace Tyuiu.UstuzhaninAA.Sprint2.Task1.V21.Lib
{
    public class DataService 
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            // 1.False
            res[0] = (a == b) | (c < d);

            // 2.False
            res[1] = (a != c) & (b <= d);

            // 3.False
            res[2] = (a > b) || (c >= b);

            // 4.False
            res[3] = (a < d) && (b > c);

            // 5.True
            res[4] = !(a == b);

            // 6.False
            res[5] = (a == c) ^ (b > d);

            return res;
        }
    }
}