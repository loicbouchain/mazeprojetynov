using System;
using System.Collections.Generic;
using System.Text;

namespace MazeProjetYNOV
{
    public class Niveau
    {
        private string nom;
        private string createur;
        private DateTime datecreation;
        private DateTime datemodif;
        private int nbcase = 0;
        private int nbboue = 0;
        private int nbpiege = 0;
        private int xcol;
        private int ycol;
        private List<Cell> cellList;
        private Cell startCell;
        private Cell endCell;
        
        public Niveau(int xcol, int ycol, string nom, string createur, DateTime datecreation)
        {
            this.xcol = xcol;
            this.ycol = ycol;
            this.nom = nom;
            this.createur = createur;
            this.datecreation = datecreation;
            this.datemodif = datecreation;
            this.nbcase = xcol * ycol;

          
        }
        public string getNom()
        {
            return this.nom;
        }
        public void setNom(string nom)
        {
            this.nom = nom;
        }
        public string getCreateur()
        {
            return this.createur;
        }
        public void setCreateur(string createur)
        {
            this.createur = createur;
        }

        public DateTime getDatecreation()
        {
            return this.datecreation;
        }
        public void setDateCreation(DateTime datecreation)
        {
            this.datecreation = datecreation;
        }
        public DateTime getDatemodif()
        {
            return this.datemodif;
        }
        public void setDateModif(DateTime datemodif)
        {
            this.datemodif = datemodif;
        }
        public int getNbcase()
        {
            return this.nbcase;
        }
        public void setNbcase(int nbcase)
        {
            this.nbcase = nbcase;
        }
        public int getNbBoue()
        {
            return this.nbboue;
        }
        public void setNbBoue(int nbboue)
        {
            this.nbboue = nbboue;
        }
        public int getNbPiege()
        {
            return this.nbpiege;
        }
        public void setNbPiege(int nbpiege)
        {
            this.nbpiege = nbpiege;
        }
        public int getXcol()
        {
            return this.xcol;
        }
        public void stXcol(int xcol)
        {
            this.xcol = xcol;
        }
        public int getYcol()
        {
            return this.ycol;
        }
        public void setYcol(int ycol)
        {
            this.ycol = ycol;
        }
        public List<Cell> getCellList()
        {
            return this.cellList;
        }
        public Cell getEndCell()
        {
            return this.endCell;
        }
        public Cell getStartCell()
        {
            return this.startCell;
        }

    }
}
