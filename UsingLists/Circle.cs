using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyDemo
{
    class Circle : Shape
    {
        private double _radius;

        public Circle(int radius)
        {
            this._radius = radius;
        }

        public double Radius {
            get
            {
                return _radius;
            }
            set
            {
                _radius = value;
            }
        }

        public double Diameter
        {
            get // public double getDiameter() -- Läser ut / beräknar Diameter
            {
                return Radius * 2;
            }

            set // public void setDiameter(double value) -- Skriver/Sätter ett nytt värde
            {
                Radius = value / 2;
            }

        }

        public double Circumference // Omkrets
        { 
            get
            {
                return Diameter * Math.PI;
            }

            set
            {
                Diameter = value / Math.PI;
            }
        }

        public override double GetArea()
        {
            return Radius*Radius*Math.PI;
        }

        public override string ToString()
        {
            return $"Circle at {X}, {Y}. Radius={Radius}.";
        }
    }
}
