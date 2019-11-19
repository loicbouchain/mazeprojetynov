using System;
using System.Collections.Generic;
using System.Text;

namespace MazeProjetYNOV
{
    public class Boue : Cell
    {
        public Boue(int taille, int x, int y) : base( x, y)
        {
            Cell boue = new Cell( x, y);
            base.setGscore(base.getGscore()+3);

        }
    }
}
