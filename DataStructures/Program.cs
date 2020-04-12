using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            var myGraph = new Graph(6);
            myGraph.AddEdge(0, 1);
            myGraph.AddEdge(0, 2);
            myGraph.AddEdge(1, 3);
            myGraph.AddEdge(1, 4);
            myGraph.AddEdge(2, 4);
            myGraph.AddEdge(3, 4);
            myGraph.AddEdge(3, 5);
            myGraph.AddEdge(4, 5);
            //myGraph.BreadthFirstTraversal(5);
            myGraph.DepthFirstTraversal(0);
            Console.ReadKey();
        }
    }
}
