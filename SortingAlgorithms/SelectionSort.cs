using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class SelectionSort
    {
        public int[] SortArray(int[] inputArray)
        {            
            int min = 0;
            int minIndex = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                min = inputArray[i];
                minIndex = i;
                for(int j = i; j < inputArray.Length; j++)
                {
                    if (inputArray[j] < min)
                    {
                        min = inputArray[j];
                        minIndex = j;
                    }
                        
                }
                var tempList = inputArray.ToList();
                tempList.RemoveAt(minIndex);
                tempList.Insert(i, min);
                inputArray = tempList.ToArray();
                
            }
            return inputArray;
        }
    }
}
