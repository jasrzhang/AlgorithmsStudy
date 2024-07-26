using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsStudy.Stack
{
    public class Node
    {
        public int element;
        public Node next;
        public Node(int e, Node n)
        {
            this.element = e;
            this.next = n;
        }
    }
    public class StacksLinkedList
    {
        Node top;
        int size;

        public StacksLinkedList()
        {
            top = null;
            size = 0;
        }

        public int Length()
        {
            return size;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public void Push(int e)
        {
            Node newest = new Node(e, null);
            if (IsEmpty())
            {
                top = newest;
            }
            else
            {
                newest.next = top;
                top = newest;
            }
            size++;
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is Empty");
                return -1;
            }
            int e = top.element;
            top = top.next;
            size--;
            return e;
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is Empty");
                return -1;
            }
            return top.element;
        }

        public void Display()
        {
            Node p = top;
            while (p != null)
            {
                Console.Write(p.element + " ");
                p = p.next;
            }
            Console.WriteLine();
        }


        public static void Main(string[] args)
        {
            StacksLinkedList sl = new StacksLinkedList();
            sl.Push(5);
            sl.Push(3);
            sl.Display();
            Console.WriteLine("Size :" + sl.Length());
            Console.WriteLine("Element Removed: " + sl.Pop());
            sl.Display();
            sl.Push(5);
            Console.WriteLine("List is Empty: " + sl.IsEmpty());
        }
    }
}
