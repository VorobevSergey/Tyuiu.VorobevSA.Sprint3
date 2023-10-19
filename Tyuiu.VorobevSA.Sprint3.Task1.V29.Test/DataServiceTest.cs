using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VorobevSA.Sprint3.Task1.V29.Lib;

namespace Tyuiu.VorobevSA.Sprint3.Task1.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService service1 = new DataService();

            double value = 0.25;
            int startValue = 1;
            int stopValue = 11;

            double res = service1.GetMultiplySeries(value, startValue, stopValue);

            double wait = 3456091836.053;

            Assert.AreEqual(wait, res);
        }
    }
}
