using MazeProjetYNOV;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity.Migrations;
using System.Threading;

namespace mazeprojetynov
{
    public partial class frmEditeur : MetroFramework.Forms.MetroForm
    {
        private int CellWid;
        private int CellHgt;
        private int Xmin;
        private int Ymin;
        private Graphics graphicsObj;
        public Bitmap bm;
        private Cell endCell;
        private Cell startCell;
        private List<Cell> cellList;
        private int frmgscore = 0;
        public Cell[,] nodes;
        public int iduser;
        public Cell[,] all;
        public map emp;
        public user userMap;
        ynovprojetEntities testcontext = new ynovprojetEntities();
        List<Cell> list = new List<Cell>();
        List<Cell> arraymur = new List<Cell>();
        List<Cell> arraydepart = new List<Cell>();
        List<Cell> arrayfin = new List<Cell>();
        List<Cell> arrayPiege = new List<Cell>();
        List<Cell> arrayBoue = new List<Cell>();
        public string cellclic = "";
        public static string resultat = "Passé";
        Image depart = Properties.Resources.depart1;
        Image fin = Properties.Resources.iconfinder_exit_enter_leave_out_door_2931188;
        Image piege = Properties.Resources.piege;
        Image boue = Properties.Resources.boue;
        Image herbe = Properties.Resources.herbe;
        Image mur = Properties.Resources.mur;
        Image chemin = Properties.Resources.chemin;
        public int idmap;
        public frmEditeur()
        {
            InitializeComponent();
            txtBxNom.Text = "Sans Titre";
        }
        private void loadMap()
        {
            //taille du labyrinthe
            int wid = 10;
            int hgt = 15;
            CellWid = picMaze.ClientSize.Width / (wid + 2);
            CellHgt = picMaze.ClientSize.Height / (hgt + 2);
            if (CellWid > CellHgt) CellWid = CellHgt;
            else CellHgt = CellWid;
            Xmin = (picMaze.ClientSize.Width - wid * CellWid) / 2;
            Ymin = (picMaze.ClientSize.Height - hgt * CellHgt) / 2;
            arrayBoue.Clear();
            arraydepart.Clear();
            arrayfin.Clear();
            arrayPiege.Clear();
            arraymur.Clear();
            nodes = new Cell[hgt, wid];
            casemap casemap = new casemap();
            var products = testcontext.casemap.Where(p => p.id_map == idmap);
            map emp = new map();
            var map = testcontext.map.Where(p => p.id == idmap).First<map>();
            setEmp(map);
            txtBxNom.Text = map.nom_map;
            int cal = 0;
            int cal2 = 0;
            foreach (var produit in products)
            {

                Cell cell = new Cell(produit.x, produit.y);
                cell.setId(produit.id);
                cell.setTraversable(produit.mur);
                cell.setBoue(produit.boue);
                cell.setCellDep(produit.depart);
                cell.setCellEnd(produit.fin);
                cell.setPiege(produit.piege);

                if (produit.piege == true)
                {
                    arrayPiege.Add(cell);
                }
                if (produit.boue == true)
                {
                    arrayBoue.Add(cell);
                }
                if (produit.depart == true)
                {
                    startCell = cell;
                    arraydepart.Add(cell);
                }
                if (produit.fin == true)
                {
                    endCell = cell;
                    arrayfin.Add(cell);
                }
                if (produit.mur == false)
                {
                    arraymur.Add(cell);
                }
                if (cal == wid - 1)
                {
                    cal = 0;
                    cal2 = cal2 + 1;
                }
                else
                {
                    cal = cal + 1;
                }

                if (cal2 == hgt)
                {
                    cal2 = 0;
                }
                nodes[cal2, cal] = cell;

            }

            setCells(nodes);


            for (int r = 0; r < hgt; r++)
            {
                for (int c = 0; c < wid; c++)
                {

                    if (r > 0)
                    {


                        if (nodes[r - 1, c].getTraversable())
                        {
                            nodes[r, c].Neighbors[Cell.North] = nodes[r - 1, c];
                            nodes[r, c].setVoisinNord(nodes[r - 1, c]);
                        }
                        else
                        {
                            nodes[r, c].Neighbors[Cell.North] = null;
                            nodes[r, c].setVoisinNord(null);
                        }




                    }
                    if (r < hgt - 1)
                    {




                        if (nodes[r + 1, c].getTraversable())
                        {
                            nodes[r, c].Neighbors[Cell.South] = nodes[r + 1, c];
                            nodes[r, c].setVoisiSud(nodes[r + 1, c]);
                        }
                        else
                        {
                            nodes[r, c].Neighbors[Cell.South] = null;
                            nodes[r, c].setVoisiSud(null);
                        }


                        if (c < wid - 1)
                        {
                            if (nodes[r + 1, c + 1].getTraversable())
                            {

                                nodes[r, c].setVoisinSudEst(nodes[r + 1, c + 1]);
                            }
                            else
                            {

                                nodes[r, c].setVoisinSudEst(null);
                            }
                            if (r > 0)
                            {

                                if (nodes[r - 1, c + 1].getTraversable())
                                {

                                    nodes[r, c].setVoisinNordEst(nodes[r - 1, c + 1]);
                                }
                                else
                                {

                                    nodes[r, c].setVoisinNordEst(null);
                                }
                            }


                        }
                        if (c > 0)
                        {

                            if (nodes[r + 1, c - 1].getTraversable())
                            {
                                nodes[r, c].setVoisinSudOuest(nodes[r + 1, c - 1]);
                            }
                            else
                            {
                                nodes[r, c].setVoisinSudOuest(null);
                            }
                            if (r > 0)
                            {
                                if (nodes[r - 1, c - 1].getTraversable())
                                {

                                    nodes[r, c].setVoisinNordOuest(nodes[r - 1, c - 1]);
                                }
                                else
                                {

                                    nodes[r, c].setVoisinNordOuest(null);
                                }
                            }
                        }

                    }
                    if (c > 0)
                    {




                        if (nodes[r, c - 1].getTraversable())
                        {
                            nodes[r, c].Neighbors[Cell.West] = nodes[r, c - 1];
                            nodes[r, c].setVoisinOuest(nodes[r, c - 1]);
                        }
                        else
                        {
                            nodes[r, c].Neighbors[Cell.West] = null;
                            nodes[r, c].setVoisinOuest(null);

                        }

                    }
                    if (c < wid - 1)
                    {

                        if (nodes[r, c + 1].getTraversable())
                        {
                            nodes[r, c].Neighbors[Cell.East] = nodes[r, c + 1];
                            nodes[r, c].setVoisinEst(nodes[r, c + 1]);
                        }
                        else
                        {
                            nodes[r, c].Neighbors[Cell.East] = null;
                            nodes[r, c].setVoisinEst(null);

                        }

                    }


                }
            }
            DisplayMaze(nodes);
        }
     
        private void CreateMap()
        {
            
            list.Clear();
            arrayBoue.Clear();
            arrayPiege.Clear();
            arraymur.Clear();
            arraydepart.Clear();
            arrayfin.Clear();
            emp = new map
            {
                nom_map = "Sans Titre",
                createurId = frmLogin.iduser,
                createurName = frmLogin.username
         

            };
            txtBxNom.Text = emp.nom_map;
            int wid = 15;
            int hgt = 10;
            makemap(wid, hgt);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var t = new Thread(() => Application.Run(new frmMenu()));
            t.Start();
            this.Close();

        }
        public void setEmp(map map)
        {
            emp = map;
        }
        public map getEmp()
        {
            return emp;
        }
        public void setUtilisateur(user user)
        {
            userMap = user;
        }
        public user getUtilisateur()
        {
            return userMap;
        }
        private void btnvide_Click(object sender, EventArgs e)
        {
            cellclic = "rien";

        }

        private void btnpiege_Click(object sender, EventArgs e)
        {
            cellclic = "piège";
        }

        private void btnmur_Click(object sender, EventArgs e)
        {
            cellclic = "mur";
        }

        private void btnfin_Click(object sender, EventArgs e)
        {
            cellclic = "fin";
        }

        private void btndepart_Click(object sender, EventArgs e)
        {
            cellclic = "depart";
        }
        private void btn_boue_Click(object sender, EventArgs e)
        {
            cellclic = "boue";
        }
        private void btn_save_Click(object sender, EventArgs e) //enregistrement de la carte dans la base de données
        {
            
            int wid = 15;
            int hgt = 10;

            CellWid = picMaze.ClientSize.Width / (wid + 2);
            CellHgt = picMaze.ClientSize.Height / (hgt + 2);
            if (CellWid > CellHgt) CellWid = CellHgt;
            else CellHgt = CellWid;
            Xmin = (picMaze.ClientSize.Width - wid * CellWid) / 2;
            Ymin = (picMaze.ClientSize.Height - hgt * CellHgt) / 2;
            makemap(15, 10);
            emp = getEmp();
            emp.nom_map = txtBxNom.Text;
            if (txtBxNom.Text == "")
            {
                emp.nom_map = "Sans Titre";
            }
            var cells = testcontext.casemap.Where(p => p.id_map == emp.id);
            foreach (var cellule in cells)
            {
                testcontext.casemap.Remove(cellule);
            }
            foreach (Cell cell in getCells())
            {
             
                casemap casemap = new casemap
                {

                    id_map = emp.id,
                    mur = cell.getTraversable(),
                    depart = cell.getCellDep(),
                    fin = cell.getCellEnd(),
                    boue = cell.getBoue(),
                    piege = cell.getPiege(),
                    map = emp,
                    x = cell.getX(),
                    y = cell.getY()
                };


                testcontext.casemap.Add(casemap);
            }
            emp.nom_map = txtBxNom.Text;
            testcontext.SaveChanges();

        }
        private void btnTester_Click(object sender, EventArgs e) // trouve le chemin le plus cours
        {
            list.Clear();
            //   DisplayMaze(getCells()); // permet l'affichage dans un picturebox
            makemap(15, 10);
            if (startCell != null && endCell != null)
            {
                var astar = new AStarSearch(getCells(), startCell, endCell); // Trouve le chemin le plus court

                Cell current_cell = endCell;
                while (current_cell != startCell)
                {
                    list.Add(current_cell);//contient la liste définie par astar
                    if (astar.cameFrom.ContainsKey(current_cell))
                    {
                        current_cell = astar.cameFrom[current_cell];
                        if (current_cell.getPiege())
                        {
                            resultat = "piégé";
                            list.Clear();
                            current_cell = astar.cameFrom[current_cell];
                        }
                    }
                    else
                    {
                        resultat = "non passé";
                        break;
                    }
                }

                using (Graphics gr = Graphics.FromImage(bm))
                {
                    gr.SmoothingMode = SmoothingMode.AntiAlias;

                    int u = 0;
                    foreach (Cell i in list) //affiche le chemin le plus court
                    {
                        u = u + 1;
                        i.FillRectangleWithImage(gr, chemin);
                    }
                    SolidBrush brushend = new SolidBrush(Color.Red);
                    endCell.FillRectangle(gr, brushend);
                    endCell.FillRectangleWithImage(gr, fin);
                }
                picMaze.Image = bm;

                //bm.Save("ez.bmp");

                Bitmap image1 = bm;
                int x, y;
                int count = 0;

                for (x = 0; x < image1.Width; x++)
                {
                    for (y = 0; y < image1.Height; y++)
                    {


                        Color pixelColor = image1.GetPixel(x, y);

                        //    Console.WriteLine(x + " " + y + "   " +pixelColor);
                        if (pixelColor.ToArgb() == Color.Red.ToArgb())
                        {
                            count = count + 1;
                            // Console.WriteLine(x + " " + y);
                        }

                    }
                }
                // Console.WriteLine(" C L A F IN " + endCell.getX() + " " + endCell.getY());
                image1.Save("ez_1.bmp");
                emp = getEmp();

                test test = new test
                {
                    id_map = emp.id,
                    resultat = resultat,
                    date = DateTime.Now
                };
                testcontext.test.Add(test);
                testcontext.SaveChanges();
                frmResultat frmResultat = new frmResultat();
                frmResultat.Show();



                /*   arrayBoue.Clear();
                   arraydepart.Clear();
                   arrayfin.Clear();
                   arraymur.Clear();
                   arrayPiege.Clear();
                   startCell = null;
                   endCell = null;*/


            }
        }



        // Display the maze in the picMaze PictureBox.
        public void setCells(Cell[,] cells)
        {

            all = cells;

        }

        public Cell[,] getCells()
        {
            return all;

        }
        private void DisplayMaze(Cell[,] nodes) // Affiche la carte
        {

            int hgt = nodes.GetUpperBound(0) + 1;
            int wid = nodes.GetUpperBound(1) + 1;
            bm = new Bitmap(
               picMaze.ClientSize.Width,
               picMaze.ClientSize.Height);

            using (Graphics gr = Graphics.FromImage(bm))
            {
                gr.SmoothingMode = SmoothingMode.AntiAlias;
                for (int r = 0; r < hgt; r++)
                {
                    for (int c = 0; c < wid; c++)
                    {
                        nodes[r, c].FillRectangleWithImage(gr, herbe);

                        if (nodes[r, c].getCellDep() == true)
                        {
                            nodes[r, c].FillRectangleWithImage(gr, depart);
                            startCell = nodes[r, c];
                        }
                        if (nodes[r, c].getCellEnd() == true)
                        {
                            SolidBrush brushend = new SolidBrush(Color.Red);
                            nodes[r, c].FillRectangle(gr, brushend);
                            nodes[r, c].FillRectangleWithImage(gr, fin);
                            endCell = nodes[r, c];
                        }
                        if (nodes[r, c].getTraversable() == false)
                        {
                            nodes[r, c].FillRectangleWithImage(gr, mur);
                        }

                        if (nodes[r, c].getBoue() == true)
                        {
                            nodes[r, c].FillRectangleWithImage(gr, boue);
                        }
                        if (nodes[r, c].getPiege() == true)
                        {
                            nodes[r, c].FillRectangleWithImage(gr, piege);
                        }
                    }
                }

            }

            // label3.Text = StraightLineDistanceTo(nodes[2, 6]).ToString();
            picMaze.Image = bm;






        }

        public void makemap(int wid, int hgt)
        {
            CellWid = picMaze.ClientSize.Width / (wid + 2);
            CellHgt = picMaze.ClientSize.Height / (hgt + 2);
            if (CellWid > CellHgt) CellWid = CellHgt;
            else CellHgt = CellWid;
            Xmin = (picMaze.ClientSize.Width - wid * CellWid) / 2;
            Ymin = (picMaze.ClientSize.Height - hgt * CellHgt) / 2;
            nodes = new Cell[hgt, wid];
            for (int r = 0; r < hgt; r++)
            {
                int y = Ymin + CellHgt * r;
                for (int c = 0; c < wid; c++)
                {
                    int x = Xmin + CellWid * c;
                    nodes[r, c] = new Cell(x, y);

                    if (c == wid - 1 && r == hgt - 1)
                    {
                        //nodes[r, c] = new Fin(x, y);
                        foreach (Cell mur in arraymur) // chaque case dans la liste des murs ne peuvent pas être traversé
                        {
                            for (int u = 0; u < hgt; u++)
                            {
                                for (int w = 0; w < wid; w++)
                                {
                                    if (nodes[u, w].getX() == mur.getX() && nodes[u, w].getY() == mur.getY())
                                    {
                                        nodes[u, w].setTraversable(false);
                                    }
                                }
                            }


                        }
                        foreach (Cell mur in arraydepart)
                        {
                            for (int u = 0; u < hgt; u++)
                            {
                                for (int w = 0; w < wid; w++)
                                {
                                    if (nodes[u, w].getX() == mur.getX() && nodes[u, w].getY() == mur.getY())
                                    {
                                        nodes[u, w].setCellDep(true);
                                    }
                                }
                            }


                        }
                        foreach (Cell mur in arrayfin)
                        {
                            for (int u = 0; u < hgt; u++)
                            {
                                for (int w = 0; w < wid; w++)
                                {
                                    if (nodes[u, w].getX() == mur.getX() && nodes[u, w].getY() == mur.getY())
                                    {
                                        nodes[u, w].setCellEnd(true);
                                    }
                                }
                            }
                        }
                        foreach (Cell mur in arrayPiege)
                        {
                            for (int u = 0; u < hgt; u++)
                            {
                                for (int w = 0; w < wid; w++)
                                {
                                    if (nodes[u, w].getX() == mur.getX() && nodes[u, w].getY() == mur.getY())
                                    {
                                        nodes[u, w].setPiege(true);
                                    }
                                }
                            }
                        }
                        foreach (Cell mur in arrayBoue)
                        {
                            for (int u = 0; u < hgt; u++)
                            {
                                for (int w = 0; w < wid; w++)
                                {
                                    if (nodes[u, w].getX() == mur.getX() && nodes[u, w].getY() == mur.getY())
                                    {
                                        nodes[u, w].setBoue(true);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            setCells(nodes);
            for (int r = 0; r < hgt; r++)
            {
                for (int c = 0; c < wid; c++)
                {

                    if (r > 0)
                    {


                        if (nodes[r - 1, c].getTraversable())
                        {
                            nodes[r, c].Neighbors[Cell.North] = nodes[r - 1, c];
                            nodes[r, c].setVoisinNord(nodes[r - 1, c]);
                        }
                        else
                        {
                            nodes[r, c].Neighbors[Cell.North] = null;
                            nodes[r, c].setVoisinNord(null);
                        }




                    }
                    if (r < hgt - 1)
                    {




                        if (nodes[r + 1, c].getTraversable())
                        {
                            nodes[r, c].Neighbors[Cell.South] = nodes[r + 1, c];
                            nodes[r, c].setVoisiSud(nodes[r + 1, c]);
                        }
                        else
                        {
                            nodes[r, c].Neighbors[Cell.South] = null;
                            nodes[r, c].setVoisiSud(null);
                        }


                        if (c < wid - 1)
                        {
                            if (nodes[r + 1, c + 1].getTraversable())
                            {

                                nodes[r, c].setVoisinSudEst(nodes[r + 1, c + 1]);
                            }
                            else
                            {

                                nodes[r, c].setVoisinSudEst(null);
                            }
                            if (r > 0)
                            {

                                if (nodes[r - 1, c + 1].getTraversable())
                                {

                                    nodes[r, c].setVoisinNordEst(nodes[r - 1, c + 1]);
                                }
                                else
                                {

                                    nodes[r, c].setVoisinNordEst(null);
                                }
                            }


                        }
                        if (c > 0)
                        {

                            if (nodes[r + 1, c - 1].getTraversable())
                            {

                                nodes[r, c].setVoisinSudOuest(nodes[r + 1, c - 1]);
                            }
                            else
                            {

                                nodes[r, c].setVoisinSudOuest(null);
                            }
                            if (r > 0)
                            {
                                if (nodes[r - 1, c - 1].getTraversable())
                                {

                                    nodes[r, c].setVoisinNordOuest(nodes[r - 1, c - 1]);
                                }
                                else
                                {

                                    nodes[r, c].setVoisinNordOuest(null);
                                }
                            }
                        }

                    }
                    if (c > 0)
                    {




                        if (nodes[r, c - 1].getTraversable())
                        {
                            nodes[r, c].Neighbors[Cell.West] = nodes[r, c - 1];
                            nodes[r, c].setVoisinOuest(nodes[r, c - 1]);
                        }
                        else
                        {
                            nodes[r, c].Neighbors[Cell.West] = null;
                            nodes[r, c].setVoisinOuest(null);

                        }

                    }
                    if (c < wid - 1)
                    {

                        if (nodes[r, c + 1].getTraversable())
                        {
                            nodes[r, c].Neighbors[Cell.East] = nodes[r, c + 1];
                            nodes[r, c].setVoisinEst(nodes[r, c + 1]);
                        }
                        else
                        {
                            nodes[r, c].Neighbors[Cell.East] = null;
                            nodes[r, c].setVoisinEst(null);

                        }

                    }


                }
            }
            DisplayMaze(nodes);
        }

        private void picMaze_Click(object sender, EventArgs e)
        {
      
            list.Clear();
            Point topLeft = PointToScreen(new Point(picMaze.Left, picMaze.Top));
            int x = MousePosition.X - topLeft.X;
            int y = MousePosition.Y - topLeft.Y;
            foreach (Cell cell in getCells())
            {
                Cell[,] newArray;
                int cell_x = cell.getX();
                int cell_y = cell.getY();
                if (cell.getAllX().Contains(x))
                {
                    if (cell.getAllY().Contains(y))
                    {
                        Console.WriteLine("" + cell.getX() + " " + cell.getY());
                        using (Graphics gr = Graphics.FromImage(bm))
                        {
                            if (cellclic == "mur")
                            {
                                cell.FillRectangleWithImage(gr, mur);
                                arraymur.Add(cell);
                            }
                            if (cellclic == "piège")
                            {

                                cell.FillRectangleWithImage(gr, piege);
                                arrayPiege.Add(cell);
                            }
                            if (cellclic == "rien")
                            {
                                Console.WriteLine(cell.getX() + " " + cell.getY());
                                if (arraymur.Contains(cell) == true)
                                {
                                    arraymur.Remove(cell);
                                    cell.FillRectangleWithImage(gr, herbe);
                                    cell.DrawBoundingBox(gr, Pens.Blue);
                                    cell.setTraversable(true);
                                }
                                else
                                {
                                    foreach (Cell caseCell in arraymur)
                                    {
                                        if (caseCell.getX() == cell.getX() && caseCell.getY() == cell.getY())
                                        {
                                            arraymur.Remove(caseCell);
                                            cell.FillRectangleWithImage(gr, herbe);
                                            cell.DrawBoundingBox(gr, Pens.Blue);
                                            cell.setTraversable(true);
                                            break;
                                        }

                                    }

                                }
                                if (arrayBoue.Contains(cell) == true)
                                {
                                    arrayBoue.Remove(cell);
                                    cell.FillRectangleWithImage(gr, herbe);
                                    cell.DrawBoundingBox(gr, Pens.Blue);
                                }
                                else
                                {
                                    foreach (Cell caseCell in arrayBoue)
                                    {
                                        if (caseCell.getX() == cell.getX() && caseCell.getY() == cell.getY())
                                        {
                                            arrayBoue.Remove(caseCell);
                                            cell.FillRectangleWithImage(gr, herbe);
                                            cell.DrawBoundingBox(gr, Pens.Blue);
                                            cell.setTraversable(true);
                                            break;
                                        }
                                    }
                                }


                                if (arrayPiege.Contains(cell) == true)
                                {
                                    arrayPiege.Remove(cell);
                                    cell.FillRectangleWithImage(gr, herbe);
                                    cell.DrawBoundingBox(gr, Pens.Blue);
                                }
                                else
                                {
                                    foreach (Cell caseCell in arrayPiege)
                                    {
                                        if (caseCell.getX() == cell.getX() && caseCell.getY() == cell.getY())
                                        {
                                            arrayPiege.Remove(caseCell);
                                            cell.FillRectangleWithImage(gr, herbe);
                                            cell.DrawBoundingBox(gr, Pens.Blue);
                                            cell.setTraversable(true);
                                            break;
                                        }

                                    }

                                }
                                if (arraydepart.Contains(cell) == true)
                                {
                                    arraydepart.Remove(cell);
                                    cell.FillRectangleWithImage(gr, herbe);
                                    cell.DrawBoundingBox(gr, Pens.Blue);
                                }
                                else
                                {
                                    foreach (Cell caseCell in arraydepart)
                                    {
                                        if (caseCell.getX() == cell.getX() && caseCell.getY() == cell.getY())
                                        {
                                            arraydepart.Remove(caseCell);
                                            cell.FillRectangleWithImage(gr, herbe);
                                            cell.DrawBoundingBox(gr, Pens.Blue);
                                            cell.setTraversable(true);
                                            break;
                                        }

                                    }

                                }
                                if (arrayfin.Contains(cell) == true)
                                {
                                    arrayfin.Remove(cell);
                                    cell.FillRectangleWithImage(gr, herbe);
                                    cell.DrawBoundingBox(gr, Pens.Blue);
                                }
                                else
                                {
                                    foreach (Cell caseCell in arrayfin)
                                    {
                                        if (caseCell.getX() == cell.getX() && caseCell.getY() == cell.getY())
                                        {
                                            arrayfin.Remove(caseCell);
                                            cell.FillRectangleWithImage(gr, herbe);
                                            cell.DrawBoundingBox(gr, Pens.Blue);
                                            cell.setTraversable(true);
                                            break;
                                        }

                                    }

                                }

                            }
                            if (cellclic == "depart")
                            {
                                if (arraydepart.Count == 0)
                                {
                                    cell.FillRectangleWithImage(gr, depart);
                                    arraydepart.Add(cell);
                                }
                                else
                                {
                                    arraydepart[0].FillRectangleWithImage(gr, herbe);
                                    arraydepart.Clear();
                                    cell.FillRectangleWithImage(gr, depart);
                                    arraydepart.Add(cell);
                                }
                            }
                            if (cellclic == "fin")
                            {
                                if (arrayfin.Count == 0)
                                {
                                    arrayfin.Add(cell);
                                    SolidBrush brushend = new SolidBrush(Color.Red);
                                    cell.FillRectangle(gr, brushend);
                                    cell.FillRectangleWithImage(gr, fin);
                                }
                                else
                                {
                                    arrayfin[0].FillRectangleWithImage(gr, herbe);
                                    arrayfin.Clear();
                                    SolidBrush brushend = new SolidBrush(Color.Red);
                                    cell.FillRectangle(gr, brushend);
                                    cell.FillRectangleWithImage(gr, fin);
                                    arrayfin.Add(cell);
                                }
                            }
                            if (cellclic == "boue")
                            {
                                arrayBoue.Add(cell);
                                cell.FillRectangleWithImage(gr, boue);
                            }


                        }
                        picMaze.Image = bm;


                    }

                }


            }

        }

        private void frmEditeur_Load(object sender, EventArgs e)
        {
            if (frmJouer.idmap != 0)
            {
                idmap = frmJouer.idmap;
                map map = new map();
                map = testcontext.map.Where(p => p.id == idmap).First<map>();
                setEmp(map);
                loadMap();
                txtBxNom.Text = map.nom_map;
                txtBxCreateur.Text = map.createurName;
            }
            else
            {
                CreateMap();
                iduser = frmLogin.iduser;
                user user = new user();
                
                user = testcontext.user.Where(p => p.id == iduser).First<user>();
                setUtilisateur(user);
                txtBxNom.Text = "Sans Titre";
                txtBxCreateur.Text = frmLogin.username;
            }
        }


        private void frmEditeur_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmJouer.idmap = 0;
            idmap = 0;
        }

        private void frmEditeur_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmJouer.idmap = 0;
            idmap = 0;

        }
    }
    

}

