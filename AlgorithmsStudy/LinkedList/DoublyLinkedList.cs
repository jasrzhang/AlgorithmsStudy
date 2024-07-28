using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsStudy.LinkedList
{
    public class DoubleNode
    {
        public int element;
        public DoubleNode prev;
        public DoubleNode next;

        public DoubleNode(int element, DoubleNode prev, DoubleNode next)
        {
            this.element = element;
            this.prev = prev;
            this.next = next;
        }
    }
    public class DoublyLinkedList
    {
        private DoubleNode Head;
        private DoubleNode Tail;
        private int Size;

        public DoublyLinkedList()
        {
            Head = null;
            Tail = null;
            Size = 0;
        }

        public int Length()
        {
            return Size;
        }

        public bool IsEmpty()
        {
            return Size == 0;
        }

        public void AddLast(int e)
        {
            DoubleNode newest = new DoubleNode(e, null, null);
            if (IsEmpty())
            {
                Head = newest;
                Tail = newest;
                Head.prev = Tail;
                Head.next = Tail;
                Tail.next = Head;
                Tail.prev = Head;
            }
            else
            {
                newest.prev = Tail;
                newest.next = Tail.next;
                Tail.next = newest;
                Tail = newest;
                Head.prev = Tail;
            }
            Size++;
        }

        public void AddFirst(int e)
        {
            DoubleNode newest = new DoubleNode(e, null, null);
            if (IsEmpty())
            {
                Head = newest;
                Tail = newest;
                Head.prev = Tail;
                Head.next = Tail;
                Tail.next = Head;
                Tail.prev = Head;
            }
            else
            {
                newest.next = Head.next;
                Head.prev = newest;
                newest.prev = Head.prev;
                Head = newest;
                Tail.next = Head;
            }
            Size++;
        }

        

        public static void Main(string[] args)
        {

        }
    }
}
