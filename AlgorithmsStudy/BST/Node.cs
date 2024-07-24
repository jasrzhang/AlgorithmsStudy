using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsStudy.BST
{
    public class Node
    {
        public int element;
        public Node left;
        public Node right;
        public Node(int element, Node left, Node right)
        {
            this.element = element;
            this.left = left;
            this.right = right;
        }
    }
}
