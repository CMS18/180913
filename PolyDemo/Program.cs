using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Shape shape1 = new Shape(); -- Går inte!

            Shape shape1 = new Circle();
            shape1.X = 10;
            shape1.Y = 10;

            Circle circle2 = new Circle();
            circle2.X = 15;
            circle2.Y = 15;
            circle2.Diameter = 30;  // circle.setDiameter( 30 );
            

            Console.WriteLine(circle2.Circumference); // Console.WriteLine( circle1.getRadius() );

            Shape shape3 = new Rectangle() { Width = 10, Height = 10 };
            Rectangle rectangle4 = new Rectangle();
            rectangle4.Width = 10;
            rectangle4.Height = 10;

            Shape shape5;
            Rectangle rectangle6;

            shape5 = circle2;
            //rectangle6 = shape3;  // Går inte - Basklass kan peka på subklasser men inte tvärt om;
            rectangle6 = (Rectangle)shape3;

            Console.WriteLine("(shape3 is Rectangle) : " + (shape3 is Rectangle));
            Console.WriteLine("(shape3 is Circle) : " + (shape3 is Circle));
            Console.WriteLine("(shape3 is Shape) : " + (shape3 is Shape));

            Console.WriteLine("(rectangle6 is Rectangle) : " + (rectangle6 is Rectangle));
            Console.WriteLine("(rectangle6 is Circle) : " + (rectangle6 is Circle));
            Console.WriteLine("(rectangle6 is Shape) : " + (rectangle6 is Shape));

            Console.WriteLine("circle2.GetArea() : " + circle2.GetArea());
            Console.WriteLine("rectangle6.GetArea() : " + rectangle6.GetArea());
            Console.WriteLine("shape3.GetArea() : " + shape3.GetArea());
            Console.WriteLine("shape5.GetArea() : " + shape5.GetArea());


            if (shape1 is Rectangle)
            {
                rectangle6 = (Rectangle)shape1;
            }

            Rectangle rectangle7 = shape1 as Rectangle;
            // Rectangle rectangle7 = (Rectangle)shape1; Explicit cast - Avbryter exekvering om fel typ.


        }
    }
}
