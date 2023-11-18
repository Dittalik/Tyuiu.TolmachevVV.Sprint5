using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TolmachevVV.Sprint5.Task1.V28.Lib
{
    public class DataService : ISprint5Task1V28
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt";
            double form;
            string result = "";
            for (int i = startValue; i <= stopValue; i++)
            {
                form = Math.Round((Math.Cos(i) / (i - 0.7)) - (Math.Sin(i) * 12 * i) + 2, 2);
                if (double.IsInfinity(form) || double.IsNaN(form))
                {
                    form = 0;
                }
                result += form.ToString() + "\t";
            }
            File.WriteAllText(path, result);
            return path;
        }
    }
}
