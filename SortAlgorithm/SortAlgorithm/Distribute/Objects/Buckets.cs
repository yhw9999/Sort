using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm.Distribute.Objects
{
    class Buckets
    {
        List<int>[] _buckets;

        public Buckets()
        {
            _buckets = new List<int>[10];

            for (int i = 0; i < _buckets.Length; i++)
            {
                _buckets[i] = new List<int>();
            }
        }

        internal void InputBucket(int index, int number)
        {
            _buckets[index].Add(number);
        }

        internal int[] GetArray()
        {
            int length = 0;

            int count = 0;

            Array.ForEach(_buckets, element => length += element.Count);

            int[] tmpArray = new int[length];

            Array.ForEach(_buckets, element => element.ForEach(item => tmpArray[count++] = item));

            return (int[])tmpArray.Clone();
        }
    }
}
