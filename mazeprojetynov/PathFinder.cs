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
        private int fnord =999999 , fsud= 999999, fwest= 999999, fest= 999999,gnord =999999 , gsud = 999999, gouest = 999999, gest = 999999;

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
            foreach(Cell cell in list)
            {
                Console.WriteLine(cell.getY());
            }
        }
       
        public double StraightLineDistanceTo(Cell cell)
        {
            return Math.Sqrt(Math.Pow(cell.getX() - endCell.getX(), 2) + Math.Pow(cell.getY() - endCell.getY(), 2));
        }

        public int heuristic(Cell cell) {

            int dx = Math.Abs(cell.getX() - endCell.getX());
            int dy = Math.Abs(cell.getY() - endCell.getY()) ;
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
            int g = gscore(cell);
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
                    if (closedList.Contains(cell))
                    {
                        continue;
                    }
                    if (openList.Contains(cell) == false)
                    {
                        openList.Add(cell);
                    }
                    else
                    {

                    }
                }


            } while (openList.Count != 0);
            
        }
         public Cell moinsloin(List<Cell> openList)
        {
            foreach( Cell i in openList) { 
                if (i.getVoisinNord() != null && closedList.Contains(i)==false)
                {
                    fnord = fscore(i.getVoisinNord());
                    gnord = gscore(i.getVoisinNord());
                }
                if (i.getVoisinSud() != null && closedList.Contains(i) == false)
                {
                    fsud = fscore(i.getVoisinSud());
                    gsud = gscore(i.getVoisinSud());
                }
                if (i.getVoisinEst() != null && closedList.Contains(i) == false)
                {
                    fest = fscore(i.getVoisinEst());
                    gest = gscore(i.getVoisinEst());
                }
                if (i.getVoisinOuest() != null && closedList.Contains(i) == false)
                {
                    fwest = fscore(i.getVoisinOuest());
                    gouest = gscore(i.getVoisinOuest());
                }
                if (i.getVoisinOuest() != null && closedList.Contains(i) == false)
                {
                    if (fscore(i.getVoisinOuest()) == Math.Min(fnord, Math.Min(fsud, Math.Min(fwest, fest))))
                        result = i.getVoisinOuest();
                }
                if (i.getVoisinEst() != null && closedList.Contains(i) == false)
                {
                    if (fscore(i.getVoisinEst()) == Math.Min(fnord, Math.Min(fsud, Math.Min(fwest, fest))))
                        result = i.getVoisinEst();
                }
                if (i.getVoisinNord() != null && closedList.Contains(i) == false)
                {
                    if (fscore(i.getVoisinNord()) == Math.Min(fnord, Math.Min(fsud, Math.Min(fwest, fest))))
                        result = i.getVoisinNord();
                }
                if (i.getVoisinSud() != null && closedList.Contains(i) == false)
                {
                    if (fscore(i.getVoisinSud()) == Math.Min(fnord, Math.Min(fsud, Math.Min(fwest, fest))))
                        result = i.getVoisinSud();
                }

            }
            list.Add(result);
            return result;

        }

    }
}
