using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TolmachevVV.Sprint5.Task3.V24.Lib
{
    public class DataService : ISprint5Task3V24
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask3.bin";
            double result = Math.Round(6.1 * Math.Pow(x, 3) + 0.23 * Math.Pow(x, 2) + 1.04 * x, 3);
            using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                binaryWriter.Write(BitConverter.ToString(BitConverter.GetBytes(result)));
            }
            return path;
        }
    }
}
