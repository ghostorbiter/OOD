using System;
using System.Collections.Generic;
using System.Text;

namespace Vectors2.VectorIterator
{
    class HadanardProductIterator: BaseIterator
    {
        private BaseIterator _baseIterator1;
        private BaseIterator _baseIterator2;

        public HadanardProductIterator(BaseIterator iterator1, BaseIterator iterator2)
        {
            _baseIterator1 = iterator1;
            _baseIterator2 = iterator2;
        }

        public override bool MoveNext()
        {
            return _baseIterator1.MoveNext() && _baseIterator2.MoveBack();
        }
        public override bool MoveBack()
        {
            return false;
        }

        public override void Reset()
        {
            _baseIterator1.Reset();
            _baseIterator2.Reset();
        }

        public override double Norm()
        {
            return 1;
        }

        public override (int, int) Current
        {
            get
            {
                _baseIterator1.Reset();
                _baseIterator2.Reset();

                (int, int)? result = null;

                while (_baseIterator1.MoveNext() && _baseIterator2.MoveBack())
                {
                    var (position, distance) = _baseIterator1.Current;
                    result = ((int, int)?)(result.HasValue ? (result.Value.Item1, result.Value.Item2 * _baseIterator2.Current.Item2) : (position, distance));
                }

                return result.Value;
            }
        }
    }
}
