using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    /// <summary>
    /// Appication InsertSort Algorithm
    /// </summary>
    public class Shell : Insert, ISort
    {
        public new void Sort(int[] array)
        {
            Write(array);

            int divisionNumber = array.Length / 2;

            while (divisionNumber > 1)
            {
                for (int i = 0; i < divisionNumber; i++)
                {
                    InsertSort(array, divisionNumber, i);
                }

                divisionNumber--;
            }

            //main loop

            base.Sort(array);

            Write(array);
        }
    }

}

