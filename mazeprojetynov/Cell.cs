using System;
using System.Collections.Generic;
using System.Text;

namespace MazeProjetYNOV
{
   public class Cell 
    {
        private int taille_cell;
        private int x;
        private int y;
        private bool traversable;
        public int gscore;
        private bool celldep = false;
        private bool cellend = false;

        public Cell(int taille,int x,int y)
        {
            taille = 14;
            this.x = x;
            this.y = y;
            traversable = true;
            this.gscore = 0;

        }
        public int getTaille()
        {
            return this.taille_cell;
        }
        public void setTaille(int taille)
        {
            this.taille_cell = taille;
        }
        public int getGscore()
        {
            return this.gscore;
        }
        public void setGscore(int gscore)
        {
            this.gscore = gscore;
        }


        public int getX()
        {
            return this.x;
        }
        public void setX(int x)
        {
            this.x = x;
        }
        public int getY()
        {
            return this.y;
        }
        public void setY(int y)
        {
            this.y = y;
        }

        public bool getTraversable()
        {
            return this.traversable;
        }
        public void setTraversable(bool traversable)
        {
            this.traversable = traversable;
        }
        public bool getCellDep()
        {
            return this.celldep;
        }
        public void setCellDep(bool celldep)
        {
            this.celldep = celldep;
        }

        public bool getCellEnd()
        {
            return this.cellend;
        }
        public void setCellEnd(bool cellend)
        {
            this.cellend = cellend;
        }
    }
}
