using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TolmachevVV.Sprint5.Task0.V29.Lib;
using System.IO;

namespace Tyuiu.TolmachevVV.Sprint5.Task0.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\vital\source\repos\Tyuiu.TolmachevVV.Sprint5\Tyuiu.TolmachevVV.Sprint5.Task0.V29\bin\Debug\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            Assert.AreEqual(true, fileInfo.Exists);
            Assert.AreEqual("169,89", File.ReadAllText(path));
        }
    }
}
