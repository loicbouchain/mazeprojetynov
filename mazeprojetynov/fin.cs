using System;
using System.Collections.Generic;
using System.Text;

namespace MazeProjetYNOV
{
    public class Fin : Cell
    {
        public Fin( int x, int y) : base( x, y)
        {
            Cell fin = new Cell( x, y);
            base.setCellEnd(true);

        }

    }
}
