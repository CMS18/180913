using PolyDemo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Shape>();

            var s1 = new Rectangle(10, 10);
            var s2 = new Rectangle(20, 20);

            list.Add(s1);
            list.Add(s2);
            list.Add(new Circle(5));

            foreach (Shape item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"list.Count = {list.Count}");
            list.Add(new Circle(7));
            Console.WriteLine($"list.Count = {list.Count}");

            list.Remove(s2);

            for (int i = 0; i < list.Count; i++)
            {
                Shape item = list[i];
                Console.WriteLine($"Index={i} {item}");
            }

            Console.WriteLine("Remove last item.");
            list.RemoveAt( list.Count-1 );

            for (int i = 0; i < list.Count; i++)
            {
                Shape item = list[i];
                Console.WriteLine($"Index={i} {item}");
            }

        }
    }
}
