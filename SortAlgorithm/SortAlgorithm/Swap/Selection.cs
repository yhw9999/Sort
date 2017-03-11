using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm.Swap
{
    class Selection : ISort
    {
        public void Sort()
        {
            int[] array = new int[20];

            Random random = new Random();

            int minimum = int.MaxValue;

            int index = 0;

            int count = 0;

            bool complete;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 50);

                Console.Write(array[i] + "  ");
            }
            Console.WriteLine();


            while (true)
            {
                if (count == array.Length)
                {
                    break;
                }

                for (int i = count; i < array.Length; i++)
                {
                    if (array[i] < minimum)
                    {
                        minimum = array[i];
                        index = i;
                    }
                }

                minimum = int.MaxValue;

                Swap(array, count++, index);
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "  ");
            }
        }

        private void Swap(int[] array, int count, int index)
        {
            int tmp = array[count];

            array[count] = array[index];

            array[index] = tmp;
        }
    }
}
