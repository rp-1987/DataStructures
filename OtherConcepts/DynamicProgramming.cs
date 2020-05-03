using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherConcepts
{
    public class DynamicProgramming
    {

        public static int Iterations = 0;

        public int GetFibonacci(int index)
        {
            Iterations++;
            if (index == 1 || index == 2)
                return 1;
            else
                return GetFibonacci(index - 1) + GetFibonacci(index - 2);
        }

        public int GetFibonacciWithStorage(int index, int[] storage)
        {
            Iterations++;
            int result = 0;
            if (storage.Length >= index && storage[index] != 0)
            {
               return storage[index];
            }
                
            if(index == 1 || index == 2)
            {
                result = 1;
                storage[1] = 1;
                storage[2] = 1;
            }
            else
            {
                result = GetFibonacciWithStorage(index - 1, storage) + GetFibonacciWithStorage(index - 2, storage);
                storage[index] = result;
            }

            return result;
        }

        public int GetFibonacciBottomsUp(int index)
        {
            Iterations++;
            if (index == 1 && index == 2)
                return 1;
            int[] bottomsUpArray = new int[index + 1];
            bottomsUpArray[1] = 1;
            bottomsUpArray[2] = 1;

            for(int i = 3; i <= index; i++)
            {
                Iterations++;
                bottomsUpArray[i] = bottomsUpArray[i - 1] + bottomsUpArray[i - 2];
            }

            return bottomsUpArray[index];
        }


    }
}
