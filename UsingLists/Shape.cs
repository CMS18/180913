using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyDemo
{
    public abstract class Shape
    {
        public double X { get; set; }

        public double Y { get; set; }

        public abstract double GetArea();

        public override string ToString()
        {
            return $"Shape at {X}, {Y}";
        }

        // public virtual double GetArea() { return 0 };


    }
}
