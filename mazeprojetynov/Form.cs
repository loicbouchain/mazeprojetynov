using MazeProjetYNOV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace mazeprojetynov
{
    public partial class Form : System.Windows.Forms.Form
    {
        private int CellWid;
        private int CellHgt;
        private int Xmin;
        private int Ymin;
        private Graphics graphicsObj;
        private Niveau niv;
        public Bitmap bm;
        private Cell endCell;
        private Cell startCell;
        private List<Cell> cellList;
        private int frmgscore = 0;
        private Pathfinder path;
        public Cell[,] nodes;
        public Cell[,] all;

        List<Cell> list = new List<Cell>();
        List<Cell> arraymur = new List<Cell>();

        public Form()
        {
            InitializeComponent();

        }

        private void Form_Load(object sender, EventArgs e)
        {

        }

        public void makemap(int wid, int hgt )
        {
            nodes = new Cell[hgt, wid];
            for (int r = 0; r < hgt; r++)
            {
                int y = Ymin + CellHgt * r;
                for (int c = 0; c < wid; c++)
                {

                    int x = Xmin + CellWid * c;
                    nodes[r, c] = new Cell(x, y);
                    if (c == 0 && r == 0)
                    {
                        //nodes[r, c] = new Depart(x, y);
                        nodes[r, c].setCellDep(true); //cell de départ

                    }
                    if (c == wid - 1 && r == hgt - 1)
                    {
                        //nodes[r, c] = new Fin(x, y);
                        nodes[5, 6].setCellEnd(true);// cell de fin
                        foreach (Cell mur in arraymur)
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
        private void btnCreate_Click(object sender, EventArgs e)
        {
            //taille du labyrinthe 
            int wid = Int16.Parse(txtWidth.Text);
            int hgt = Int16.Parse(txtHeight.Text);


            CellWid = picMaze.ClientSize.Width / (wid + 2);
            CellHgt = picMaze.ClientSize.Height / (hgt + 2);
            if (CellWid > CellHgt) CellWid = CellHgt;
            else CellHgt = CellWid;
            Xmin = (picMaze.ClientSize.Width - wid * CellWid) / 2;
            Ymin = (picMaze.ClientSize.Height - hgt * CellHgt) / 2;
            makemap(wid, hgt);


            // Make the nodes.
            //créer une liste de Cell 
            /*
            nodes = new Cell[hgt, wid];
            for (int r = 0; r < hgt; r++)
            {
                int y = Ymin + CellHgt * r;
                for (int c = 0; c < wid; c++)
                {

                    int x = Xmin + CellWid * c;
                    nodes[r, c] = new Cell(x, y);
                    if (c == 0 && r == 0)
                    {
                        //nodes[r, c] = new Depart(x, y);
                        nodes[r, c].setCellDep(true); //cell de départ

                    }
                    if (c == wid - 1 && r == hgt - 1)
                    {
                        //nodes[r, c] = new Fin(x, y);
                        nodes[5, 6].setCellEnd(true);// cell de fin
                   nodes[2, 5].setTraversable(false);
                        nodes[3, 5].setTraversable(false);//défini un mur
                        nodes[5, 5].setTraversable(false);
                        nodes[4, 5].setTraversable(false);
                        nodes[6, 5].setTraversable(false);
                        nodes[7, 5].setTraversable(false);
                        nodes[8, 5].setTraversable(false);

                        //nodes[9, 12].setTraversable(false);
                        //nodes[8, 12].setTraversable(false);
                        //nodes[5, 7].setTraversable(false);
                        nodes[4, 7].setTraversable(false);
                        //nodes[6, 7].setTraversable(false);

             

                        //nodes[9, 8].setTraversable(false);
                        //nodes[9, 7].setTraversable(false);


                    }



                }
               
            }
            setCells(nodes);
            // Définie les voisins de chaque cell (les murs ne sont pas considérés comme voisin)
            for (int r = 0; r < hgt; r++)
            {
                for (int c = 0; c < wid; c++)
                {

                    if (r > 0) {

                 
                        if (nodes[r - 1, c].getTraversable())
                        {
                            nodes[r, c].Neighbors[Cell.North] = nodes[r - 1, c];
                            nodes[r, c].setVoisinNord(nodes[r - 1, c]);
                        }
                        else
                        {
                            nodes[r, c].Neighbors[Cell.North] =null;
                            nodes[r, c].setVoisinNord(null);
                        }
                      
                       

                       
                    }
                    if (r < hgt - 1) {

                    


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
                            if (r > 0) { 

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
                            if (r > 0) { 
                                if (nodes[r - 1, c -1].getTraversable())
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
                    if (c > 0) {

                      


                        if (nodes[r, c - 1].getTraversable())
                        {
                            nodes[r, c].Neighbors[Cell.West] = nodes[r, c - 1];
                            nodes[r, c].setVoisinOuest(nodes[r, c - 1]);
                        }
                        else
                        {
                            nodes[r, c].Neighbors[Cell.West] =null;
                            nodes[r, c].setVoisinOuest(null);

                        }

                    }
                    if (c < wid - 1) {

                        if (nodes[r, c + 1].getTraversable())
                        {
                            nodes[r, c].Neighbors[Cell.East] = nodes[r, c + 1];
                            nodes[r, c].setVoisinEst(nodes[r, c + 1]);
                        }
                        else
                        {
                            nodes[r, c].Neighbors[Cell.East] =null;
                            nodes[r, c].setVoisinEst(null);

                        }

                    }
                    

                }
            }*/
            DisplayMaze(nodes); // permet l'affichage dans un picturebox
            /*var astar = new AStarSearch(nodes,startCell, endCell); // Trouve le chemin le plus court
            Cell cell = endCell;
            while(cell != startCell)
            {
                list.Add(cell);//contient la liste définie par astar
                cell = astar.cameFrom[cell];
            }*/
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

        private void DisplayMaze(Cell[,] nodes)
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
                        //Console.WriteLine("le début du truc "+r+" "+c+" " + nodes[r, c].getX() + "   " + nodes[r, c].getY());
                        //nodes[r, c].DrawCenter(gr, Brushes.Red);
                        //nodes[r, c].DrawWalls(gr, Pens.Black);
                        nodes[r, c].DrawBoundingBox(gr, Pens.Blue);
                           

                        //Console.WriteLine(r + " " + c + " heuristic : " + heuristic(nodes[r,c]));
                            
                            // Console.WriteLine(c+"  "+nodes[r, c].getCellDep());
                            if (nodes[r, c].getCellDep() == true) {
                            //       Console.WriteLine("le début du truc " + nodes[r, c].getX() + "   " + nodes[r, c].getY());
                                SolidBrush brush = new SolidBrush(Color.Green);
                                nodes[r,c].FillRectangle(gr, brush);
                                startCell = nodes[r, c];
                            }
                            if (nodes[r, c].getCellEnd() == true)
                            {
                                SolidBrush brush = new SolidBrush(Color.Red);
                                nodes[r, c].FillRectangle(gr, brush);
                                //  Console.WriteLine("la fin du truc "+nodes[r, c].getX() + "   " + nodes[r, c].getY());
                                endCell = nodes[r, c];
                            }
                            if(nodes[r,c].getTraversable() == false)
                            {
                                SolidBrush brushWall = new SolidBrush(Color.Black);
                                nodes[r, c].FillRectangle(gr, brushWall);
                            }
                        }
                    }

            }

               // label3.Text = StraightLineDistanceTo(nodes[2, 6]).ToString();
                picMaze.Image = bm;
          
          




        }
        

        private void button1_Click(object sender, EventArgs e)
        {

            //   DisplayMaze(getCells()); // permet l'affichage dans un picturebox
            makemap(15, 10);
            var astar = new AStarSearch(getCells(), startCell, endCell); // Trouve le chemin le plus court
            Cell current_cell = endCell;
            while (current_cell != startCell)
            {
                list.Add(current_cell);//contient la liste définie par astar
                current_cell = astar.cameFrom[current_cell];
            }

            using (Graphics gr = Graphics.FromImage(bm))
                {
                    gr.SmoothingMode = SmoothingMode.AntiAlias;

                int u = 0;
                    foreach (Cell i in list) //affiche le chemin le plus court
                    {
                        u = u+1;
                    //Console.WriteLine(u+" liste "+i.getX() + "  " + i.getY());
                    //i.DrawBoundingBox(gr, Pens.Black);
                        SolidBrush brush = new SolidBrush(Color.RoyalBlue);
                        i.FillRectangle(gr, brush);

                    }
                SolidBrush brushend = new SolidBrush(Color.Red);
                endCell.FillRectangle(gr, brushend);
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
         

        }

     

        private void picMaze_Click(object sender, EventArgs e)
        {
            list.Clear();
            
            Point topLeft = PointToScreen(new Point(picMaze.Left, picMaze.Top));
            int x = MousePosition.X - topLeft.X;
            int y = MousePosition.Y - topLeft.Y;
            foreach(Cell cell in getCells())
            {
                int cell_x = cell.getX();
                int cell_y = cell.getY();
                for (int c = 0; c < 11; c++)
                {
                    if (x == (cell_x + c))
                    {
                        for (int u = 0; u < 11; u++)
                        {
                            if (y == (cell_y + u))
                            {
                                Console.WriteLine("OUAIAIIAIAIAIAIAIAI");
                                using (Graphics gr = Graphics.FromImage(bm))
                                {
                                    SolidBrush brushend = new SolidBrush(Color.Purple);
                                    cell.FillRectangle(gr, brushend);
                                    cell.setTraversable(false);
                                    arraymur.Add(cell);

                                }
                                picMaze.Image = bm;
                            }
                            }

                        }
                }

            }
           
        }
        
}
    }


