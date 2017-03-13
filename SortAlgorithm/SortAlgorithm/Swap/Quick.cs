using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm.Swap
{
    class Quick : Sorter, ISort
    {
        Random random = new Random();

        public void Sort(int[] array)
        {
            Write(array);

            int leftIndex = 0;
            int rightIndex = array.Length - 1;

            QuickSort(array, leftIndex, rightIndex);

            Write(array);
        }

        private void QuickSort(int[] array, int leftIndex, int rightIndex)
        {
            int gap = rightIndex - leftIndex;

            if (gap < 3)
            {
                if (gap == 1)
                {
                    if (array[leftIndex] > array[rightIndex])
                    {
                        Swap(array, leftIndex, rightIndex);
                    }
                }

                return;
            }
            else
            {
                //make a pivot number
                int pivot = random.Next(leftIndex+1, rightIndex-1);

                int left = leftIndex;
                int right = rightIndex;

                while (true)
                {
                    while (!(array[left] > array[pivot]) && left < right)
                    {
                        left++;
                    }

                    if (left + 1 == right)
                    {
                        if (array[pivot] > array[left])
                        {
                            Swap(array, left, pivot);

                            //left
                            QuickSort(array, leftIndex, pivot);
                            //right
                            QuickSort(array, pivot+1, rightIndex);
                            break;
                        }
                    }

                    while (!(array[right] < array[pivot]) && left < right)
                    {
                        right--;
                    }

                    if (right - 1 == left)
                    {
                        if (array[pivot] < array[right])
                        {
                            Swap(array, right, pivot);

                            //left
                            QuickSort(array, leftIndex, pivot-1);
                            //right
                            QuickSort(array, pivot, rightIndex);

                            break;
                        }
                    }

                    Swap(array, left, right);
                }
            }
        }
    }
}
