using System;
using System.Collections.Generic;
using System.Text;

namespace AITest1
{
    public class Dataset
    {
        private Dictionary<string, int> Headers;
        private string[][] Values;

        public int Count { get; set; }

        public Dataset(string filePath, Dictionary<string, int> headers)
        {
            Open(filePath, headers);
        }

        public void Open(string filePath, Dictionary<string, int> headers)
        {
            Console.WriteLine($"Loading dataset {filePath}");

            Headers = headers;
            string[] dataLines = System.IO.File.ReadAllLines(filePath);
            Array.Resize(ref Values, dataLines.Length);
            Count = dataLines.Length;

            for (int i = 0; i < dataLines.Length; i++)
            {
                string[] rows = dataLines[i].Split(',');
                Array.Resize(ref Values[i], rows.Length);

                for (int j = 0; j < rows.Length; j++)
                {
                    Values[i][j] = rows[j];
                }
            }

            Console.WriteLine($"Done loading dataset {filePath}");
        }

        public string GetValue(string headerName, int index)
        {
            return Values[index][Headers[headerName]];
        }
    } // EOC
}
