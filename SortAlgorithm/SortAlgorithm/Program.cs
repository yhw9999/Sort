using System;

namespace SortAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 100);
            }

            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            ISorter sorter = new Radix();

            DateTime start = DateTime.Now;

            sorter.Sort(ref array);

            foreach (var item in array)
            {
                Console.Write(item+" ");

            }
            Console.WriteLine();

            Console.WriteLine((DateTime.Now - start).ToString());
        }
    }
}
