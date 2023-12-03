using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PoznyakIA.Sprint6.Task0.V10.Lib;
namespace Tyuiu.PoznyakIA.Sprint6.Task0.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(2);
            double wait = 37.560;
            Assert.AreEqual(wait, res);
        }
    }
}
