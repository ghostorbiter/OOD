using System;
using System.Collections.Generic;
using System.Text;
using Vectors2.Vectors;

namespace Vectors2.VectorIterator
{
    public class RangeVectorIterator: BaseIterator
    {
        private readonly RangeVector _rangeVector;
        private int _current = -1;
        public RangeVectorIterator(RangeVector rangeVector)
        {
            _rangeVector = rangeVector;
        }

        public override bool MoveNext()
        {
            _current++;
            return _current <= _rangeVector.First;
        }
        public override bool MoveBack()
        {
            _current++;
            return _rangeVector.Last - _current >= _rangeVector.First;
        }

        public override void Reset()
        {
            _current =  -1;
        }

        public override double Norm()
        {
            double sum = 0;
            for (int i = _rangeVector.First; i <= _rangeVector.Last; i++)
            {
                sum += i * i;
            }

            return Math.Sqrt(sum);
        }

        public override (int, int) Current =>
            (_rangeVector.First - _current, _rangeVector.Last);
    }
}
