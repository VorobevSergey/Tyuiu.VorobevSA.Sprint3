using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VorobevSA.Sprint3.Task4.V16.Lib;

namespace Tyuiu.VorobevSA.Sprint3.Task4.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService service1 = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double res = service1.Calculate(startValue, stopValue);
            double wait = 2.757;
            Assert.AreEqual(wait, res);
        }
    }
}
