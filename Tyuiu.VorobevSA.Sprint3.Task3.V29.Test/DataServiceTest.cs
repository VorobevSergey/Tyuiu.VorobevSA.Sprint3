using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VorobevSA.Sprint3.Task3.V29.Lib;

namespace Tyuiu.VorobevSA.Sprint3.Task3.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidDeleteCharInString()
        {
            DataService service1 = new DataService();
            string value = "chgr vhhtg hnht";
            char item = 'h';
            string res = service1.DeleteCharInString(value, item);
            string wait = "c gr v  tg  n t";
            Assert.AreEqual(wait, res);
        }
    }
}
