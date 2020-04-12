using System.Collections.Generic;
using System.Linq;

namespace SortingAlgorithms
{
    public class MergeSort
    {
        public int[] SortArray(int[] unsortedArray)
        {
            var result = SortWithMerge(unsortedArray.ToList());

            return result.ToArray();
        }

        private List<int> SortWithMerge(List<int> unsortedArray)
        {
            if (unsortedArray.Count <= 1)
                return unsortedArray;
            List<int> left = new List<int>();
            List<int> right = new List<int>();

            int middle = unsortedArray.Count / 2;
            for(int i = 0; i < middle; i++)
            {
                left.Add(unsortedArray[i]);
            }
            for(int i = middle; i < unsortedArray.Count; i++)
            {
                right.Add(unsortedArray[i]);
            }

            left = SortWithMerge(left);
            right = SortWithMerge(right);

            return Merge(left, right);
        }

        private List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            while(left.Count > 0 || right.Count > 0)
            {
                if(left.Count > 0 && right.Count > 0)
                {
                    if(left.First() < right.First())
                    {
                        result.Add(left.First());
                        left.Remove(left.First());
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if(left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if(right.Count > 0)
                {
                    result.Add(right.First());
                    right.Remove(right.First());
                }
            }

            return result;
        }
    }
}
