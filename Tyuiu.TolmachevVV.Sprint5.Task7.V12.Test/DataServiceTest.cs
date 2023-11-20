using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.TolmachevVV.Sprint5.Task7.V12.Lib;

namespace Tyuiu.TolmachevVV.Sprint5.Task7.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService service = new DataService();
        private static readonly string InputPath = @"C:\DataSprint5\InPutDataFileTask7V12.txt";

        [TestMethod]
        public void FileExsistenceTest()
        {
            FileInfo fileInfoInput = new FileInfo(InputPath);
            FileInfo fileInfoOutput = new FileInfo(service.LoadDataAndSave(InputPath));
            Assert.IsTrue(fileInfoInput.Exists);
            Assert.IsTrue(fileInfoOutput.Exists);
        }

        [TestMethod]
        public void CalculationTest()
        {
            Assert.AreEqual(File.ReadAllText(InputPath).ToUpper(), File.ReadAllText(service.LoadDataAndSave(InputPath)));
        }
    }
}
