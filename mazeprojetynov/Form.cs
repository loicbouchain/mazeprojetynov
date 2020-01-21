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
        List<Cell> list = new List<Cell>();

        public Form()
        {
            InitializeComponent();

        }

        private void Form_Load(object sender, EventArgs e)
        {

        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            int wid = Int16.Parse(txtWidth.Text);
            int hgt = Int16.Parse(txtHeight.Text);


            CellWid = picMaze.ClientSize.Width / (wid + 2);
            CellHgt = picMaze.ClientSize.Height / (hgt + 2);
            if (CellWid > CellHgt) CellWid = CellHgt;
            else CellHgt = CellWid;
            Xmin = (picMaze.ClientSize.Width - wid * CellWid) / 2;
            Ymin = (picMaze.ClientSize.Height - hgt * CellHgt) / 2;



            // Make the nodes.

            Cell[,] nodes = new Cell[hgt, wid];
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
                        nodes[r, c].setCellDep(true);

                    }
                    if (c == wid - 1 && r == hgt - 1)
                    {
                        //nodes[r, c] = new Fin(x, y);
                        nodes[5, 6].setCellEnd(true);
                        nodes[2, 5].setTraversable(false);
                        nodes[3, 5].setTraversable(false);
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
            
            // Initialize the nodes' neighbors.
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
            }
            // Display the maze.
            foreach (Cell i in nodes)
            {

                Console.WriteLine(i.getX() + " "+ i.getY());
                Console.WriteLine("VOISIN SUD " + i.getVoisinSud());
                Console.WriteLine("VOISIN NORD " + i.getVoisinNord());
                Console.WriteLine("VOISIN EST " + i.getVoisinEst());
                Console.WriteLine("VOISIN OUEST " + i.getVoisinOuest());
            }
        

            FindSpanningTree(nodes[0, 0]);
            DisplayMaze(nodes);
            niv = new Niveau(nodes,"","");
            var astar = new AStarSearch(nodes, nodes[0, 0], nodes[5, 6]);
            Cell cell = endCell;
            while(cell != startCell)
            {
                Console.WriteLine(astar.cameFrom[cell].getX() + " " + astar.cameFrom[cell].getY());
                list.Add(cell);
                cell = astar.cameFrom[cell];
            }

            // path = new Pathfinder(niv);
            /*
            using (Graphics gr = Graphics.FromImage(bm))
            {
                gr.SmoothingMode = SmoothingMode.AntiAlias;

                int u = 0;
                foreach (Cell i in path.list)
                {
                    u = u + 1;
                  
                    i.DrawBoundingBox(gr, Pens.Black);
                }
            }
            picMaze.Image = bm;*/
        }


        public double StraightLineDistanceTo(Cell cell)
        {
            return Math.Sqrt(Math.Pow(cell.getX() - endCell.getX(), 2) + Math.Pow(cell.getY() - endCell.getY(), 2));
        }
        public double heuristic(Cell a, Cell b)
        {
            return Math.Abs(a.getX() - b.getX()) + Math.Abs(a.getY() - b.getY());
        }

        
        // Build a spanning tree with the indicated root node.
        private void FindSpanningTree(Cell root)
        {
            Random rand = new Random();

            // Set the root node's predecessor so we know it's in the tree.
            root.Predecessor = root;

            // Make a list of candidate links.
            List<MazeLink> links = new List<MazeLink>();

            // Add the root's links to the links list.
            foreach (Cell neighbor in root.Neighbors)
            {
                if (neighbor != null)
                {
                    if (neighbor.getTraversable()) { 
                    links.Add(new MazeLink(root, neighbor));
                    }
                    // Console.WriteLine(neighbor.getX() + "  " + neighbor.getY()); }

                }

                // Add the other nodes to the tree.

                while (links.Count > 0)
                {

                    // Pick a random link.
                    int link_num = rand.Next(0, links.Count);
                    //int link_num = x;
                    MazeLink link = links[link_num];
                    links.RemoveAt(link_num);
                    {
                        // Add this link to the tree.
                        Cell to_node = link.ToNode;
                        link.ToNode.Predecessor = link.FromNode;

                        // Remove any links from the list that point
                        // to nodes that are already in the tree.
                        // (That will be the newly added node.)
                        for (int i = links.Count - 1; i >= 0; i--)
                        {
                            if (links[i].ToNode.Predecessor != null)
                                links.RemoveAt(i);
                        }

                        // Add to_node's links to the links list.
                        foreach (Cell voisin in to_node.Neighbors)
                        {


                            if ((voisin != null) && (voisin.Predecessor == null))
                            {
                                links.Add(new MazeLink(to_node, voisin));

                            }


                        }
                        // x = x - 1;

                    }
                }
            }
        }
            // Display the maze in the picMaze PictureBox.

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

                            //  nodes[r, c].DrawPredecessorLink(gr, Pens.LightGray);



                        }
                    }

            }

               // label3.Text = StraightLineDistanceTo(nodes[2, 6]).ToString();
                picMaze.Image = bm;
          
          




        }

        private void button1_Click(object sender, EventArgs e)
            {

                using (Graphics gr = Graphics.FromImage(bm))
                {
                    gr.SmoothingMode = SmoothingMode.AntiAlias;

                int u = 0;
                    foreach (Cell i in list)
                    {
                        u = u+1;
                    //Console.WriteLine(u+" liste "+i.getX() + "  " + i.getY());
                    //i.DrawBoundingBox(gr, Pens.Black);
                        SolidBrush brush = new SolidBrush(Color.RoyalBlue);
                        i.FillRectangle(gr, brush);

                }
                SolidBrush brushstart = new SolidBrush(Color.Green);
                startCell.FillRectangle(gr, brushstart);
                SolidBrush brushend = new SolidBrush(Color.Red);
                endCell.FillRectangle(gr, brushend);
            }
                picMaze.Image = bm;


            }
        public int heuristic(Cell cell)
            {

                int dx = Math.Abs(cell.getX() - endCell.getX());
                int dy = Math.Abs(cell.getY() - endCell.getY());
                return dx + dy;
            }
            public int gscore(Cell cell)
            {
                return (cell.getGscore() / 14) + frmgscore;
            }
            public int fscore(Cell cell)
            {
                int h = heuristic(cell);
                int g = gscore(cell);
                return h + g;
            }

        private void picMaze_Click(object sender, EventArgs e)
        {
            /*   int hgt = nodes.GetUpperBound(0) + 1;
               int wid = nodes.GetUpperBound(1) + 1;
               int cursorX = Cursor.Position.X;
               int cursory = Cursor.Position.Y;
               for (int r = 0; r < hgt; r++)
               {
                   for (int c = 0; c < wid; c++)
                   {
                   }
               }*/
         
        }
    }
    }


