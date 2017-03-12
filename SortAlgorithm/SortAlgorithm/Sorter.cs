using System;

namespace SortAlgorithm
{
    internal class Sorter
    {
        protected void Write(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "  ");
            }
            Console.WriteLine();
        }

        protected void Swap(int[] array, int index1, int index2)
        {
            int tmp = array[index1];

            array[index1] = array[index2];

            array[index2] = tmp;
        }
    }
}