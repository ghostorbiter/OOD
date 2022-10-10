using System;

namespace Shapes
{
    class Exporter : IPar
    {
        private int _compressionLevel;
        public bool _isSVG = false;

        public Exporter(int compressionLevel_, bool isSVG)
        {
            _compressionLevel = compressionLevel_;
            _isSVG = isSVG;
        }
        public IShape exportCube(Cube shape)
        {
            if (_isSVG)
            {
                Console.WriteLine("Exporting Cube: " + shape.ToString());
            }
            else
            {
                Random rng = new Random();
                Cube copy = (Cube)shape.Clone();
                copy.Scale(rng.NextDouble() + 0.1 * _compressionLevel);
                copy.Translate(rng.Next(-_compressionLevel, _compressionLevel), rng.Next(-_compressionLevel, _compressionLevel));

                Console.WriteLine($"Exporting Cube: " + copy.ToString());
            }

            return shape;
        }

        public IShape exportLine(Line shape)
        {
            if (_isSVG)
            {
                Console.WriteLine("Exporting Line:" + shape.ToString());
            }
            else
            {
                Random rng = new Random();
                Line copy = (Line)shape.Clone();
                copy.Scale(rng.NextDouble() + 0.1 * _compressionLevel);
                copy.Translate(rng.Next(-_compressionLevel, _compressionLevel), rng.Next(-_compressionLevel, _compressionLevel));

                Console.WriteLine($"Exporting Cube: " + copy.ToString());
            }

            return shape;
        }

        public IShape exportSquare(Square shape)
        {
            if (_isSVG)
            {
                Console.WriteLine("Exporting Square:" + shape.ToString());
            }
            else
            {
                Random rng = new Random();
                Square copy = (Square)shape.Clone();
                copy.Scale(rng.NextDouble() + 0.1 * _compressionLevel);
                copy.Translate(rng.Next(-_compressionLevel, _compressionLevel), rng.Next(-_compressionLevel, _compressionLevel));

                Console.WriteLine($"Exporting Cube: " + copy.ToString());
            }

            return shape;
        }

        public IShape exportRectangle(Rectangle shape)
        {
            if (_isSVG)
            {
                Console.WriteLine("Exporting Rectangle:" + shape.ToString());
            }
            else
            {
                Random rng = new Random();
                Rectangle copy = (Rectangle)shape.Clone();
                copy.Scale(rng.NextDouble() + 0.1 * _compressionLevel);
                copy.Translate(rng.Next(-_compressionLevel, _compressionLevel), rng.Next(-_compressionLevel, _compressionLevel));

                Console.WriteLine($"Exporting Cube: " + copy.ToString());
            }

            return shape;
        }

        public IShape exportCircle(Circle shape)
        {
            if (_isSVG)
            {
                Console.WriteLine("Exporting Circle:" + shape.ToString());
            }
            else
            {
                Random rng = new Random();
                Circle copy = (Circle)shape.Clone();
                copy.Scale(rng.NextDouble() + 0.1 * _compressionLevel);
                copy.Translate(rng.Next(-_compressionLevel, _compressionLevel), rng.Next(-_compressionLevel, _compressionLevel));

                Console.WriteLine($"Exporting Cube: " + copy.ToString());
            }

            return shape;
        }
    }
}