using System;
using System.Collections.Generic;
using System.Text;
using Vectors2.Vectors;

namespace Vectors2.VectorIterator
{
    public class SparseVectorIterator : BaseIterator
    {
        private readonly SparseVector _sparseVector;
        private int _current = -1;

        public SparseVectorIterator(SparseVector sparseVector)
        {
            _sparseVector = sparseVector;
        }


        public override bool MoveNext()
        {
            _current++;
            return _current < _sparseVector.Vector.Length;
        }

        public override bool MoveBack()
        {
            _current++;
            return _sparseVector.Size - _current - 1 >= 0;
        }

        public override void Reset()
        {
            _current = -1;
        }

        public override double Norm()
        {
            double sum = 0;
            for (int i = 0; i < _sparseVector.Vector.Length; i++)
            {
                sum += _sparseVector.Vector[i].Item2 * _sparseVector.Vector[i].Item2;
            }

            return Math.Sqrt(sum);
        }

        public override (int, int) Current =>
            _sparseVector.Vector[_current];
    }
}
