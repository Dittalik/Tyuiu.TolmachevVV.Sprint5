using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;

namespace Tyuiu.TolmachevVV.Sprint5.Task1.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\vital\source\repos\Tyuiu.TolmachevVV.Sprint5\Tyuiu.TolmachevVV.Sprint5.Task1.V28\bin\Debug\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            Assert.IsTrue(fileInfo.Exists);

            double[] numb = new double[11];

            numb[0] = 59.49;
            numb[1] = 38.47;
            numb[2] = -2.81;
            numb[3] = -19.67;
            numb[4] = -8.42;
            numb[5] = 0.57;
            numb[6] = -6.3;
            numb[7] = -20.14;
            numb[8] = -3.51;
            numb[9] = 38.13;
            numb[10] = 59.6;

            var fh = File.ReadLines(path);
            foreach (string line in fh)
            {
                for (int i = 0; i < line.Split('\t').Length - 1; i++)
                {
                    Assert.AreEqual(numb[i].ToString(), line.Split('\t')[i]);
                }
            }
        }
    }
}
