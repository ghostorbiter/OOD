using System;
using Vectors2.VectorIterator;
using Vectors2.Vectors;

namespace Vectors2
{
    public static class Algorithms
    {
        public static BaseIterator Normalized(BaseIterator iterator)
        {
            return new NormalizedIterator(iterator);
        }

        public static BaseIterator ReversedHadamardProduct(BaseIterator iterator1, BaseIterator iterator2)
        {
            return new HadanardProductIterator(iterator1, iterator2);
        }

        public static void PrintVector(BaseIterator iterator)
        {
            while(iterator.MoveNext())
            {
                Console.WriteLine($"[{iterator.Current.Item1}, {iterator.Current.Item2}] ");
            }
        }
    }
}
