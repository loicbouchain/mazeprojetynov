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

        public Form()
        {
            InitializeComponent();

        }

        private void Form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Drawing.Graphics graphicsObj;

            graphicsObj = this.CreateGraphics();
            Pen mypen = new Pen(System.Drawing.Color.Green, 3);
            Rectangle myRect = new Rectangle(0, 0, 100, 100);

            graphicsObj.DrawRectangle(mypen, myRect);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int wid = 15;
            int hgt = 10;
            label3.Text = wid + " " + hgt; 
            Console.WriteLine("le dbut" + wid + " " + hgt);
            CellWid = picMaze.ClientSize.Width / (wid + 2);
            CellHgt = picMaze.ClientSize.Height / (hgt + 2);
            if (CellWid > CellHgt) CellWid = CellHgt;
            else CellHgt = CellWid;
            Xmin = (picMaze.ClientSize.Width - wid * CellWid) / 2;
            Ymin = (picMaze.ClientSize.Height - hgt * CellHgt) / 2;
            Console.WriteLine("Xmin et y"+Xmin+" "+Ymin);


            // Make the nodes.
            Cell[,] nodes = new Cell[hgt, wid];
            for (int r = 0; r < hgt; r++)
            {
                Console.WriteLine("R = "+r);
                int y = Ymin + CellHgt * r;
                for (int c = 0; c < wid; c++)
                {
                    Console.WriteLine("C = " + c);
                    int x = Xmin + CellWid * c;
                    nodes[r, c] = new Cell(
                        x, y);
                   
                }
            }
            // Initialize the nodes' neighbors.
            for (int r = 0; r < hgt; r++)
            {
                for (int c = 0; c < wid; c++)
                {
                    if (r > 0)
                        nodes[r, c].Neighbors[Cell.North] = nodes[r - 1, c];
                    if (r < hgt - 1)
                        nodes[r, c].Neighbors[Cell.South] = nodes[r + 1, c];
                    if (c > 0)
                        nodes[r, c].Neighbors[Cell.West] = nodes[r, c - 1];
                    if (c < wid - 1)
                        nodes[r, c].Neighbors[Cell.East] = nodes[r, c + 1];
                }
            }
            // Display the maze.
            foreach (Cell i in nodes)
            {
                System.Console.WriteLine("{0} ", i.getX());
            }
            FindSpanningTree(nodes[0,0]);
            DisplayMaze(nodes);
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
                    links.Add(new MazeLink(root, neighbor));
            }

            // Add the other nodes to the tree.
            while (links.Count > 0)
            {
                // Pick a random link.
                int link_num = rand.Next(0, links.Count);
                MazeLink link = links[link_num];
                links.RemoveAt(link_num);

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
                foreach (Cell neighbor in to_node.Neighbors)
                {
                    if ((neighbor != null) && (neighbor.Predecessor == null))
                        links.Add(new MazeLink(to_node, neighbor));
                }
            }
        }
        // Display the maze in the picMaze PictureBox.
        private void DisplayMaze(Cell[,] nodes)
        {
            int hgt = nodes.GetUpperBound(0) + 1;
            int wid = nodes.GetUpperBound(1) + 1;
            Bitmap bm = new Bitmap(
                picMaze.ClientSize.Width,
                picMaze.ClientSize.Height);
            Console.WriteLine(picMaze.ClientSize.Width);
            using (Graphics gr = Graphics.FromImage(bm))
            {
                gr.SmoothingMode = SmoothingMode.AntiAlias;
                for (int r = 0; r < hgt; r++)
                {
                    for (int c = 0; c < wid; c++)
                    {
                        //nodes[r, c].DrawCenter(gr, Brushes.Red);
                        //nodes[r, c].DrawWalls(gr, Pens.Black);
                        //nodes[r, c].DrawNeighborLinks(gr, Pens.Black);
                        nodes[r, c].DrawBoundingBox(gr, Pens.Blue);
                        //nodes[r, c].DrawPredecessorLink(gr, Pens.LightGray);

                        graphicsObj = this.CreateGraphics();
                        Pen mypen = new Pen(System.Drawing.Color.Green, 3);
                        Rectangle myRect = new Rectangle(nodes[r, c].getX(), nodes[r, c].getY(), 10, 10);

                        gr.DrawRectangle(mypen, myRect);
                    }
                }
            }

            picMaze.Image = bm;
        }
    }
}

