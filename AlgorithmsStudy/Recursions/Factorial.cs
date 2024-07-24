using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsStudy.Recursions
{
    internal class Factorial
    {
        public int calculate(int n)
        {
            if (n == 0) return 1;
            int result = 1;
            
           return calculate(n-1)*n;
        }

        public static void Main(string[] args)
        {
            Factorial f = new Factorial();
            Console.WriteLine(f.calculate(4));
        }
    }
}
