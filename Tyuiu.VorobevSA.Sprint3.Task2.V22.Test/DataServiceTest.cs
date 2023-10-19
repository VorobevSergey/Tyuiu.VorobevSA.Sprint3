using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VorobevSA.Sprint3.Task2.V22.Lib;

namespace Tyuiu.VorobevSA.Sprint3.Task2.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService service1 = new DataService();
            double x = 5;
            int q = 1;
            int w = 7;

            double res = service1.GetSumSeries(x, q, w);

            double wait = 0.125;

            Assert.AreEqual(wait, res);
        }
    }
}
