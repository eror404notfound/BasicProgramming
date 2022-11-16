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
            Console.WriteLine("Enter A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int temp;
            temp = a;
            Console.WriteLine("Swapped Value of A= " + b);
            Console.ReadLine();
            Console.WriteLine("Swapped value of B= " + a);
            Console.ReadLine();
        }
        
    }
}
