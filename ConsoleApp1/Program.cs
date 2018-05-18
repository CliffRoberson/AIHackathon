using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Say something");

            string response = Console.ReadLine();

            Console.WriteLine("You just said " + response);
            Console.ReadKey();
        }
    }
}
