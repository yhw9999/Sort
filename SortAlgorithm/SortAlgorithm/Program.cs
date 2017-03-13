using SortAlgorithm.Swap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            ISort sorter = new Quick();

            sorter.Sort(array);       
        }
    }
}
