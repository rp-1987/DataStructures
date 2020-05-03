using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrograms.Examples
{
    public class ArrayRotation
    {
        /*
         * Write a function rotate(ar[], d, n) that rotates arr[] of size n by d elements.
         *  1 2 3 4 5 6 7
         *  Rotation of the above array by 2 will make array
         *  3 4 5 6 7 1 2
         */

        public int[] Rotate(int[] inputArray, int d)
        {

            if (inputArray == null || inputArray.Length == 0)
            {
                throw new ArgumentNullException(nameof(inputArray), "Input Array cannot be null or empty");
            }
            else if (d == 0)
            {
                throw new ArgumentNullException(nameof(d), "d cannot be zero");
            }
            else if (d >= inputArray.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(d), "Rotation value should be less than array length");
            }
            else
            {
                int[] outputArray = new int[inputArray.Length];
                int arrayIndex = 0;
                for (int i = d; i < inputArray.Length; i++)
                {
                    outputArray[arrayIndex] = inputArray[i];
                    arrayIndex++;
                }
                for (int i = 0; i < d; i++)
                {
                    outputArray[arrayIndex] = inputArray[i];
                    arrayIndex++;
                }
                return outputArray;
            }


        }

        /*
         * Given a sorted and rotated array, find if there is a pair with a given sum
         *  Input: arr[] = {11, 15, 6, 8, 9, 10}, x = 16
            Output: true
            There is a pair (6, 10) with sum 16

            Input: arr[] = {11, 15, 26, 38, 9, 10}, x = 35
            Output: true
            There is a pair (26, 9) with sum 35

            Input: arr[] = {11, 15, 26, 38, 9, 10}, x = 45
            Output: false
            There is no pair with sum 45.
         */
        public bool FindPairWithGivenSum(int[] inputArray, int sum)
        {

            if (inputArray == null || inputArray.Length == 0)
                throw new ArgumentNullException(nameof(inputArray));
            if (sum == 0)
                throw new ArgumentException("Sum cannot be null");

            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    if (inputArray[i] + inputArray[j] == sum)
                        return true;
                }
            }
            return false;
        }

        /*
         * Given an unsorted array arr of size N, rearrange the elements of array such that number 
         * at the odd index is greater than the number at the previous even index. The task is to 
         * complete the function formatArray() which will return formatted array.
         * Eg: 5 4 3 2 1   --> 4 5 2 3 1
         */
        public int[] RearrangeOddWithPrecedingEvenIndex(int[] inputArray)
        {            
            for(int i = 1; i < inputArray.Length; i = i+2)
            {
                if(inputArray[i-1] > inputArray[i])
                {
                    var temp = inputArray[i - 1];
                    inputArray[i - 1] = inputArray[i];
                    inputArray[i] = temp;
                }
            }
            return inputArray;
        }
    }
}
