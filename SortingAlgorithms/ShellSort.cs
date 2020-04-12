using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class ShellSort
    {
        public int[] SortArray(int[] unsortedArray)
        {
            if(unsortedArray.Length > 1)
            {
                int arrayLength = unsortedArray.Length;
                int gap = arrayLength / 2;
                while(gap >= 1)
                {
                    for(int i = gap; i < arrayLength;i = i + gap)
                    {
                        for(int j = i; j > 0; j = j- gap)
                        {
                            if(unsortedArray[j - gap] > unsortedArray[j])
                            {
                                int temp = unsortedArray[j];
                                unsortedArray[j] = unsortedArray[j - gap];
                                unsortedArray[j - gap] = temp;
                            }
                        }
                    }
                
                    gap = gap / 2;
                }
            }
            return unsortedArray;
        }
    }
}
