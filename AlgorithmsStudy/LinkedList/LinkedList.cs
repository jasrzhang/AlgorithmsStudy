using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace AlgorithmsStudy.LinkedList
{
    public class LinkedList
    {
        private Node head;
        private Node tail;
        private int size;

        public LinkedList()
        {
            this.head = null;
            this.tail = null;
            this.size = 0;
        }

        public int Length()
        {
            return size;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public void AddFirst(int e)
        {
            Node newest = new Node(e, null);
            if(IsEmpty())
            {
                head = newest;
                tail = newest;
            }
            else
            {
                newest.next = head;
                head = newest;
            }
            size++;
        }

        public void AddAny(int e, int position)
        {
            if(position <= 0 || position >= size)
            {
                Console.WriteLine("Invailid Position");
                return;
            }
            Node newest = new Node(e, null);
            Node p = head;
            int i = 1;
            while( i < position - 1)
            {
                p = p.next;
                i++;
            }
            newest.next = p;
            p = newest;
            size++;
        }

        public void InsertSorted(int e)
        {
            Node newest = new Node(e, null);
            if( IsEmpty())
            {
                head = newest;
                tail = newest;
            }
            else
            {
                Node p = head;
                Node q = head;
                while ( p != null && p.element < e )
                {
                    q = p;
                    p = p.next;
                }
                if ( p == head )
                {
                    newest.next = head;
                    head = newest;
                }
                else
                {
                    newest.next = q.next;
                    q.next = newest;
                }
            }
            size++;
        }

        public int RemoveFirst()
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is Empty");
                return -1;
            }
            int e = head.element;
            head = head.next;
            size--;
            if (IsEmpty())
            {
                tail = null;
            }
            return e;
        }

        public int RemoveLast()
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is Empty");
                return -1;
            }
            Node p = head;
            int i = 1;
            while(i< size-1) {
                p = p.next;
                i++;
            }
            tail = p;
            p = p.next;
            int e = p.element;
            tail.next = null;
            size--;
            return e;
        }

        public int RemoveAny(int position)
        {
            if(position <= 0 || position >= size)
            {
                Console.WriteLine("Position is invalid");
                return -1;
            }
            Node p = head;
            int i = 1;
            while( i < position-1)
            {
                p = p.next;
                i++;
            }
            int e = p.next.element;
            p.next = p.next.next;
            size--;
            return e;
        }

        public int Search(int key)
        {
            Node p = head;
            int index = 0;
            while( p != null )
            {
                if(p.element == key)
                {
                    return index;
                }
                p = p.next;
                index++;
            }
            return -1;
        }

        public void Display()
        {
            Node p = head;
            while( p != null)
            {
                Console.Write(p.element + " ");
                p = p.next;
            }
            Console.WriteLine();
        }
        
        public int sum()
        {
            int sum = 0;
            Node p = head;
            while( p != null )
            {
                sum += p.element;
                p = p.next;
            }
            return sum;
        }

        public int MaxElement()
        {
            Node p = head;
            int max = -1;
            while( p != null )
            {
                if(p.element > max)
                {
                    max = p.element;
                }
                p = p.next;
            }
            return max;
        }
    }
}
