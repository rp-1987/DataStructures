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
                throw new ArgumentNullException("inputArray", "Input Array cannot be null or empty");
            }
            else if (d == 0)
            {
                throw new ArgumentNullException("d", "d cannot be zero");
            }
            else if (d >= inputArray.Length)
            {
                throw new ArgumentOutOfRangeException("d", "Rotation value should be less than array length");
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

            for(int i = 0; i < inputArray.Length; i++)
            {
                for(int j = i+1; j < inputArray.Length; j++)
                {
                    if (inputArray[i] + inputArray[j] == sum)
                        return true;                    
                }
            }
            return false;
        }

    }
}
