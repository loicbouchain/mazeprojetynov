using System;
using System.Collections.Generic;
using System.Text;

namespace MazeProjetYNOV
{
   public class Piege : Cell
    {
        public Piege(int taille, int x, int y) : base( x, y)
        {
            Cell piege = new Cell( x, y);
            piege.setGscore(piege.getGscore()+999999999);

        }
    }
}
