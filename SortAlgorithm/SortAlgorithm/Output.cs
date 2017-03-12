using System;

namespace SortAlgorithm
{
    internal class Output
    {
        protected void Write(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "  ");
            }
            Console.WriteLine();
        }
    }
}