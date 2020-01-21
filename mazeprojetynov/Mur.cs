using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace MazeProjetYNOV
{
    public class Mur : Cell
    {

        public Mur(int taille, int x, int y):base( x, y)
        {
            Cell mur = new Cell( x, y);
            base.setTraversable(false);

        }
    }
   
}
