using ArrayPrograms.Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayRotation arrayRotation = new ArrayRotation();
            int[] inputArray = new int[5] { 1, 2, 3, 4, 5 };
            int[] outputArray =  arrayRotation.Rotate(inputArray, 2);

            for(int i = 0; i < outputArray.Length; i++)
            {
                Console.Write(outputArray[i].ToString());
                Console.Write("  ");
            }

            Console.ReadKey();
        }
    }
}
