using System;
using System.Collections.Generic;
using System.Text;

namespace MazeProjetYNOV
{
    public class Fin : Cell
    {
        public Fin(int taille, int x, int y) : base(taille, x, y)
        {
            Cell fin = new Cell(taille, x, y);
            fin.setCellEnd(true);

        }

    }
}
