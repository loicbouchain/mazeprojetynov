using MazeProjetYNOV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mazeprojetynov
{
    class AStarSearch
    {
        public Dictionary<Cell, Cell> cameFrom = new Dictionary<Cell, Cell>();
        public Dictionary<Cell, double> costSoFar = new Dictionary<Cell, double>();
        public double Heuristic(Cell a, Cell b)
        {
            return Math.Abs(a.getX() - b.getX()) + Math.Abs(a.getY() - b.getY());
        }
        public int IsDiag(Cell from, Cell to)
        {
            if (from.getVoisinNordEst() == to || from.getVoisinNordOuest() == to || from.getVoisinSudEst() == to || from.getVoisinSudOuest() == to)
            {
                return 14;
            }
            else
            {
                return 10;
            }
        }

      


        public class PriorityQueue<T>
        {
            // I'm using an unsorted array for this example, but ideally this
            // would be a binary heap. There's an open issue for adding a binary
            // heap to the standard C# library: https://github.com/dotnet/corefx/issues/574
            //
            // Until then, find a binary heap class:
            // * https://github.com/BlueRaja/High-Speed-Priority-Queue-for-C-Sharp
            // * http://visualstudiomagazine.com/articles/2012/11/01/priority-queues-with-c.aspx
            // * http://xfleury.github.io/graphsearch.html
            // * http://stackoverflow.com/questions/102398/priority-queue-in-net

            private List<Tuple<T, double>> elements = new List<Tuple<T, double>>();

            public int Count
            {
                get { return elements.Count; }
            }

            public void Enqueue(T item, double priority)
            {
                elements.Add(Tuple.Create(item, priority));
            }

            public T Dequeue()
            {
                int bestIndex = 0;

                for (int i = 0; i < elements.Count; i++)
                {
                    if (elements[i].Item2 < elements[bestIndex].Item2)
                    {
     
                        bestIndex = i;
                    }
                }

                T bestItem = elements[bestIndex].Item1;
                elements.RemoveAt(bestIndex);
            
                return bestItem;
            }
        }

        public AStarSearch(Cell[,] graph, Cell start, Cell goal)
        {
            var frontier = new PriorityQueue<Cell>();
            frontier.Enqueue(start, 0);

            cameFrom[start] = start;
            costSoFar[start] = 0;

            while (frontier.Count > 0)
            {
                var current = frontier.Dequeue();


                if (current.Equals(goal) )//|| current.getPiege()) 
                {
                    break;
                }

                foreach (var next in current.getVoisins())
                {
                    int ralenti = 0;
                    if (next.getBoue())
                    {
                        ralenti = 150;
                    }
                    if (next.getPiege())
                    {
                        ralenti = 999999;
                    }
                    double newCost = costSoFar[current] + IsDiag(current,next)+ralenti;
                    if (!costSoFar.ContainsKey(next)
                        || newCost < costSoFar[next])
                    {
                        costSoFar[next] = newCost;
                        double priority = newCost + Heuristic(next, goal);
                        frontier.Enqueue(next, priority);
                        cameFrom[next] = current;
                    }
                }
            }
        }
    }
}
