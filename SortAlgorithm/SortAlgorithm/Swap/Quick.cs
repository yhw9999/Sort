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

        void SwapAndSetPivot(int[] array, int index, ref int pivot)
        {
            if (index > pivot)
	        {
                if (array[index] <= array[pivot])
	            {
                    Swap(array, index, pivot);

                    pivot = index;
	            }
	        }
            else if (index < pivot)
	        {
                if (array[index] >= array[pivot])
	            {
                    Swap(array, index, pivot);

                    pivot = index;
	            }
	        }
        }

        private void QuickSort(int[] array, int leftIndex, int rightIndex)
        {
            int gap = rightIndex - leftIndex + 1;

            if (gap == 2)
            {
                    if (array[leftIndex] > array[rightIndex])
                    {
                        Swap(array, leftIndex, rightIndex);
                    }

                return;
            }
            else if(gap > 1)
            {
                //make a pivot number
                int pivot = random.Next(leftIndex, rightIndex);

                Swap(array, pivot, rightIndex);

                pivot = rightIndex;

                int left = leftIndex;
                int right = rightIndex - 1;

                while (true)
                {
                    while (array[left] <= array[pivot] && left < right)
	                {
                        left++;
	                }

                    if (left == right)
                    {
                        if (array[left] >= array[pivot])
	                    {
                            Swap(array, left, pivot);
	                    }

                        pivot = left;
                        //left
                        QuickSort(array, leftIndex, pivot);
                        //right
                        QuickSort(array, pivot+1, rightIndex);

                        break;
                    }

                    while (array[right] >= array[pivot] && left < right)
	                {
                        right--;
	                }

                    if (left == right)
                    {
                        if (array[right] > array[pivot])
	                    {
                            Swap(array, right, pivot);
	                    }


                        pivot = right;

                        //left
                        QuickSort(array, leftIndex, pivot);
                        //right
                        QuickSort(array, pivot+1, rightIndex);

                        break;
                    }

                    Swap(array, left, right);

                }
            }
        }
    }
}
