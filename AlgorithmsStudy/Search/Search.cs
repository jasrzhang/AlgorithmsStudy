using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsStudy.Search
{
    internal class Search
    {

        public int LinearSearch(int[] A, int n, int key)
        {
            int index = 0;
            while (index < n)
            {
                if (A[index] == key)
                    return index;
                index++;
            }
            return -1;
        }

        public int BinaryIterative(int[] A, int n, int key)
        {
            int l = 0;
            int r = n - 1;
            while (l <= r)
            {
                var mid = (l + r) / 2;
                if (A[mid] == key) return mid;
                else if (key < A[mid])
                {
                    r = mid - 1;
                }
                else if (key > A[mid])
                {
                    l = mid + 1;
                }
            }
            return -1;
        }

        public int BinaryRecursive(int[] A, int key, int l, int r)
        {
            if (l > r)
            {
                return -1;
            }
            else
            {
                int mid = (l + r) / 2;
                if (key == A[mid])
                {
                    return mid;
                }
                else if (key < A[mid])
                {
                    return BinaryRecursive(A, key, l, mid - 1);
                }
                else if (key > A[mid])
                {
                    return BinaryRecursive(A, key, mid + 1, r);
                }
            }
            return -1;
        }

        public static void Main(string[] args)
        {
            Search ls = new Search();
            int[] A = { 84, 21, 47, 96, 15 };
            int found = ls.LinearSearch(A, A.Length, 96);
            Console.WriteLine("Linear search result in the Array at index: " + found);

            found = ls.BinaryIterative(A, A.Length, 96);
            Console.WriteLine("Binary search iterative result in the Array at index: " + found);

            found = ls.BinaryRecursive(A, 96, 0, A.Length - 1);
            Console.WriteLine("Binary search recursive result in the Array at index: " + found);
        }
    }
}
