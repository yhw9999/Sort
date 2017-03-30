using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    class Merge : Sorter, ISorter
    {
        //if the length of section is 1, merge and sort 
        //else divide section to half
        public void Sort(int[] array)
        {
            Write(array);

            if (array.Length > 1)
            {
                int left = 0;
                int right = array.Length - 1;

                int half = (right + left) / 2;

                Divide(left, half, array);
                Divide(half + 1, right, array);
                MergeAndSort(left, right, array);
            }

            Write(array);
        }

        void Divide(int left, int right, int[] array)
        {
            int sectionLength = (right - left) + 1;

            if (sectionLength > 2)
            {
                int half = (right + left) / 2;

                Divide(left, half, array);
                Divide(half + 1, right, array);
                MergeAndSort(left, right, array);
            }
        }

        void MergeAndSort(int leftIndex, int rightIndex, int[] array)
        {
            int[] tmpArray = new int[rightIndex - leftIndex + 1];

            Array.Copy(array, leftIndex, tmpArray, 0, tmpArray.Length);

            for (int i = leftIndex; i <= rightIndex; i++)
            {
                array[i] = GetLeast(tmpArray);
            }
        }

        private int GetLeast(int[] tmpArray)
        {
            int least = int.MaxValue;
            int index = 0;

            for (int i = 0; i < tmpArray.Length; i++)
            {
                if (tmpArray[i] != int.MaxValue)
                {
                    if (least >= tmpArray[i])
                    {
                        index = i;
                        least = tmpArray[i];
                    }
                }
            }

            tmpArray[index] = int.MaxValue;

            return least;
        }
    }
}
