using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm.Swap
{
    class Selection : Output, ISort
    {
        public void Sort(int[] array)
        {
            int minimum = int.MaxValue;

            int index = 0;

            int count = 0;

            bool complete;

            Write(array);

            while (true)
            {
                if (count == array.Length)
                {
                    break;
                }

                for (int i = count; i < array.Length; i++)
                {
                    if (array[i] < minimum)
                    {
                        minimum = array[i];
                        index = i;
                    }
                }

                minimum = int.MaxValue;

                Swap(array, count++, index);
            }

            Write(array);

        }

        private void Swap(int[] array, int count, int index)
        {
            int tmp = array[count];

            array[count] = array[index];

            array[index] = tmp;
        }
    }
}
