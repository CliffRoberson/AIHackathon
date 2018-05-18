using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIHackathon
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> listA = new List<string>();
            List<string> listB = new List<string>();
            using (var reader = new StreamReader(@"dataservices_ubermedia_raw.csv"))
            {
                
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    listA.Add(values[0]);
                    listB.Add(values[1]);
                }
            }

            for (int i=0;i<listA.Count;i++)
            {
                Console.WriteLine(listA[0]);
            }
            


            Console.WriteLine("Say something");

            string response = Console.ReadLine();

            Console.WriteLine("You just said " + response);
            Console.WriteLine("Press any key to quit");
            Console.ReadKey();
        }
    }
}
