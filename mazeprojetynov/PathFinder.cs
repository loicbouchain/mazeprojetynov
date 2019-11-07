using System;
using System.Collections.Generic;
using System.Text;

namespace MazeProjetYNOV
{
    public class Pathfinder
    {
        private List<Cell> openList;
        private List<Cell> closedList;
        private Cell endCell;
        private Cell startCell;
        private Niveau niveau;


        public Pathfinder(Niveau niveau)
        {
            this.niveau = niveau;
        }
        public void findStartandEndCell()
        {
            foreach (Cell cell in niveau.getCellList())
            {
            }
        }
    }
}
