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

        public Form()
        {
            InitializeComponent();

        }

        private void Form_Load(object sender, EventArgs e)
        {

        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            int wid = 15;
            int hgt = 10;
            label3.Text = wid + " " + hgt;

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
                        nodes[r, c].setCellEnd(true);

                    }
                 

                }
            }
            // Initialize the nodes' neighbors.
            for (int r = 0; r < hgt; r++)
            {
                for (int c = 0; c < wid; c++)
                {
                    if (r > 0) { 
                        nodes[r, c].Neighbors[Cell.North] = nodes[r - 1, c];
                        nodes[r, c].setVoisinNord(nodes[r-1, c]);
                    }
                    if (r < hgt - 1) { 
                        nodes[r, c].Neighbors[Cell.South] = nodes[r + 1, c];
                        nodes[r, c].setVoisiSud(nodes[r + 1, c]);
                    }
                    if (c > 0) { 
                        nodes[r, c].Neighbors[Cell.West] = nodes[r, c - 1];
                        nodes[r, c].setVoisinOuest(nodes[r, c-1]);
                    }
                    if (c < wid - 1) { 
                        nodes[r, c].Neighbors[Cell.East] = nodes[r, c + 1];
                        nodes[r, c].setVoisinEst(nodes[r, c+1]);
                    }

                }
            }
            // Display the maze.
            foreach (Cell i in nodes)
            {
                
               // System.Console.WriteLine("{0} ", i.getCellEnd());
                if (i.getCellDep() == true)
                {
                    startCell = i;
                    Console.WriteLine("VOOVOVOVOVO  "+i.getVoisinEst().getX());
                    Console.WriteLine("VOOVOVOVOVO  " + nodes[0,1].getX());
                }
                if (i.getCellEnd() == true)
                {
                    endCell = i;
                }
            }
            FindSpanningTree(nodes[0, 0]);
            DisplayMaze(nodes);
            niv = new Niveau(nodes, "test", "crea");
            path = new Pathfinder(niv);
        }
   

        public double StraightLineDistanceTo(Cell cell)
        {
            return Math.Sqrt(Math.Pow(cell.getX() - endCell.getX(), 2) + Math.Pow(cell.getY() - endCell.getY(), 2));
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
                    links.Add(new MazeLink(root, neighbor));
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
                            //nodes[r, c].DrawCenter(gr, Brushes.Red);
                            //nodes[r, c].DrawWalls(gr, Pens.Black);
                            nodes[r, c].DrawBoundingBox(gr, Pens.Blue);
                           

                        Console.WriteLine(r + " " + c + " heuristic : " + heuristic(nodes[r,c]));
                            
                            // Console.WriteLine(c+"  "+nodes[r, c].getCellDep());
                            if (nodes[r, c].getCellDep() == true) {
                                //       Console.WriteLine("le début du truc " + nodes[r, c].getX() + "   " + nodes[r, c].getY());
                                nodes[r, c].DrawBoundingBox(gr, Pens.Green);
                                startCell = nodes[r, c];
                            }
                            if (nodes[r, c].getCellEnd() == true)
                            {
                                nodes[r, c].DrawBoundingBox(gr, Pens.Red);
                                //  Console.WriteLine("la fin du truc "+nodes[r, c].getX() + "   " + nodes[r, c].getY());
                                endCell = nodes[r, c];
                            }

                            //  nodes[r, c].DrawPredecessorLink(gr, Pens.LightGray);


                        }
                    }

            }

                label3.Text = StraightLineDistanceTo(nodes[2, 6]).ToString();
                picMaze.Image = bm;
            }

            private void button1_Click(object sender, EventArgs e)
            {

                using (Graphics gr = Graphics.FromImage(bm))
                {
                    gr.SmoothingMode = SmoothingMode.AntiAlias;


                    foreach (Cell i in path.list)
                    {
                        i.DrawBoundingBox(gr, Pens.Black);
                    }
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


