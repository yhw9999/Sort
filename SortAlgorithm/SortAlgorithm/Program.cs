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
            ISort sorter = new Selection();

            sorter.Sort();       
        }
    }
}
