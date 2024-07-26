using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsStudy.Stack
{

    // Feature of Stack: Last - In - First - Out
    // Commonly used:
    //      Web browser history
    //      Undo operations in editing applications (e.g. TextEditor)
    //      HTML document tags matching.
    //      Evaluating arithmetic expression (such as +, , -, / )
    //      Parentheses matching ()
    //      Infix to postfit conversion
    /**
     * Stacks Abstract Data Type(ADT)
     *      push(object): insert element
     *      pop(): remove & return element
     *      top(); returns last inserted element
     *      len(): returns number of elements
     *      isEmpty(): whether stack is empty or not
     */
    public class StacksArray
    {
        int[] data;
        int top;

        public StacksArray(int n)
        {
            this.data = new int[n];
            this.top = 0;
        }

        public void Push(int e)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack is Full/Overflow");
                return;
            }
            this.data[top] = e;
            this.top++;
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("No Element In Stack");
                return -1;
            }
            int e = data[top-1];
            this.top--;
            return e;
        }

        public int[] GetData()
        {
            return data;
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is Empty");
                return -1;
            }
            return this.data[top - 1];
        }

        public int Length()
        {
            return this.top;
        }

        public bool IsEmpty() => this.top == 0;

        public bool IsFull()
        {
            return this.top == data.Length;
        }

        public void Display()
        {
            for(int i = 0; i< this.top;i++)
            {
                Console.Write(this.data[i] + ", ");
            }
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            StacksArray sa = new StacksArray(10);
            sa.Push(5);
            sa.Push(3);
            sa.Display();

            Console.WriteLine("Size: " + sa.Length());
            Console.WriteLine("Element popped: " + sa.Pop());
            Console.WriteLine("Size: " + sa.Length());
            Console.WriteLine("Element Peeked: " + sa.Peek());
        }
    }
}
