using System;

namespace Shapes
{
    class Circle : IShape
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Radius { get; set; }
        public string Name { get => "Circle"; }

        public Circle(double x, double y, double radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }

        public void Scale(double factor)
        {
            Radius *= factor;
        }

        public void Translate(double dx, double dy)
        {
            X += dx;
            Y += dy;
        }

        public object Clone()
        {
            return new Circle(X, Y, Radius);
        }

        public override string ToString()
        {
            return $"({X}, {Y}), R = {Radius}";
        }

        //public void export(Mode m, int compressionLvl)
        //{
        //    if (m == Mode.SVG)
        //    {
        //        System.Console.WriteLine("Exporting Circle:" + this.ToString());
        //    }
        //    else
        //    {
        //        Random rng = new Random();
        //        Circle square = (Circle)this.Clone();
        //        square.Scale(rng.NextDouble() + 0.1 * compressionLvl);
        //        square.Translate(rng.Next(-compressionLvl, compressionLvl), rng.Next(-compressionLvl, compressionLvl));
        //        System.Console.WriteLine("Exporting Circle:" + square.ToString());
        //    }
        //}

        public void export(IPar e)
        {
            e.exportCircle(this);
        }
    }
}