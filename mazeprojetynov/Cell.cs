using System;
using System.Collections.Generic;
using System.Drawing;
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
        public bool celldep = false;
        private bool cellend = false;
        public Cell Predecessor = null;
        public const int North = 0;
        public const int South = North + 1;
        public const int East = South + 1;
        public const int West = East + 1;
        public Rectangle Bounds;
        public List<Cell> voisins;
        public Cell voisinNord;
        public Cell voisinSud;
        public Cell voisinOuest;
        public Cell voisinEst;
        // The node's neighbors in order North, South, East, West.
        public Cell[] Neighbors = new Cell[4];

        public Cell(int x,int y)
        {
            voisins = new List<Cell>();
            taille_cell  = 14;
            this.x = x;
            this.y = y;
            traversable = true;
            this.gscore = 0;
            Bounds = new Rectangle(x, y, 14, 14);

        }
        public Point Center
        {
            get
            {
                int x = Bounds.Left + Bounds.Width / 2;
                int y = Bounds.Top + Bounds.Height / 2;
                return new Point(x, y);
            }
        }
    

        public void DrawWalls(Graphics gr, Pen pen)
        {
            for (int side = 0; side < 4; side++)
            {
                if ((Neighbors[side] == null) ||
                    ((Neighbors[side].Predecessor != this) &&
                     (Neighbors[side] != this.Predecessor)))
                {
                    DrawWall(gr, pen, side, 0);
                }
            }
        }
        public void DrawCenter(Graphics gr, Brush brush)
        {
            int cx = Bounds.Left + Bounds.Width / 2;
            int cy = Bounds.Top + Bounds.Height / 2;
            gr.FillEllipse(brush, cx - 2, cy - 2, 4, 4);
        }

        public void DrawBoundingBox(Graphics gr, Pen pen)
        {
            gr.DrawRectangle(pen,
                Bounds.Left + 1, Bounds.Y + 1,
                Bounds.Width - 2, Bounds.Height - 2);
        }
        public void DrawPredecessorLink(Graphics gr, Pen pen)
        {
            if ((Predecessor != null) && (Predecessor != this))
                gr.DrawLine(pen, Center, Predecessor.Center);
        }
        private void DrawWall(Graphics gr, Pen pen, int side, int offset)
        {
            switch (side)
            {
                case North:
                    gr.DrawLine(pen,
                        Bounds.Left + offset, Bounds.Top + offset,
                        Bounds.Right - offset, Bounds.Top + offset);
                    break;
                case South:
                    gr.DrawLine(pen,
                        Bounds.Left + offset, Bounds.Bottom - offset,
                        Bounds.Right - offset, Bounds.Bottom - offset);
                    break;
                case East:
                    gr.DrawLine(pen,
                        Bounds.Right - offset, Bounds.Top + offset,
                        Bounds.Right - offset, Bounds.Bottom - offset);
                    break;
                case West:
                    gr.DrawLine(pen,
                        Bounds.Left + offset, Bounds.Top + offset,
                        Bounds.Left + offset, Bounds.Bottom - offset);
                    break;
            }
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

        public Cell getVoisinNord()
        {
            return voisinNord;
        }
        public Cell getVoisinSud()
        {
            return voisinSud;
        }
        public Cell getVoisinOuest()
        {
            return voisinOuest;
        }
        public Cell getVoisinEst()
        {
            return voisinEst;
        }
        public void setVoisinNord (Cell cell)
        {
            this.voisinNord = cell;
        }
        public void setVoisiSud(Cell cell)
        {
            this.voisinSud = cell;
        }
        public void setVoisinOuest(Cell cell)
        {
            this.voisinOuest = cell;
        }
        public void setVoisinEst(Cell cell)
        {
            this.voisinEst = cell;
        }
        public List<Cell> getVoisins()
        {
            if (this.getVoisinNord() != null)
                voisins.Add(this.getVoisinNord());

            if (this.getVoisinSud() != null)
                voisins.Add(this.getVoisinSud());
            if (this.getVoisinEst() != null)
                voisins.Add(this.getVoisinEst());
            if (this.getVoisinOuest() != null)
                voisins.Add(this.getVoisinOuest());

            return voisins;
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
