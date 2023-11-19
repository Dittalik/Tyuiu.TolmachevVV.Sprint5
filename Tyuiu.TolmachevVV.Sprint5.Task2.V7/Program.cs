using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.TolmachevVV.Sprint5.Task2.V7.Lib;

namespace Tyuiu.TolmachevVV.Sprint5.Task2.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService service1 = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Толмачев. В. В. | ПКТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Спринт #5                                                                *");
            Console.WriteLine("*Задание #2                                                               *");
            Console.WriteLine("*Вариант #7                                                               *");
            Console.WriteLine("*Выполнил: Толмачев Виталий Владимирович | ПКТб 23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int[,] matrix = { { 9, 2, 8 }, { 7, 1, 2 }, { 5, 5, 1 } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0, count = 0; j < 3; j++, count++)
                {
                    if (count != 2)
                    {
                        Console.Write(matrix[i, j] + "\t");
                    }
                    else
                    {
                        Console.Write(matrix[i, j] + "\n");
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string path = service1.SaveToFileTextData(matrix);
            Console.WriteLine("File is written                                                           *");
            Console.WriteLine("Path: " + path);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(File.ReadAllText(path));
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
