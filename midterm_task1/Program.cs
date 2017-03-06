using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string arr = Console.ReadLine();
            string[] arrr = arr.Split(' ');
            int[] myInts = Array.ConvertAll(arrr, int.Parse);
            for (int i = 0; i < myInts.Length; ++i)
            {
                if (myInts [i]%1000 == 0 && myInts [i] % 15 != 0)
                {
                    int num = myInts[i] / 1000;
                    if (num%10 != 0)
                    {
                        Console.WriteLine(myInts[i]);
                        Console.WriteLine(' ');
                    } 
                    
                   
                }
                
            }
                 
            Console.ReadKey();

        }
    }
}
