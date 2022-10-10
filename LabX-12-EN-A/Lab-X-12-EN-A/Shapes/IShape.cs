using System;

namespace Shapes
{
    interface IShape : ICloneable
    {
        //string Name { get; }
        void Scale(double factor);
        void Translate(double dx, double dy);
        void export(IPar e);
    }
}