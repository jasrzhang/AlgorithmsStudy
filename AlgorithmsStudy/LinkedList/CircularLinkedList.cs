using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsStudy.LinkedList
{
    public class CircularLinkedList
    {
        private Node Head;
        private Node Tail;

        private int size;

        public CircularLinkedList()
        {
            Head = null;
            Tail = null;
            size = 0;
        }

        public int Length()
        {
            return size;
        }

        public bool IsEmpty() { return size == 0; }

        public void AddLast(int e)
        {
            Node newest = new Node(e, null);
            if (IsEmpty())
            {
                newest.next = newest;
                Head = newest;
            }
            else
            {
                newest.next = Tail.next;
                Tail.next = newest;
            }
            Tail = newest;
            size++;
        }

        public void AddFirst(int e)
        {
            Node newest = new Node(e, null);
            if (IsEmpty())
            {
                newest.next = newest;
                Head = newest;
                Tail = newest;
            }
            else
            {
                newest.next = Head;
                Head = newest;
                Tail.next = Head;
            }
            size++;
        }

        public void InsertAny(int element, int position)
        {
            if (position <= 0 || position >= size)
            {
                Console.WriteLine("Invalid Position");
                return;
            }

            int index = 1;
            Node p = Head;
            while (index < position - 1)
            {
                p = p.next;
                index++;
            }

            Node newest = new Node(element, null);
            newest.next = p.next;
            p.next = newest;
            size++;
        }

        public int RemoveFirst()
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is empty");
                return -1;
            }
            int e = Head.element;
            Head = Head.next;
            Tail.next = Head;
            size--;
            return e;
        }

        public int RemoveLast()
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is empty");
                return -1;
            }
            int e = Tail.element;
            Node p = Head;
            int i = 1;
            while (i < size - 1)
            {
                p = p.next;
                i++;
            }
            p.next = Tail.next;
            Tail = p;
            size--;
            return e;
        }
        public int RemoveAny(int position)
        {
            if (position <= 0 || position >= size)
            {
                Console.WriteLine("Invalid Position");
                return -1;
            }

            Node p = Head;
            int i = 1;
            while (i < position - 1)
            {
                p = p.next;
                i++;
            }
            int e = p.next.element;
            p.next = p.next.next;
            size--;
            return e;
        }

        public void Display()
        {
            Node p = Head;
            int i = 0;
            while (i < size)
            {
                Console.Write(p.element + " ");
                p = p.next;
                i++;
            }
            Console.WriteLine();
        }


        public static void Main(string[] args)
        {
            CircularLinkedList cl = new CircularLinkedList();
            cl.AddLast(7);
            cl.AddLast(4);
            cl.AddLast(12);
            cl.Display();
            Console.WriteLine("Size is: " + cl.Length());
            cl.AddLast(8);
            cl.AddLast(3);
            cl.Display();
            Console.WriteLine("Size is: " + cl.Length());
            cl.AddFirst(25);
            cl.Display();
            Console.WriteLine("Size is: " + cl.Length());
            cl.InsertAny(30, 5);
            cl.Display();
            Console.WriteLine("Size is: " + cl.Length());
            Console.WriteLine("Removing first: " + cl.RemoveFirst());
            cl.Display();
            Console.WriteLine("Size is: " + cl.Length());
            Console.WriteLine("Remove Last: " + cl.RemoveLast());
            Console.WriteLine("Head After Remove: " + cl.Head.element);
            Console.WriteLine("Tail After Remove: " + cl.Tail.element);
            cl.Display();
            Console.WriteLine("Size is: " + cl.Length());
            Console.WriteLine("Remove Any at index 3 : " + cl.RemoveAny(3));
            cl.Display();
            Console.WriteLine("Size is: " + cl.Length());

        }
    }
}
