using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Graph
    {
        private int _vertices;
        private List<int>[] _adjencency;
        public Graph(int vertices)
        {
            _vertices = vertices;
            _adjencency = new List<int>[vertices];
            for (int i = 0; i < vertices; i++)
                _adjencency[i] = new List<int>();
        }

        public void AddEdge(int v, int w)
        {
            _adjencency[v].Add(w);
        }

        public void BreadthFirstTraversal(int vertex)
        {
            bool[] visited = new bool[_vertices];
            for (int i = 0; i < _vertices; i++)
                visited[i] = false;

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(vertex);

            while(queue.Count != 0)
            {
                vertex = queue.Dequeue();
                Console.WriteLine(vertex.ToString());

                foreach(int i in _adjencency[vertex])
                {
                    if(!visited[i])
                    {
                        visited[i] = true;
                        queue.Enqueue(i);
                    }
                }
            }
        }

        public void DepthFirstTraversal(int vertex)
        {
            bool[] visited = new bool[_vertices];

            DFSUtil(vertex, visited);
        }

        private void DFSUtil(int vertex, bool[] visited)
        {
            visited[vertex] = true;
            Console.WriteLine(vertex.ToString());
            
            foreach(int i in _adjencency[vertex])
            {
                if (!visited[i])
                    DFSUtil(i, visited);
            }
        }
    }
}
