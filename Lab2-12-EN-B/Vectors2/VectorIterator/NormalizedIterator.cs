using System;
using System.Collections.Generic;
using System.Text;

namespace Vectors2.VectorIterator
{
    public class NormalizedIterator : BaseIterator
    {
        private BaseIterator _baseIterator;

        public NormalizedIterator(BaseIterator iterator)
        {
            _baseIterator = iterator;
        }

        public override bool MoveNext()
        {
            return _baseIterator.MoveNext();
        }
        public override bool MoveBack()
        {
            return _baseIterator.MoveBack();
        }

        public override void Reset()
        {
            _baseIterator.Reset();
        }

        public override double Norm()
        {
            return _baseIterator.Norm();
        }

        public override (int, int) Current
        {
            get
            {
                //_baseIterator.Reset();
                (int, int)? result = null;

                var (position, distance) = _baseIterator.Current;
                result = ((int, int)?)(result.HasValue ? (result.Value.Item1, result.Value.Item2 / _baseIterator.Norm()) : (position, distance));

                return result.Value;
            }
        }
    }
}
