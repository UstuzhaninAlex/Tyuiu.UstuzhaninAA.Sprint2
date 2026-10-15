using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.UstuzhaninAA.Sprint2.Task6.V13.Lib;

namespace Tyuiu.UstuzhaninAA.Sprint2.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindNextDate()
        {
            DataService ds = new DataService();

            // Обычный день
            Assert.AreEqual("16.02.2024", ds.FindDateOfNextDay(2024, 2, 15));

            // Последний день февраля високосного года
            Assert.AreEqual("01.03.2024", ds.FindDateOfNextDay(2024, 2, 29));

            // Конец обычного месяца
            Assert.AreEqual("01.05.2024", ds.FindDateOfNextDay(2024, 4, 30));

            // Конец года
            Assert.AreEqual("01.01.2025", ds.FindDateOfNextDay(2024, 12, 31));
        }
    }
}
