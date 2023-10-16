using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VorobevSA.Sprint3.Task0.V4.Lib;

namespace Tyuiu.VorobevSA.Sprint3.Task0.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service1 = new DataService();
            int startValue = 1;
            int stopValue = 7;

            double res = service1.GetSumSeries(startValue, stopValue);
            double wait = 28.699;

            Assert.AreEqual(wait, res);
        }
    }
}
