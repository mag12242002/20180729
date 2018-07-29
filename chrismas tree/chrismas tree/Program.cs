using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chrismas_tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int heigh=0;
            while(heigh++<5)
            {
                int a=0;
                while(a++<5-heigh)
                {
                    Console.Write(" ");
                }
                int b = 0;
                while (b++ < 2 * heigh - 1)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
           
        }
    }
}
    
