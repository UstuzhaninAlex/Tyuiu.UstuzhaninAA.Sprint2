using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.UstuzhaninAA.Sprint2.Task7.V1.Lib;

namespace Tyuiu.UstuzhaninAA.Sprint2.Task7.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();


            Assert.IsTrue(ds.CheckDotInShadedArea(0, 0.5));


            Assert.IsTrue(ds.CheckDotInShadedArea(0, 1));


            Assert.IsFalse(ds.CheckDotInShadedArea(0, -0.5));


            Assert.IsFalse(ds.CheckDotInShadedArea(2, 2));
        }
    }
}