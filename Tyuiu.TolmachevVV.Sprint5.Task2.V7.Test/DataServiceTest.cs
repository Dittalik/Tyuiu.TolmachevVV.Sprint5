using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.TolmachevVV.Sprint5.Task2.V7.Lib;

namespace Tyuiu.TolmachevVV.Sprint5.Task2.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service1 = new DataService();

            var path = service1.SaveToFileTextData(new int[,] { { 9, 2, 8 },
                                                                { 7, 1, 2 },
                                                                { 5, 5 , 1 } });
            FileInfo fileInfo = new FileInfo(path);

            Assert.IsTrue(fileInfo.Exists);

            int[,] matrix = { { 0, 2, 8 }, { 0, 0, 2 }, { 0, 0, 0 } };
            string check = "";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0, count = 0; j < 3; j++, count++)
                {
                    if (count != 2)
                    {
                        check += matrix[i, j].ToString() + "\t";
                    }
                    else
                    {
                        check += matrix[i, j].ToString() + "\n";
                    }
                }
            }
            Assert.AreEqual(check, File.ReadAllText(path));
        }
    }
}
