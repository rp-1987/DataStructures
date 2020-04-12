using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class InsertionSort
    {
        public int[] SortArray(int[] inputArray)
        {
            for(int i = 1; i < inputArray.Length; i++)
            {
                for(int j = i; j > 0;j--)
                {
                    if(inputArray[j] < inputArray[j - 1])
                    {
                        var temp = inputArray[j];
                        inputArray[j] = inputArray[j - 1];
                        inputArray[j - 1] = temp;
                    }
                }
            }
            return inputArray;
        }
    }
}
