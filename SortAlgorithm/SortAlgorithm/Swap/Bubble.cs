using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    class Bubble : Sorter, ISorter
    {
        public void Sort(int[] array)
        {
            int count = 1;

            while (count < array.Length)
            {
                for (int i = 0; i < array.Length - count; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(array, i, i + 1);
                    }
                }

                count++;
            }
        }
    }
}
