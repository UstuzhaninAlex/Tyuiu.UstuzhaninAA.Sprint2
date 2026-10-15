using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.UstuzhaninAA.Sprint2.Task3.V15.Lib;

namespace Tyuiu.UstuzhaninAA.Sprint2.Task3.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();


            Assert.AreEqual(11, ds.Calculate(2));


            Assert.AreEqual(0.75, ds.Calculate(0));


            Assert.AreEqual(-219.95, ds.Calculate(-20));
        }
    }
}