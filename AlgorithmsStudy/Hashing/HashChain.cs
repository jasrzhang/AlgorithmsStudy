using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLinkedList = AlgorithmsStudy.LinkedList.LinkedList; 

namespace AlgorithmsStudy.Hashing
{
    public class HashChain
    {

        int hashTableSize;
        MyLinkedList[] hashTable;

        /**
         * using linked list
         */

        public HashChain()
        {
            hashTableSize = 10;
            hashTable = new MyLinkedList[hashTableSize];
            for(int i = 0; i < hashTableSize; i++)
            {
                hashTable[i] = new MyLinkedList();
            }
        }

        public int HashCode(int key)
        {
            return key % hashTableSize;
        }

        public void Insert(int element)
        {
            int i = HashCode(element);
            hashTable[i].InsertSorted(element);
        }

        public bool Search(int key)
        {
            int i = HashCode((int)key);
            return hashTable[i].Search(key) != -1; 
        }

        public void Display()
        {
            for(int i = 0; i < hashTableSize; i++)
            {
                Console.Write("["+i+"]");
                hashTable[i].Display();
            }
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            HashChain h = new HashChain();
            h.Insert(54);
            h.Insert(78);
            h.Insert(64);
            h.Insert(92);
            h.Display();
        }
    }
}
