using System;

namespace Shapes
{
    class Rectangle : IShape
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public string Name { get => "Rectangle"; }

        public Rectangle(double x, double y, double width, double height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public void Scale(double factor)
        {
            Width *= factor;
            Height *= factor;
        }

        public void Translate(double dx, double dy)
        {
            X += dx;
            Y += dy;
        }

        public object Clone()
        {
            return new Rectangle(X, Y, Width, Height);
        }

        public override string ToString()
        {
            return $"({X}, {Y}), Width = {Width}, Height = {Height}";
        }

        //public void export(Mode m, int compressionLvl)
        //{
        //    if (m == Mode.SVG)
        //    {
        //        System.Console.WriteLine("Exporting Rectangle:" + this.ToString());
        //    }
        //    else
        //    {
        //        Random rng = new Random();
        //        Rectangle square = (Rectangle)this.Clone();
        //        square.Scale(rng.NextDouble() + 0.1 * compressionLvl);
        //        square.Translate(rng.Next(-compressionLvl, compressionLvl), rng.Next(-compressionLvl, compressionLvl));
        //        System.Console.WriteLine("Exporting Rectangle:" + square.ToString());
        //    }
        //}

        public void export(IPar e)
        {
            e.exportRectangle(this);
        }
    }
}