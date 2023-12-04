using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PoznyakIA.Sprint6.Task1.V29.Lib;
namespace Tyuiu.PoznyakIA.Sprint6.Task1.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            CollectionAssert.AreEqual(new double[] { -15.44, -10.93, -7.22, -5.04, 0, -0.3, 2.57, 6.4, 10.04, 12.72, 14.68 }, ds.GetMassFunction(-5, 5));
        }
    }
}
