using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPraogramming
{
    internal class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to find the prime Factorisation : ");
            int num = Convert.ToInt32(Console.ReadLine());  
            for (int div = 2; div * div <=num; div++)
            {
                while (num % div == 0)
                {
                    num = num / div;
                    Console.WriteLine(div + " ");   
                }
            }
            if (num !=1)
            {
                Console.WriteLine(num);
                Console.ReadLine();

            }

            
               
          



        }
    }
    
}
