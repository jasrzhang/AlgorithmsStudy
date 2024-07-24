using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsStudy.Recursions
{
    internal class Recursion
    {
        public void calculateIterative(int n)
        {
            while (n > 0)
            {
                int k = n * n;
                Console.WriteLine(k);
                n = n - 1;
            }
        }

        public void calclateRecursive(int n)
        {
            if (n > 0)
            {
                int k = n * n;
                Console.WriteLine(k);
                calclateRecursive(n - 1);
            }
        }

        public void calculate(int n)
        {
            if (n > 0)
            {
                // logging 1,4,9,16, head recursion
                calculate(n - 1);
                int k = n * n;
                Console.WriteLine(k);
                //Tail recursion, output 16, 9, 4, 1
                // calculate(n - 1);
            }
        }

        static void Main(string[] args)
        {
            Recursion r = new Recursion();
            r.calculate(4);
        }
    }
}
