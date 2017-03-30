using SortAlgorithm.Distribute.Objects;
using System;

namespace SortAlgorithm
{
    class Radix : Sorter, ISorter
    {
        int _positionalNumber = 0;

        public void Sort(ref int[] array)
        {
            _positionalNumber = SetNumberLength(array);

            for (int i = 1; i <= _positionalNumber; i++)
            {
                Buckets tmpBuckets = new Buckets();

                for (int j = 0; j < array.Length; j++)
                {

                    string tmpToString = array[j].ToString();

                    if (tmpToString.Length < i)
                    {
                        tmpBuckets.InputBucket(0, array[j]);
                    }
                    else
                    {
                        tmpBuckets.InputBucket(int.Parse(tmpToString[tmpToString.Length - i].ToString()), array[j]);
                    }
                }

                array = tmpBuckets.GetArray();
            }
        }

        private int SetNumberLength(int[] array)
        {
            int positionalNumber = 0;

            for (int i = 0; i < array.Length; i++)
            {
                string toString = array[i].ToString();

                if (toString.IndexOf('-') != -1)
                {
                    if (toString.Length > positionalNumber)
                    {
                        positionalNumber = toString.Length - 1;
                    }
                }
                else
                {
                    if (toString.Length > positionalNumber)
                    {
                        positionalNumber = toString.Length;
                    }
                }
            }

            return positionalNumber;
        }
    }
}
