using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TolmachevVV.Sprint5.Task5.V21.Lib
{
    public class DataService : ISprint5Task5V21
    {
        public double LoadFromDataFile(string path)
        {
            string[] strNumbs = File.ReadAllText(path).Split(' ');
            int mostX = int.MinValue;
            foreach (string number in strNumbs)
            {
                if (int.TryParse(number, out int result) && result % 2 == 0 && result > mostX)
                {
                    mostX = result;
                }
            }
            int factX = 1;
            for (int i = 1; i <= mostX; i++)
            {
                factX *= i;
            }
            return factX;
        }
    }
}
