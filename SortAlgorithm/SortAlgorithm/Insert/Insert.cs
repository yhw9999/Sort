using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    public class Insert : Sorter, ISorter
    {
        public void Sort(ref int[] array)
        {
            Write(array);

            InsertSort(array);

            Write(array);
        }

        protected void InsertSort(int[] array, int gap=1, int startIndex = 0)
        {
            for (int mainIndex = startIndex; mainIndex < array.Length; mainIndex+= gap)
            {
                try
                {
                    if (mainIndex+gap < array.Length)
                    {
                        if (array[mainIndex] > array[mainIndex + gap])
                        {
                            InsertNumber(array, mainIndex, startIndex, gap);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Over range");
                }
            }

            //main loop
            //for (int totalCount = startIndex; totalCount < array.Length; totalCount += gap)
            //{
            //    //find index
            //    for (int index = startIndex+gap; index < totalCount; index += gap)
            //    {
            //        if (array[index] > array[totalCount])
            //        {
            //            InsertNumber(array, index, totalCount, gap);
            //        }
            //    }
            //}
        }

        protected void InsertNumber(int[] array, int index, int startIndex, int gap)
        {
            //backup value
            int tmp = array[index+gap];

            int findIndex = startIndex;

            for (int i = startIndex; i <= index; i+= gap)
            {
                if (tmp <= array[i])
                {
                    findIndex = i;

                    break;
                }
            }

            for (int i = index+gap; i > findIndex; i-=gap)
            {
                array[i] = array[i - gap];
            }

            array[findIndex] = tmp;
        }
    }
}
