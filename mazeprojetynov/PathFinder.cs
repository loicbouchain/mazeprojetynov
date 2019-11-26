using System;
using System.Collections.Generic;
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
            Console.WriteLine("dezz");
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
        public int gscore(Cell cell)
        {

            int dx = Math.Abs(cell.getX() - startCell.getX());
            int dy = Math.Abs(cell.getY() - startCell.getY());
            return dx + dy;
        }
        
        public int fscore(Cell cell)
        {
            int h = heuristic(cell);
            int g = cell.getGscore();
            return h + g;
        }
       
        public void resolve()
        {
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


            } while (openList.Count != 0);
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
         public Cell moinsloin(List<Cell> openList)
        {
            foreach( Cell i in openList) {
                
                if (i != null)
                {
                        if (i.getVoisinNord() != null && closedList.Contains(i) == false)
                        {
                            fnord = fscore(i.getVoisinNord());
                            gnord =i.getGscore()+i.getVoisinNord().getGscore();
                            hnord = heuristic(i.getVoisinNord());

                        }
                        if (i.getVoisinSud() != null && closedList.Contains(i) == false)
                        {
                            fsud = fscore(i.getVoisinSud());
                            gsud = gscore(i.getVoisinSud());
                            hsud = heuristic(i.getVoisinSud());
                        }
                        if (i.getVoisinEst() != null && closedList.Contains(i) == false)
                        {
                            fest = fscore(i.getVoisinEst());
                            gest = gscore(i.getVoisinEst());
                            hest = heuristic(i.getVoisinEst());
                        }
                        if (i.getVoisinOuest() != null && closedList.Contains(i) == false)
                        {
                            fwest = fscore(i.getVoisinOuest());
                            gouest = gscore(i.getVoisinOuest());
                            houest = heuristic(i.getVoisinOuest());
                        }
                        if (i.getVoisinEst() != null && closedList.Contains(i) == false)
                        {
                            if (heuristic(i.getVoisinEst()) == Math.Min(hnord, Math.Min(hsud, Math.Min(houest, hest))))
                                result = i.getVoisinEst();
                            // Console.WriteLine("droite  " + heuristic(result));
                        }
                        if (i.getVoisinOuest() != null && closedList.Contains(i) == false)
                        {
                            if (fscore(i.getVoisinOuest()) == Math.Min(hnord, Math.Min(hsud, Math.Min(houest, hest))))
                                result = i.getVoisinOuest();
                            // Console.WriteLine("gauche  "+ heuristic(result));

                        }

                        if (i.getVoisinNord() != null && closedList.Contains(i) == false)
                        {
                            if (fscore(i.getVoisinNord()) == Math.Min(hnord, Math.Min(hsud, Math.Min(houest, hest))))
                                result = i.getVoisinNord();
                            //  Console.WriteLine("haut  " + heuristic(result));
                        }
                        if (i.getVoisinSud() != null && closedList.Contains(i) == false)
                        {
                            if (fscore(i.getVoisinSud()) == Math.Min(hnord, Math.Min(hsud, Math.Min(houest, hest))))
                                result = i.getVoisinSud();
                            //  Console.WriteLine("bas  " + heuristic(result));
                        }
                        
                    
                }



            }
            Console.WriteLine(heuristic(result) + " " + result.getX() + " " + result.getY());
            list.Add(result);
            return result;

        }

    }
}
