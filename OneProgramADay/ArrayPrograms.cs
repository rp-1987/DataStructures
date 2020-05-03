using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneProgramADay
{
    public class ArrayPrograms
    {
        /*
         * Given an array arr[] and a number K where K is smaller than size of array, 
         * the task is to find the Kth smallest element in the given array. 
         * It is given that all array elements are distinct.
         */
        public int FindKthSmallestArrayElement(int[] inputArray, int k)
        {
            int[] smallElements = new int[k];
            int smallest = 0;
            for(int i = 0; i < k; i++)
            {
                smallest = FindSmallest(inputArray);
                inputArray = RemoveArrayElement(inputArray, smallest);
            }
            return smallest;
        }

        private int FindSmallest(int[] inputArray)
        {
            int smallest = inputArray[0];
            for (int i = 1; i < inputArray.Length; i++)
            {
                if (inputArray[i] < inputArray[i - 1])
                    smallest = inputArray[i];
            }
            return smallest;
        }

        private int[] RemoveArrayElement(int[] inputArray, int elementToRemove)
        {
            int elementIndex = Array.IndexOf(inputArray, elementToRemove);
            inputArray = inputArray.Where((val, idx) => idx != elementIndex).ToArray();
            return inputArray;
        }
    }
}
