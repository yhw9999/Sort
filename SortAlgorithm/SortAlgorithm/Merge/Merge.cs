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
            if (array.Length > 1)
            {
                int left = 0;
                int right = array.Length - 1;

                int half = (right - left) / 2;

                Divide(left, half, array);
                Divide(half + 1, right, array);
                MergeAndSort(left, half, right, array);
            }
        }

        void Divide(int left, int right, int[] array)
        {
            int sectionLength = right - left;

            if (sectionLength > 3)
            {
                int half = (right - left) / 2;

                Divide(left, half, array);
                Divide(half + 1, right, array);
                MergeAndSort(left, half, right, array);
            }
        }

        void MergeAndSort(int leftIndex, int halfIndex, int rightIndex, int[] array)
        {
            int[] tmpLeftArray = new int[halfIndex - leftIndex];
            int[] tmpRighArray = new int[rightIndex - halfIndex];

            Array.Copy(array, leftIndex, tmpLeftArray, 0, halfIndex - leftIndex);
            Array.Copy(array, halfIndex, tmpRighArray, 0, rightIndex - halfIndex);


        }
    }
}
