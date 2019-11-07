using System;
using System.Collections.Generic;
using System.Text;

namespace MazeProjetYNOV
{
    public class Test
    {
        private string reftest;
        private Niveau niveau;
        private DateTime datepassage;
        private string res;


        public Test(string reftest, Niveau niveau, DateTime datepassage, string res)
        {
            this.reftest = reftest;
            this.niveau = niveau;
            this.datepassage = datepassage;
            this.res = res;
        }

        public string Reftest { get => reftest; set => reftest = value; }
        public Niveau Niveau { get => niveau; set => niveau = value; }
        public DateTime Datepassage { get => datepassage; set => datepassage = value; }
        public string Res { get => res; set => res = value; }
    }
}
