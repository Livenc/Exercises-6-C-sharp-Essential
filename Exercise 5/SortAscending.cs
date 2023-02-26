using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    public static class MyExtensions
    {
        public static void SortAscending(this int[] array)
        {
            int n = array.Length;
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i < n - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        swapped = true;
                    }
                }
                n--;
            } while (swapped);
        }
    }

}
