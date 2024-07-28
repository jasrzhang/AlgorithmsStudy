using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsStudy.Graphs
{
    public class Graphs
    {

        public int Vertices;
        public int[,] adjMat;
        int[] Visited;

        public Graphs(int n)
        {
            Vertices = n;
            adjMat = new int[n, n];
            Visited = new int[Vertices];
        }

        public void InsertEdge(int u, int v, int x)
        { // x is the Cost of Edge
            adjMat[u, v] = x;
        }

        public void RemoveEdge(int u, int v)
        {
            adjMat[u, v] = 0;
        }

        public bool ExistEdge(int u, int v)
        {
            return adjMat[u, v] != 0;
        }

        public int VertexCount()
        {
            return Vertices;
        }

        public int EdgeCount()
        {
            int count = 0;

            for (int i = 0; i < Vertices; i++)
            {
                for (int j = 0; j < Vertices; j++)
                {
                    if (adjMat[i, j] != 0)
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        public void Edges()
        {
            Console.WriteLine("Edges: ");
            for (int i = 0; i < Vertices; i++)
            {
                for (int j = 0; j < Vertices; j++)
                {
                    if (adjMat[i, j] != 0)
                    {
                        Console.WriteLine(i + "--" + j);
                    }
                }
            }
        }

        public int OutDegree(int v)
        {
            int count = 0;
            for (int i = 0; i < Vertices; i++)
            {
                if (adjMat[v, i] != 0)
                {
                    count++;
                }
            }
            return count;
        }

        public int InDegree(int v)
        {
            int count = 0;
            for (int i = 0; i < Vertices; i++)
            {
                if (adjMat[i, v] != 0)
                {
                    count++;
                }
            }
            return count;
        }

        public void Display()
        {
            for (int i = 0; i < Vertices; i++)
            {
                for (int j = 0; j < Vertices; j++)
                {
                    Console.Write(adjMat[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        // Breadth First Search
        public void BFS(int s)
        {
            int i = s;
            Queue<int> q = new Queue<int>();
            int[] visited = new int[Vertices];
            Console.Write(i + " ");
            visited[i] = 1;
            q.Enqueue(i);
            while( q.Count > 0 )
            {
                i = q.Dequeue();
                for(int j = 0; j<Vertices; j++)
                {
                    if(adjMat[i,j] == 1 && visited[j] == 0)
                    {
                        Console.Write(j + " ");
                        visited[j] = 1;
                        q.Enqueue(j);
                    }
                }
            }
        }

        // Depth First Search -- Recursive function


        public void DFS(int s)
        {
            if(Visited[s] == 0)
            {
                Console.Write(s + " ");
                Visited[s] = 1;
                for(int j = 0; j<Vertices; j++)
                {
                    if (adjMat[s,j] == 1 && Visited[j] == 0)
                    {
                        DFS(j);
                    }
                }
            }
        }

        public static void Main(string[] args)
        {
            // Undirected Graph
            Graphs g = new Graphs(4);
            Console.WriteLine("Graphs Adjancency Maxtrix");
            g.Display();
            Console.WriteLine("Vertices: " + g.VertexCount());
            Console.WriteLine("Edges Count: " + g.EdgeCount());
            // Unweigted Undirected
            //g.InsertEdge(0, 1, 1);
            //g.InsertEdge(0, 2, 1);
            //g.InsertEdge(1, 0, 1);
            //g.InsertEdge(1, 2, 1);
            //g.InsertEdge(2, 0, 1);
            //g.InsertEdge(2, 1, 1);
            //g.InsertEdge(2, 3, 1);
            //g.InsertEdge(3, 2, 1);

            // Weighted Undirected Graph
            //g.InsertEdge(0, 1, 26);
            //g.InsertEdge(0, 2, 16);
            //g.InsertEdge(1, 0, 26);
            //g.InsertEdge(1, 2, 12);
            //g.InsertEdge(2, 0, 16);
            //g.InsertEdge(2, 1, 12);
            //g.InsertEdge(2, 3, 8);
            //g.InsertEdge(3, 2, 8);


            // Unweighted Directed
            //g.InsertEdge(0, 1, 1);
            //g.InsertEdge(0, 2, 1);
            //g.InsertEdge(1, 2, 1);
            //g.InsertEdge(2, 3, 1);

            // Weighted Directed Graph
            //g.InsertEdge(0, 1, 26);
            //g.InsertEdge(0, 2, 16);
            //g.InsertEdge(1, 2, 12);
            //g.InsertEdge(2, 3, 8);

            // Graph for BFS
            g = new Graphs(7);
            g.InsertEdge(0, 1, 1);
            g.InsertEdge(0, 5, 1);
            g.InsertEdge(0, 6, 1);
            g.InsertEdge(1, 0, 1);
            g.InsertEdge(1, 6, 1);
            g.InsertEdge(1, 5, 1);
            g.InsertEdge(1, 2, 1);
            g.InsertEdge(6, 3, 1);
            g.InsertEdge(2, 6, 1);
            g.InsertEdge(2, 4, 1);
            g.InsertEdge(2, 3, 1);
            g.InsertEdge(3, 4, 1);
            g.InsertEdge(4, 2, 1);
            g.InsertEdge(4, 5, 1);
            g.InsertEdge(5, 2, 1);
            g.InsertEdge(5, 3, 1);

            g.Display();
            Console.WriteLine("Vertices: " + g.VertexCount());
            Console.WriteLine("Edges Count: " + g.EdgeCount());
            g.Edges();
            Console.WriteLine("Edges exsits between 1--3 : " + g.ExistEdge(1, 3));
            Console.WriteLine("Edges exsits between 1--2 : " + g.ExistEdge(1, 2));

            Console.WriteLine("Degree of Vertex 2: " + g.InDegree(2));
            Console.WriteLine("Total Degree of Vertex 2: " + (g.InDegree(2) + g.OutDegree(2)));

            g.RemoveEdge(1, 2);
            g.EdgeCount();
            g.Display();
            Console.WriteLine("Edges exsits between 1--2 : " + g.ExistEdge(1, 2));

            Console.WriteLine("Breadth First Search: ");
            g.BFS(0);

            Console.WriteLine();
            Console.WriteLine("Depth First Search: ");
            g.DFS(0); 

        }
    }
}
