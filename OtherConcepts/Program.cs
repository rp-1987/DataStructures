using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            var sut = new DynamicProgramming();
            int requestedIndex = 25;
            //int[] storage = new int[requestedIndex + 1];
            //var res = sut.GetFibonacciWithStorage(requestedIndex, storage);
            //var res = sut.GetFibonacci(requestedIndex);
            var res = sut.GetFibonacciBottomsUp(requestedIndex);
            Console.WriteLine("Fibonacci no {0} is {1} with {2} iterations", 
                requestedIndex.ToString() , res.ToString(), DynamicProgramming.Iterations.ToString());
            Console.ReadKey();
        }
    }
}
