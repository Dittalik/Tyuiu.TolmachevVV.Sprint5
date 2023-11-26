using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TolmachevVV.Sprint5.Task7.V12.Lib
{
    public class DataService : ISprint5Task7V12
    {
        public string LoadDataAndSave(string path)
        {
            string outputpath = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask7V12.txt";

            using (StreamReader reader = new StreamReader(path))
            {
                string line = reader.ReadLine().ToUpper() + Environment.NewLine;
                File.WriteAllText(outputpath, line);
            }
            return outputpath;
        }
    }
}
