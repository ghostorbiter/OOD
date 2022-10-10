using System;
using System.Collections.Generic;
using Shapes;

namespace lab4a_en
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square(0, 5, 2);
            var rectangle = new Rectangle(-1, -2, 14.5, 29);
            var circle = new Circle(10, 50, 0.5);
            var line = new Line(0.4, 0.5, 1, 1);

            var shapes = new List<IShape>() { square, rectangle, circle, line };

            Console.WriteLine("-----------------------------SVG------------------------------");

            foreach(IShape shape in shapes)
            {
                Exporter exp = new Exporter(1, true);
                shape.export(exp);
            }

            Console.WriteLine("-----------------------------\\SVG------------------------------");



            Console.WriteLine("-----------------------------JPG------------------------------");

            foreach (IShape shape in shapes)
            {
                Exporter exp = new Exporter(1, false);
                shape.export(exp);
            }

            Console.WriteLine("-----------------------------\\JPG------------------------------");

            Console.WriteLine("-----------------------------Parallel------------------------------");

            foreach (IShape shape in shapes)
            {
                Parexporter exp = new Parexporter(new Exporter(1, true));
                shape.export(exp);
            }

            Console.WriteLine("-----------------------------\\Parallel------------------------------");
        }
    }
}
