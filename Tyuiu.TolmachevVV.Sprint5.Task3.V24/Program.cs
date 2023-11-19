using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.TolmachevVV.Sprint5.Task3.V24.Lib;

namespace Tyuiu.TolmachevVV.Sprint5.Task3.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService service1 = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Толмачев. В. В. | ПКТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Спринт #5                                                                *");
            Console.WriteLine("*Задание #3                                                               *");
            Console.WriteLine("*Вариант #24                                                               *");
            Console.WriteLine("*Выполнил: Толмачев Виталий Владимирович | ПКТб 23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("x = 3                                                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string path = service1.SaveToFileTextData(3);
            Console.WriteLine("File is written                                                           *");
            Console.WriteLine("***************************************************************************");
            double text;
            using (var reader = new BinaryReader(File.Open(path, FileMode.Open), Encoding.UTF8))
            {
                text = reader.ReadDouble();
            }
            Console.WriteLine(text.ToString());
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
