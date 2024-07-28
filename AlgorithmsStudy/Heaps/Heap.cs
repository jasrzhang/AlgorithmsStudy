using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsStudy.Heaps
{
    internal class Heap
    {
        private int[] Data;
        private int MaxSize;
        private int CurrentSize;

        public Heap()
        {
            this.MaxSize = 10;
            this.Data = new int[MaxSize];
            this.CurrentSize = 0;
            for (int i = 0; i < this.Data.Length; i++)
            {
                this.Data[i] = -1;
            }
        }

        public int Length()
        {
            return this.CurrentSize;
        }

        public bool IsEmpty()
        {
            return this.CurrentSize == 0;
        }

        public bool IsFull()
        {
            return this.CurrentSize == MaxSize;
        }

        // Insertion Logic:
        //      1. Need to maintain Strcutual Property ( as a Complete Tree), and Relation
        //      2. Need to maintain Relational Property ( perform up-heap bubbling)
        public void Insert(int e)
        {
            if (IsFull())
            {
                Console.WriteLine("No Space in Heap");
                return;
            }
            this.CurrentSize++;
            int hi = this.CurrentSize;
            while (hi > 1 && e > Data[hi / 2])
            {
                Data[hi] = Data[hi / 2];
                hi = hi / 2;
            }
            Data[hi] = e;
        }

        public int Max()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Heap is Empty");
                return -1;
            }
            return Data[1];
        }

        public void Display(int[]? arr = null)
        {
            if (arr == null) arr = this.Data;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        /** Deletion Logic:
         *      Heaps are 'Priority Queues', so we cannot delete or remove any arbitary element -> Only Delete/Remove the Root of the heap
         *      Cannot remove it directly, as will lose the Structural of the tree.
         *  Steps: 
         *      1. Element is removed from the root. 
         *      2. Preserve Structual Property: The root will be replaced by the element from the last node. Then remove the last node.
         *      3. Preserve Relational Property: Perform down-heap bubbling - Element swap with the Greater sibling
         *          case A: The node has only one child that is the left child. 
         *          case B: The node has both children. 
         * 
         */

        public int DeleteMax()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Heap is empty");
                return -1;
            }
            // Step 1: Grab the root, and swap the last element with root, thus preserve the structural property
            int e = Data[1];
            Data[1] = Data[CurrentSize];
            Data[CurrentSize] = -1;
            CurrentSize--;

            // Step 2: Maintain Relational property
            int i = 1; int j = i * 2;
            while (j <= CurrentSize)
            {
                // Choose greater child.
                if (Data[j] < Data[j + 1])
                {
                    j++;
                }
                if (Data[i] < Data[j])
                {
                    // Down heap bubbling
                    int temp = Data[i];
                    Data[i] = Data[j];
                    Data[j] = temp;
                    // Downward examine this subtree
                    i = j;
                    j = i * 2;
                }
                else
                {
                    break;
                }
            }
            return e;
        }

        /**
         *  Sort Strategy:
         *      1. Uses Heaps data structure
         *      2. Insert elements in the heap
         *      3. Perform deletion until the heap is empty
         *      4. Store deleted elements from the heap back into the array
         */

        public int[] Sort(int[] arr)
        {
            Heap h = new Heap();
            h.Data = (int[])this.Data.Clone();

            for(int i = 0; i < arr.Length; i++)
            {
                h.Insert(arr[i]);
            }

            int k = arr.Length - 1;
            for (int j = 0; j < arr.Length; j++)
            {
                arr[k] = h.DeleteMax();
                k--;
            }
            return arr;
        }

        public static void Main(string[] args)
        {
            Heap h = new Heap();
            h.Insert(25);
            h.Insert(14);
            h.Insert(2);
            h.Insert(20);
            h.Insert(10);
            h.Insert(40);

            h.Display();

            Console.WriteLine("Deleted number is: " + h.DeleteMax());

            h.Display();

            int[] arr = {63, 250, 835, 947,28 };

            h.Display(h.Sort(arr));
        }
    }
}
