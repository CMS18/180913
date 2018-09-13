using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string>();

            list.Add("Theodor");
            list.Add("Sebastian");
            list.Add("Linea");
            list.Add("Fredrik");

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Sort()");

            list.Sort();

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
