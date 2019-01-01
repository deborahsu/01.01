using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomEngine = new Random(); // memory cell in type of Random Generator

            for (int i = 1; i <= 100; i++)
            {
                //Random randomEngine = new Random(); // not here!!!
                int a = randomEngine.Next(1, 101);
                Console.WriteLine(a);
            }
            
        }
    }
}
