using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.TolmachevVV.Sprint5.Task5.V21.Lib;

namespace Tyuiu.TolmachevVV.Sprint5.Task5.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        private static readonly string path = @"C:\DataSprint5\InPutDataFileTask5V21.txt";

        [TestMethod]
        public void FileExsistenceTest()
        {
            FileInfo fileInfo = new FileInfo(path);
            Assert.IsTrue(fileInfo.Exists);
        }

        [TestMethod]
        public void CalculationTest()
        {
            DataService service = new DataService();
            Assert.AreEqual(720, service.LoadFromDataFile(path));
        }
    }
}

