using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsStudy.LinkedList
{
    public class Node
    {
        public int element;
        public Node next;
        public Node(int e, Node next)
        {
            this.element = e;
            this.next = next;
        }
    }
}
