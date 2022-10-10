using System;

namespace Shapes
{
    interface IPar
    {
        public IShape exportCube(Cube cube);
        public IShape exportLine(Line line);
        public IShape exportSquare(Square square);
        public IShape exportRectangle(Rectangle rectangle);
        public IShape exportCircle(Circle circle);
    }

    class Parexporter : IPar
    {
        private Exporter exporter;

        public IShape exportCube(Cube cube)
        { 
            Console.WriteLine(exporter.exportCube(cube));
            return cube;
        }

        public IShape exportLine(Line line)
        {
            Console.WriteLine(exporter.exportLine(line));
            return line;
        }

        public IShape exportSquare(Square square)
        {
            Console.WriteLine(exporter.exportSquare(square));
            return square;
        }

        public IShape exportRectangle(Rectangle rectangle)
        {
            Console.WriteLine(exporter.exportRectangle(rectangle));
            return rectangle;
        }

        public IShape exportCircle(Circle circle)
        {
            Console.WriteLine("Not supported");
            return circle;
        }

        public Parexporter(Exporter exporter_)
        {
            exporter = exporter_;
        }
    }
}
