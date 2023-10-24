using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VorobevSA.Sprint3.Task5.V11.Lib;

namespace Tyuiu.VorobevSA.Sprint3.Task5.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService service1 = new DataService();

            int x = 5;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startvalue2 = 1;
            int stopvalue2 = 10;

            double res = service1.GetSumSumSeries(x, startValue1, startvalue2, stopValue1, stopvalue2);

            double wait = 64.234;

            Assert.AreEqual(wait, res);
        }
    }
}
