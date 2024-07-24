using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsStudy.Recursions
{
    public class SumOfN
    {
        public int SumOfNumber(int n)
        {
            if(n == 0) return 0;
            return SumOfNumber(n-1) + n;
            
        }

        public static void  Main(string[] args)
        {
            SumOfN s = new SumOfN();
            Console.WriteLine(s.SumOfNumber(5));
        }
    }
}
