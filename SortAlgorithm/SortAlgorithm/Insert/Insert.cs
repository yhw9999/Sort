using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    class Insert : Output, ISort
    {
        public void Sort(int[] array)
        {
            Write(array);

            //main loop
            for (int totalCount = 1; totalCount < array.Length; totalCount++)
            {
                //find index
                for (int index = 0; index < totalCount; index++)
                {
                    if (array[index] > array[totalCount])
                    {
                        InsertNumber(array, index, totalCount);
                    }
                }
            }

            Write(array);

        }

        private void InsertNumber(int[] array, int index, int totalCount)
        {
            int tmp = array[totalCount];

            for (int i = totalCount-1; i > index-1; i--)
            {
                array[i + 1] = array[i];
            }

            array[index] = tmp;
        }
    }
}
