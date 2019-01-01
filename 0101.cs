using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0101HW
{
    class Program
    {
        static void Main(string[] args)
        {
            // Switch-case
            /* 
             *  x =0 0 : zero
             *  x == 1 : one
             *  x == 2 : two
             *  ...
             *  x == 9 : nine
             *  else : not one digit number 
             *  */
            int number = Convert.ToInt32(Console.ReadLine());
            if (number == 0)
            {
                Console.WriteLine("Zero");
            }
            else if (number == 1)
            {
                Console.WriteLine("one");
            }
            else if (number == 2)
            {
                Console.WriteLine("two");
            }


            switch (number)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                case 3:
                    Console.WriteLine("Two or Three");
                    break;
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Three four five six seven eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;
                default:
                    Console.WriteLine("Not one digit number");
                    break;
            }
        }
        
    }
}
