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
                hi = hi/2;
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

        public void Display()
        {
            for (int i = 0; i < Data.Length; i ++){
                Console.Write(Data[i] + " ");   
            }
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {

        }
    }
}
