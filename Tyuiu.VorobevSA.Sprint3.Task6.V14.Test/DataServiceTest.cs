using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VorobevSA.Sprint3.Task6.V14.Lib;

namespace Tyuiu.VorobevSA.Sprint3.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service1 = new DataService();

            int startValue = 7;
            int stopValue = 16;

            int res = service1.GetSumTheDivisors(startValue, stopValue);

            int wait = 36;

            Assert.AreEqual(wait, res);
        }
    }
}
