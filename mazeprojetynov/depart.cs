using System;
using System.Collections.Generic;
using System.Text;

namespace MazeProjetYNOV
{
    public class Depart : Cell
    {

        public Depart(int taille, int x, int y) : base(taille, x, y)
        {
            Cell depart = new Cell(taille, x, y);
            depart.setCellDep(true) ;

        }
    }

}
