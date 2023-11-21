using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.TolmachevVV.Sprint5.Task3.V24.Lib;

namespace Tyuiu.TolmachevVV.Sprint5.Task3.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        private static readonly DataService service1 = new DataService();

        private static readonly string path = service1.SaveToFileTextData(3);

        [TestMethod]
        public void FileExistence()
        {
            var fileinfo = new FileInfo(path);
            Assert.IsTrue(fileinfo.Exists);
        }

        [TestMethod]
        public void DataTests()
        {
            string strData;
            double doubleData;
            using (var binaryReader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                strData = binaryReader.ReadString();
                doubleData = binaryReader.ReadDouble();
            }
            Assert.AreEqual("14-AE-47-E1-7A-3C-65-40", strData);
            Assert.AreEqual(169.89, doubleData);
        }
    }
}
