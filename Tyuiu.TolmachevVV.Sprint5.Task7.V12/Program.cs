﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.TolmachevVV.Sprint5.Task7.V12.Lib;

namespace Tyuiu.TolmachevVV.Sprint5.Task7.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService service = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Толмачев. В. В. | ПКТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Спринт #5                                                                *");
            Console.WriteLine("*Задание #6                                                               *");
            Console.WriteLine("*Вариант #21                                                              *");
            Console.WriteLine("*Выполнил: Толмачев Виталий Владимирович | ПКТб 23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = @"C:\DataSprint5\InPutDataFileTask7V12.txt";
            Console.WriteLine("File path: ");
            Console.WriteLine(path);
            Console.WriteLine("data is: ");
            Console.WriteLine(File.ReadAllText(path));
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("File is written, path: ");
            string outputpath = service.LoadDataAndSave(path);
            Console.WriteLine(outputpath);
            Console.WriteLine(File.ReadAllText(outputpath));
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
