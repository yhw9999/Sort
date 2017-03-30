using System;

namespace SortAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            
            int[] array = new int[200000];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, array.Length);
            }

            ISorter sorter = new Quick();

            DateTime start = DateTime.Now;

            sorter.Sort(array);

            Console.WriteLine((DateTime.Now - start).ToString());
        }
    }
}
