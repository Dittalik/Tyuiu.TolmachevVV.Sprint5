using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.TolmachevVV.Sprint5.Task6.V21.Lib;

namespace Tyuiu.TolmachevVV.Sprint5.Task6.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService service1 = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Толмачев. В. В. | ПКТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Спринт #5                                                                *");
            Console.WriteLine("*Задание #6                                                               *");
            Console.WriteLine("*Вариант #21                                                              *");
            Console.WriteLine("*Выполнил: Толмачев Виталий Владимирович | ПКТб 23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = @"C:\DataSprint5\InPutDataFileTask6V21.txt";
            Console.WriteLine("File path: " + path);
            Console.WriteLine("data is: ");
            Console.WriteLine(File.ReadAllText(path));
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("тт count: ");
            Console.WriteLine(service1.LoadFromDataFile(path));
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
