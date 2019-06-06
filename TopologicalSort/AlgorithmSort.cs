using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TopologicalSort
{
    class AlgorithmSort
    {
        static int[] color;
        static int[,] graph;
        static List<int> order;
        public static bool cycle = false;
        static int ver;
        public static Stopwatch time;
        public static  int a = 0;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></Глубина>
        static void dfs(int x)
        {
            color[x] = 1;
            for (int y = 1; y <= ver; y++)
            {
                if (graph[x, y] == 1)
                {
                    if (color[y] == 1)
                        cycle = true;
                    else if (color[y] == 0)
                        dfs(y);
                }
            }
            color[x] = 2;
            order.Add(x);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"></Вершины>
        /// <param name="reb"></Ребра>
        /// <param name="args"></Последовательность>
        /// <returns></returns>
        public static string Sort(int n, int reb, string[] args)
        {
            string rez = "Graph has a cicle!";
            ver = n;
            graph = new int[ver + 1, ver + 1];
            color = new int[ver + 1];
            order = new List<int>();
            
            for (int i = 0; i < args.Length; i+=2)
            {
                int x = int.Parse(args[i]);
                int y = int.Parse(args[i + 1]);
                graph[x, y] = 1;
            }
            time = new Stopwatch();
            time.Start();
            for (int i = 1; i <= ver; i++)
                if (color[i] == 0)
                    dfs(i);
            time.Stop();
            a = Convert.ToInt32(time.Elapsed.Ticks);
            if (cycle != true)
            {
                rez = null;
                for (int i = order.Count - 1; i >= 0; i--)
                    rez += order[i] + " ";
            }

            return rez;
        }
    }
}
