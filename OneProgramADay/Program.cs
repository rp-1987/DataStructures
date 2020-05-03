using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneProgramADay
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayPrograms sut = new ArrayPrograms();
            //int[] inputArray = new int[5] { 9, 8, 1, 2, 3 };
            //int res = sut.FindKthSmallestArrayElement(inputArray, 2);
            //Console.WriteLine("Kth Samllest Element is {0}", res);

            Others sut = new Others();
            int result = sut.PostFixOperationsUsingStack("4572+-*");
            int iterations = Others.iterations;
            Console.ReadKey();
        }
    }
}
