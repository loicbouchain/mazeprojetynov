
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MazeProjetYNOV
{
    class MazeLink
    {
        public Cell FromNode, ToNode;
        public MazeLink(Cell from_node, Cell to_node)
        {
            FromNode = from_node;
            ToNode = to_node;
        }
    }
}
