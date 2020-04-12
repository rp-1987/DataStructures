using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class QuickSort
    {
        public int[] SortArray(int[] unsortedArray)
        {
            QuickSortArray(unsortedArray, 0, unsortedArray.Length - 1);
            return unsortedArray;
        }

        private void QuickSortArray(int[] unsortedArray, int low, int high)
        {
            if(low < high)
            {
                int partitionIndex = Partition(unsortedArray, low, high);
                QuickSortArray(unsortedArray, low, (partitionIndex - 1));
                QuickSortArray(unsortedArray, (partitionIndex + 1), high);
            }
        }

        private int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];

            int i = low - 1;
            for(int j = low; j < high; j++)
            {
                if(array[j] < pivot)
                {
                    i++;                    
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }

            int temp1 = array[high];
            array[high] = array[i + 1];
            array[i + 1] = temp1;

            return i + 1;
        }
    }
}
