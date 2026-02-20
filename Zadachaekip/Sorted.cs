using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadachaekip
{
    internal class Sorted
    {
        public static int[] SortArray(int[] array, bool ascending)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = 0; j < array.Length - i - 1; j++)
        {
            if ((ascending && array[j] > array[j + 1]) ||
                (!ascending && array[j] < array[j + 1]))
            {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
    }

    return array;
}
    }
}
