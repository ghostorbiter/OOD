using System;

namespace Shapes
{
    class Cube : IShape
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public double Length { get; set; }
        public string Name { get => "Cube"; }

        public Cube(double x, double y, double z, double length)
        {
            X = x;
            Y = y;
            Z = z;
            Length = length;
        }

        public void Scale(double factor)
        {
            Length *= factor;
        }

        public void Translate(double dx, double dy)
        {
            X += dx;
            Y += dy;
        }

        public object Clone()
        {
            return new Rectangle(X, Y, Z, Length);
        }

        public override string ToString()
        {
            return $"({X}, {Y}, {Z}), Length = {Length}";
        }

        //public void export(Mode m, int compressionLvl)
        //{
        //    if (m == Mode.SVG)
        //    {
        //        System.Console.WriteLine("Exporting Cube:" + this.ToString());
        //    }
        //    else
        //    {
        //        Random rng = new Random();
        //        Cube square = (Cube)this.Clone();
        //        square.Scale(rng.NextDouble() + 0.1 * compressionLvl);
        //        square.Translate(rng.Next(-compressionLvl, compressionLvl), rng.Next(-compressionLvl, compressionLvl));
        //        System.Console.WriteLine("Exporting Cube:" + square.ToString());
        //    }
        //}

        public void export(IPar e)
        {
            e.exportCube(this);
        }
    }
}