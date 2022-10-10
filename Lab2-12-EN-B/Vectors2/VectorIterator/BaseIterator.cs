using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Vectors2.Vectors;

namespace Vectors2.VectorIterator
{
    public abstract class BaseIterator: IEnumerator<(int, int)>
    {
        public abstract (int, int) Current { get; }
        object IEnumerator.Current =>
            Current;

        public abstract bool MoveNext();

        public abstract bool MoveBack();

        public abstract void Reset();

        public abstract double Norm();

        public virtual void Dispose() { }
    }
}
