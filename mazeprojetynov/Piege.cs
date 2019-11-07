using System;
using System.Collections.Generic;
using System.Text;

namespace MazeProjetYNOV
{
   public class Piege : Cell
    {
        public Piege(int taille, int x, int y) : base(taille, x, y)
        {
            Cell piege = new Cell(taille, x, y);
            piege.setGscore(piege.getGscore()+999999999);

        }
    }
}
