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
        public void TestMethod1()
        {
            var fileinfo = new FileInfo(path);
            Assert.IsTrue(fileinfo.Exists);
        }

        [TestMethod]
        public void TestMethod2()
        {
            double data;
            using (var binaryReader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                data = binaryReader.ReadDouble();
            }
            Assert.AreEqual(169.89, data);
        }
    }
}
