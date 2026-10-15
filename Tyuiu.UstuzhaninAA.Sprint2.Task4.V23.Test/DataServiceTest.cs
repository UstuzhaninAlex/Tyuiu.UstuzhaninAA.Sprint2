using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.UstuzhaninAA.Sprint2.Task4.V23.Lib;

namespace Tyuiu.UstuzhaninAA.Sprint2.Task4.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateConditionTrue()
        {
            DataService ds = new DataService();
            // Проверка то
            double res = ds.Calculate(1, 4);
            Assert.AreEqual(1.063, res);
        }

        [TestMethod]
        public void ValidCalculateConditionFalse()
        {
            DataService ds = new DataService();
            // Проверка иначе
            double res = ds.Calculate(5, 4);
            Assert.AreEqual(63.8, res);
        }
    }
}
