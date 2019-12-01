using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MazeProjetYNOV
{
    public class Pathfinder
    {
        private List<Cell> openList;
        private List<Cell> closedList;
        public List<Cell> list;
        private Cell endCell;
        private Cell startCell;
        private Cell result;
        private Cell currentCell;
        private List<Cell> adjacentsquare;
        private Niveau niveau;
        private int fnord = 999999, fsud = 999999, fwest = 999999, fest = 999999, gnord = 999999, gsud = 999999, gouest = 999999, gest = 999999, hnord=99999,hsud=999999,houest=99999,hest=99999;

        public Pathfinder(Niveau niveau)
        {
            closedList = new List<Cell>();
            openList = new List<Cell>();
            list = new List<Cell>();
            adjacentsquare = new List<Cell>();
        

            this.niveau = niveau;
            this.startCell= niveau.startCell;
            this.endCell = niveau.endCell;
        
            resolve();
        

        }
       
        public double StraightLineDistanceTo(Cell cell)
        {
            return Math.Sqrt(Math.Pow(cell.getX() - endCell.getX(), 2) + Math.Pow(cell.getY() - endCell.getY(), 2));
        }

        public int heuristic(Cell cell) {

            int dx = Math.Abs(cell.Center.X - endCell.Center.X);
            int dy = Math.Abs(cell.Center.Y - endCell.Center.Y) ;
            return dx + dy;
        }
     
        public int fscore(Cell cell)
        {
            int h = heuristic(cell);
            int g = cell.getGscore() + list.Count;
            return h + g;
        }
        public int distancebetweennodes(Cell currentCell, Cell neighborCell)
        {
            return Math.Abs(neighborCell.Center.X - currentCell.Center.X);
        }
       
        public Cell returnLowF(List<Cell> openList)
        {
            result = openList[0];
            int f_score = 416;
            foreach(Cell i in openList)
            {
              
                if(fscore(i)< f_score)
                {
                    result = i;
                    f_score = fscore(i);
                }
            }
            return result;
        }
        public List<Cell> reconstruct_path(Dictionary<Cell,Cell> cameFrom,Cell currentCell)
        {
            List<Cell> total_path = new List<Cell>();
            while (cameFrom.ContainsKey(currentCell))
            {
                currentCell = cameFrom[currentCell];
                total_path.Prepend(currentCell);
            
            }
            
            return total_path;
        }
        public int IsDiag(Cell from, Cell to)
        {
            if(from.getVoisinNordEst()==to || from.getVoisinNordOuest()==to || from.getVoisinSudEst()==to || from.getVoisinSudOuest() == to)
            {
                return 14;
            }
            else
            {
                return 10;
            }
        }
        public bool resolve()
        {
            startCell.setGscore(0);
            openList.Add(startCell);
            currentCell = startCell;
            while (openList.Count > 0)
            {
                foreach (Cell voisin in currentCell.getVoisins())
                {
                    if (!openList.Contains(voisin))
                        voisin.setGscore(currentCell.getGscore() + IsDiag(currentCell, voisin));
                        openList.Add(voisin);
                }
                if (!closedList.Contains(currentCell))
                {
                    closedList.Add(currentCell);
                }
                
                openList.Remove(currentCell);

                result = openList[0];

                foreach (Cell voisin in openList)
                {
                    if (voisin.getFscore() < result.getFscore())
                    {
                        result = voisin;
                    }
                }
                currentCell = result;
                if (!closedList.Contains(currentCell))
                {
                    closedList.Add(currentCell);
                }
                openList.Remove(currentCell); 
                foreach (Cell cell in openList)
                {
                    if (currentCell.getVoisins().Contains(cell))
                    {
                        if (currentCell.getGscore() + IsDiag(currentCell, cell) < cell.getGscore())
                        {
                            cell.Predecessor = currentCell;
                        }
                    }
                    Console.WriteLine(cell.getX() + " " + cell.getY() + " " + cell.getGscore() + " " + cell.getH());
                 

                }
                if (closedList.Contains(endCell))
                {
                    list = closedList;
                    break;
                }
                   
                
            }

            return true;
            /*openList.Add(startCell);
            Dictionary<Cell, Cell> cameFrom = new Dictionary<Cell, Cell>();
            Dictionary<Cell, int> gScore = new Dictionary<Cell, int>();
            Dictionary<Cell, int> fScore = new Dictionary<Cell, int>();
            gScore[startCell] = 0;
            fScore[startCell] = heuristic(startCell);
            list.Add(startCell);
            
            while (openList.Count > 0)
            {
                currentCell = returnLowF(openList);
                if (currentCell == endCell)
                {
                  
                    reconstruct_path(cameFrom, currentCell);
                }
                openList.Remove(currentCell);
                foreach(Cell neighbor in currentCell.getVoisins())
                {
                    if (!gScore.ContainsKey(neighbor) || !fScore.ContainsKey(neighbor))
                    {
                        gScore.Add(neighbor, neighbor.getGscore());
                        fScore.Add(neighbor, fscore(neighbor));
                    }
                   // cameFrom.Add(neighbor, neighbor);
                    int tentative_gscore = gScore[currentCell] + distancebetweennodes(currentCell, neighbor);
                    if(tentative_gscore < gScore[neighbor])
                    {
                        cameFrom[neighbor] = currentCell;
                        gScore[neighbor] = tentative_gscore;
                        fScore[neighbor] = gScore[neighbor] + heuristic(neighbor);
                        if (!openList.Contains(neighbor))
                        {
                            openList.Add(neighbor);
                            list.Add(neighbor);
                        }
                    }
                }
            }
           
            */
            /*
            openList.Add(startCell);
            do
            {
                currentCell = moinsloin(openList);
                closedList.Add(currentCell);
                openList.Remove(currentCell);

                if (closedList.Contains(endCell))
                {
                    break;
                }
                adjacentsquare = currentCell.getVoisins();

                foreach(Cell cell in adjacentsquare)
                {

                    Console.WriteLine("           "+cell.getX()+" "+cell.getY()+" "+heuristic(cell));
                    if (closedList.Contains(cell))
                    {
                        break;

                    }
                    if (openList.Contains(cell) == false)
                    {

                            if (cell != null)
                                openList.Add(cell);

                    }
                    else
                    {
                      if(gscore(cell) < gscore(currentCell))
                        {
                            continue;
                        }
                        else
                        {
                            openList.Add(currentCell);
                        }

                    }


        }


            } while (openList.Count != 0);*/
            /* openList.Add(startCell);
             do
             {
                 Cell q = moinsloin(openList);
                 openList.Remove(q);
                 adjacentsquare = q.getVoisins();
                 foreach(Cell voisin in adjacentsquare)
                 {
                     if(voisin == endCell)
                     {
                         break;
                     }
                     else
                     {
                         voisin.setGscore(q.getGscore()+1);
                         voisin.setH(heuristic(voisin));
                         voisin.setFscore(voisin.getGscore() + voisin.getH());
                     }
                    foreach(Cell v in openList)
                     {
                         if(fscore(voisin) > fscore(v))
                         {
                             continue;
                         }
                     }
                     foreach (Cell v in closedList)
                     {
                         if (fscore(voisin) > fscore(v))
                         {
                             continue;
                         }

                     }

                     openList.Add(voisin);

                 }
                 closedList.Add(q);

             } while (openList.Count > 0);*/

        }
        

    }
}
