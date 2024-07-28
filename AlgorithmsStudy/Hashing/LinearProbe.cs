using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsStudy.Hashing
{
    public class LinearProbe
    {
        int hashTableSize;
        int[] hashTable;
        public LinearProbe()
        {
            hashTableSize = 10;
            hashTable = new int[hashTableSize];
        }

        public int hashCode(int key)
        {
            return key % hashTableSize;
        }

        public int lProbe(int element)
        {
            int i = hashCode(element);
            int j = 0;
            while (hashTable[(i + j) % hashTableSize] != 0)
            {
                j++;
            }
            return (i + j) % hashTableSize;
        }

        public void Insert(int element)
        {
            int i = hashCode(element);
            if (hashTable[i] == 0)
            {
                hashTable[i] = element;
            }
            else
            {
                i = lProbe(element);
                hashTable[i] = element;
            }
        }

        public bool Search(int key)
        {
            int i = hashCode(key);
            int j = 0;
            while (hashTable[(i + j) % hashTableSize] != key)
            {
                if (hashTable[(i + j) % hashTableSize] == 0)
                {
                    return false;
                }
                j++;
            }
            return true;
        }

        public void Display()
        {
            for (int i = 0; i < hashTableSize; i++)
            {
                Console.Write(hashTable[i] + " ");
            }
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            LinearProbe probe = new LinearProbe();
            probe.Insert(54);
            probe.Insert(78);
            probe.Insert(64);
            probe.Insert(92);
            probe.Insert(34);
            probe.Insert(86);
            probe.Insert(28);
            probe.Display();
            Console.WriteLine(probe.Search(54));
        }
    }
}
