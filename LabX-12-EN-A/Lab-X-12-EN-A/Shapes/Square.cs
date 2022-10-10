using System;

namespace Shapes
{
    class Square : IShape
    {
        
        public double X { get; set; }
        public double Y { get; set; }
        public double SideLength { get; set; }
        public string Name { get => "Square"; }

        public Square(double x, double y, double sideLength)
        {
            X = x;
            Y = y;
            SideLength = sideLength;
        }

        public void Scale(double factor)
        {
            SideLength *= factor;
        }

        public void Translate(double dx, double dy)
        {
            X += dx;
            Y += dy;
        }

        public object Clone()
        {
            return new Square(X, Y, SideLength);
        }

        public override string ToString()
        {
            return $"({X}, {Y}), side length = {SideLength}";
        }

        //public void export(Mode m, int compressionLvl)
        //{
        //    if (m == Mode.SVG)
        //    {
        //        System.Console.WriteLine("Exporting Square:" + this.ToString());
        //    }
        //    else
        //    {
        //        Random rng = new Random();
        //        Square square = (Square)this.Clone();
        //        square.Scale(rng.NextDouble() + 0.1 * compressionLvl);
        //        square.Translate(rng.Next(-compressionLvl, compressionLvl), rng.Next(-compressionLvl, compressionLvl));
        //        System.Console.WriteLine("Exporting Square:" + square.ToString());
        //    }
        //}

        public void export(IPar e)
        {
            e.exportSquare(this);
        }
    }
}