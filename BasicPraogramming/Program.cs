using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPraogramming
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i, n;
            double s = 0.0;

            
            Console.WriteLine("Calculate the harmonic series and their sum:\n");

            Console.Write("Input the number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine("1/{0} + ", i);
                s += 1 / (float)i;
            }
            Console.WriteLine("\nSum of Series upto {0} terms : {1} ", n, s);
            Console.ReadLine();
        }
       

    }
    
}
