using System;
using System.Collections.Generic;
using System.Text;

namespace MazeProjetYNOV
{
    public class Depart : Cell
    {

        public Depart( int x, int y) : base( x, y)
        {
            Cell depart = new Cell( x, y);
            base.setCellDep(true);
         

        }
    }

}
