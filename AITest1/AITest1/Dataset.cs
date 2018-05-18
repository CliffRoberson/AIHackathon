using System;
using System.Collections.Generic;
using System.Text;

namespace AITest1
{
    public class Dataset
    {



        public static void Open(string filePath)
        {
            Console.WriteLine($"Loading dataset {filePath}");

            string[] dataLines = System.IO.File.ReadAllLines(filePath);

            foreach (var line in dataLines)
            {
                string[] rows = line.Split(',');
            }

            Console.WriteLine($"Done loading dataset {filePath}");
        }
    }
}
