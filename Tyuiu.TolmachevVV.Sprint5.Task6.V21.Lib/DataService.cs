﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.TolmachevVV.Sprint5.Task6.V21.Lib
{
    public class DataService : ISprint5Task6V21
    {
        public int LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                int count = 0;
                string content = reader.ReadLine().ToLower();
                for (int i = 0; i < content.Length; i++)
                {
                    if (content[i] == 'т' && content[i + 1] == 'т')
                    {
                        count++;
                    }
                }
                return count;
            }
        }
    }
}
