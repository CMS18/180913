using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // object s1 = "Min demo sträng";
            // object s2 = new string("Min demo sträng".ToCharArray());

            string s1 = "Min demo sträng";
            string s2 = new string("Min demo sträng".ToCharArray());

            Console.WriteLine("s1 == s2 : " + (s1 == s2));
            Console.WriteLine("s1.Equals(s2) : " + (s1.Equals(s2)));

        }
    }
}
