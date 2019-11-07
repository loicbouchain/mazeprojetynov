using System;
using System.Collections.Generic;
using System.Text;

namespace MazeProjetYNOV
{
    public class Boue : Cell
    {
        public Boue(int taille, int x, int y) : base(taille, x, y)
        {
            Cell boue = new Cell(taille, x, y);
            boue.setGscore(boue.getGscore()+3);

        }
    }
}
