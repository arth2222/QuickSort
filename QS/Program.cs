using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QS
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            int[] arr = { -4, 1, 25, 50, 8, 10, 23 };
            p.QuickSort(arr, 0, arr.Length-1);
        }

        private void QuickSort(int[] arr, int start, int end)
        {
            int i;
            if (start < end)
            {
                i = Partition(arr, start, end);

                QuickSort(arr, start, i - 1);
                QuickSort(arr, i + 1, end);
            }
        }

        // partition function arrange and split the list 
        // into two list based on pivot element
        // In this example, last element of list is chosen 
        // as pivot element. one list contains all elements 
        // less than the pivot element another list contains 
        // all elements greater than the pivot element
        private int Partition(int[] arr, int start, int end)
        {
            int temp;
            int p = arr[end];
            int i = start - 1;

            for (int j = start; j <= end - 1; j++)
            {
                if (arr[j] <= p)
                {
                    i++;
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            temp = arr[i + 1];
            arr[i + 1] = arr[end];
            arr[end] = temp;
            return i + 1;
        }
    }
}
