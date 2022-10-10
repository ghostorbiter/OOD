using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using SpaceMission.Missions;

namespace SpaceMission
{
    class MyImplementation
    {
        public abstract class Iterator : IEnumerator
        {
            object IEnumerator.Current => Current();

            public abstract double Key();
            public abstract object Current();
            public abstract bool MoveNext();
            public abstract void Reset();
        }

        abstract class IteratorAggregate : IEnumerable
        {
            public abstract IEnumerator GetEnumerator();
        }

        public class ChineseAggregate : Iterator
        {
            private ChineseMission _chineseMission;

            private int position = -1;

            public ChineseAggregate(ChineseMission chineseMission)
            {
                _chineseMission = chineseMission;
            }

            public override object Current()
            {
                return _chineseMission.Route[position];
            }

            public override double Key()
            {
                if (position < _chineseMission.Route.Length && position + 1 < _chineseMission.Route.Length)
                {
                    return _chineseMission.Distances[position, position + 1];
                }
                else
                    return 0;
            }

            public override bool MoveNext()
            {
                int updatedPosition = position + 1;

                if (updatedPosition >= 0 && updatedPosition < _chineseMission.Route.Length)
                {
                    position = updatedPosition;
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public override void Reset()
            {
                position = -1;
            }
        }

        public class AmericanAggregate : Iterator
        {
            private AmericanMission _americanMission;
            private Node node;

            private int position = -1;

            public AmericanAggregate(AmericanMission american)
            {
                _americanMission = american;
            }

            public override object Current()
            {
                node = _americanMission.Root;
                int i = 0;
                while (i < position)
                {
                    node = node.Next;
                }
                return node.Planet;
            }

            public override double Key()
            {
                return node.Distance;
            }

            public override bool MoveNext()
            {
                if (node.Next != null)
                {
                    position++;
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public override void Reset()
            {
                position = -1;
            }
        }
    }
}
