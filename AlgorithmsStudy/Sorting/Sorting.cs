using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsStudy.Sorting
{
    internal class Sorting
    {

        // Selection Sort - Unstable sort
        // Strategy: Select the index of smallest element first, and swap value later
        //    1. Select minimum selement from the collection
        //    2. Place selected element in appropriate position
        //    3. Apply this tecniqu on all the remaining elements

        public void SelectionSort(int[] A)
        {
            int n = A.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (A[j] < A[minIndex])
                    {
                        minIndex = j;
                    }
                }
                var temp = A[minIndex];
                A[minIndex] = A[i];
                A[i] = temp;
            }
        }

        // Insertion Sort
        // Strategy: Iterate each element in the array, compary the next element, and swap the next element to the right postion
        // Steps:
        //      1. Select 1 element at a time from the left of the collection
        //      2. Insert the element at proper position
        //      3. After insertion every element to its left will be sorted

        public void InsertionSort(int[] A)
        {
            int n = A.Length;

            // Iterate the array from left to right
            for (int i = 1; i < n; i++)
            {
                // Set/Refresh temp to the current iteration
                int temp = A[i];
                // Set/Refresh postion to the current iteration
                int position = i;

                // While loop checks if the left element is greater than the current, 
                // Push the larger element to the right, and Insert the current one in proper position in the left 
                while (position > 0 && A[position - 1] > temp)
                {
                    A[position] = A[position - 1];
                    position--;
                }
                // Assign Value
                A[position] = temp;
            }
        }

        // Bubble Sort
        // Steps:
        //    1. Compare the consecutive elements
        //    2. If left element is greater than the right element, swap them
        //    3. Continue till the end of the collections and perform several passes to sort the elements

        public void BubbleSort(int[] A)
        {
            // This indicates how many loops exectus, also can use While(isSwap){} loop
            for (int i = A.Length - 1; i >= 0; i--)
            {
                // swap the larger one to the right
                for (int j = 0; j < i; j++)
                {
                    if (A[j] > A[j + 1])
                    {
                        var temp = A[j];
                        A[j] = A[j + 1];
                        A[j + 1] = temp;
                    }
                }
            }
            // Using while loop approach
            var isSwaped = true;
            while(isSwaped)
            {
                isSwaped = false;
                for(int i=0; i< A.Length -1; i++)
                {
                    if (A[i] > A[i + 1])
                    {
                        isSwaped = true;
                        var temp = A[i];
                        A[i] = A[i + 1];
                        A[i + 1] = temp;
                    }
                }
            }
        }

        // Shell Sort
        // Strategy and Steps:
        //    1. selects an element and compare element after a gap
        //    2. Similar to Insertion Sort
        //    3. Insert Selected element from the GAP at its proper postition

        // Gap defined as arr.Length/2, and /2 in every interation
        // Compare the element with right Gapped Element also Left Gapped Element

        public void ShellSort(int[] A)
        {
            int gap = A.Length / 2;
            while (gap > 0)
            {
                int i = gap;
                // i increments from left to right
                while (i < A.Length)
                {
                    // Get current value
                    int temp = A[i];
                    // find the element on the left
                    int j = i - gap;

                    // The left gapped may not exist yet
                    // This gonna check gaps towards left if exists
                    while (j >= 0 && A[j] > temp)
                    {
                        A[j + gap] = A[j];
                        j = j - gap;
                    }
                    // Why there is no comparision here?
                    A[j + gap] = temp;
                    i++;
                }
                gap = gap / 2;
            }
        }

        // Merge Sort
        // Strategy:
        //1. Divide the collection of elements into smaller subsets
        //2. Recursively sort the subsets
        //3. Combine or merge the result into a solution
        //4. Divide and Conquer Approach


        public void MergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                MergeSort(arr, left, mid);
                MergeSort(arr, mid + 1, right);
                Merge(arr, left, mid, right);
            }
        }

        public void Merge(int[] arr, int left, int mid, int right)
        {
            int i = left;
            int j = mid + 1;
            int k = left;
            int[] tempArr = new int[right + 1];

            while (i <= mid && j <= right)
            {
                if (arr[i] < arr[j])
                {
                    tempArr[k] = arr[i];
                    i++;
                }
                else
                {
                    tempArr[k] = arr[j];
                    j++;
                }
                k++;
            }
            while (i <= mid)
            {
                tempArr[k] = arr[i];
                i++;
                k++;
            }
            while (j <= right)
            {
                tempArr[k] = arr[j];
                j++;
                k++;
            }
            for (int x = left; x < right + 1; x++)
            {
                arr[x] = tempArr[x];
            }
        }

        // Quick Sort
        //Strategy:
        //    1. Divide the collection of elements into subsets or partitions
        //    2. Partition based on Pivot
        //    3. Recursively sort the partitions using quick sort
        //    4. Divide and Conquer Approach
        // Pivot: left of the Pivot are all smaller than the pivot, element to the right all larger

        public void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);

                // Recursively sort left and right
                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }

        private int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = (low - 1);

            for (int j = low; j < high; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;

                    //Swap arr[i] and arr[j]
                    var temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // Swap arr[i+1] and arr[hight] (or pivot)
            var temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }

        public void Display(int[] A)
        {
            foreach (var item in A)
            {
                Console.Write(item + " ");
            }
        }

        public static void Main(string[] args)
        {
            int[] arr = { 3, 5, 8, 9, 6, 2 };
            Sorting s = new Sorting();
            Console.WriteLine("Original Array: ");
            s.Display(arr);
            Console.WriteLine();

            s.SelectionSort(arr);
            Console.WriteLine("Selection Sorted Array: ");
            s.Display(arr);
            Console.WriteLine();

            arr = new[] { 3, 5, 8, 9, 6, 2 };
            Console.WriteLine("Original Array: ");
            s.Display(arr);
            Console.WriteLine();

            s.InsertionSort(arr);
            Console.WriteLine("Selection Sorted Array: ");
            s.Display(arr);
            Console.WriteLine();

            arr = new[] { 3, 5, 8, 9, 6, 2 };
            Console.WriteLine("Original Array: ");
            s.Display(arr);
            Console.WriteLine();

            s.BubbleSort(arr);
            Console.WriteLine("BubbleSort Sorted Array: ");
            s.Display(arr);
            Console.WriteLine();

            arr = new[] { 3, 5, 8, 9, 6, 2 };
            Console.WriteLine("Original Array: ");
            s.Display(arr);
            Console.WriteLine();

            s.ShellSort(arr);
            Console.WriteLine("ShellSort Sorted Array: ");
            s.Display(arr);
            Console.WriteLine();


            arr = new[] { 3, 5, 8, 9, 6, 2 };
            Console.WriteLine("Original Array: ");
            s.Display(arr);
            Console.WriteLine();

            s.MergeSort(arr, 0, arr.Length - 1);
            Console.WriteLine("MergeSort Sorted Array: ");
            s.Display(arr);
            Console.WriteLine();

            arr = new[] { 3, 5, 8, 9, 6, 2 };
            Console.WriteLine("Original Array: ");
            s.Display(arr);
            Console.WriteLine();

            s.QuickSort(arr, 0, arr.Length - 1);
            Console.WriteLine("Quick Sorted Array: ");
            s.Display(arr);
            Console.WriteLine();


        }
    }
}
