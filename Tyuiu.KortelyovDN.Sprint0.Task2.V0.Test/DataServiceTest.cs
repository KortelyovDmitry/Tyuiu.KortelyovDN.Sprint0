using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KortelyovDN.Sprint0.Task2.V0.Lib;

namespace Tyuiu.KortelyovDN.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Дмитрий";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Дмитрий", res);
        }
    }
}