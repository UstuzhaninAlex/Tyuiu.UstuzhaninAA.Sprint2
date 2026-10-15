using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.UstuzhaninAA.Sprint2.Task0.V18.Lib;

namespace Tyuiu.UstuzhaninAA.Sprint2.Task0.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 5105;
            int y = 475;

            bool[] res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[] { false, true, true, true, true, false };
            //Класс
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
