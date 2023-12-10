using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.PoznyakIA.Sprint6.Task7.V29.Lib;
namespace Tyuiu.PoznyakIA.Sprint6.Task7.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\polimer\source\repos\Tyuiu.PoznyakIA.Sprint6\Tyuiu.PoznyakIA.Sprint6.Task7.V29\bin\Debug\OutPutFileTask7.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
