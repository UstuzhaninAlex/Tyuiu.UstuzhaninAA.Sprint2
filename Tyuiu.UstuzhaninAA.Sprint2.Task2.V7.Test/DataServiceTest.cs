using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.UstuzhaninAA.Sprint2.Task2.V7.Lib;

namespace Tyuiu.UstuzhaninAA.Sprint2.Task2.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            // Точки внутри
            Assert.IsTrue(ds.CheckDotInShadedArea(4, 3));
            Assert.IsTrue(ds.CheckDotInShadedArea(13, 6));
            Assert.IsTrue(ds.CheckDotInShadedArea(6, 13));

            // Точки снаружи
            Assert.IsFalse(ds.CheckDotInShadedArea(1, 1));
            Assert.IsFalse(ds.CheckDotInShadedArea(8, 3));
            Assert.IsFalse(ds.CheckDotInShadedArea(14, 12));
        }
    }
}
