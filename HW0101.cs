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
            Question1();

            Question2();

            Question3();

            Question4();

            Question5();

            Question6();
        }

        private static void Question1()
        {

            // 1
            for (int i = 1; i <= 2000; i++)
            {
                Console.WriteLine(i);
            }

            // 1a. zugi
            for (int i = 2; i <= 100; i = i + 2)
            {
                Console.WriteLine(i);
            }

            // 1b. module 10 == 0
            for (int i = 10; i <= 100; i = i + 10)
            {
                Console.WriteLine(i);
            }

        }

        private static void Question2()
        {
            for (int i = 100; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }

        private static void Question3()
        {
            int a = Convert.ToInt32(Console.ReadLine());

            if (a < 10 || a > 99)
            {
                Console.WriteLine("Not 2 digit number!");
                return;
            }

            int ahadot = a % 10;
            Console.WriteLine($"ahadot = {ahadot}");

            int asarot = a / 10;
            Console.WriteLine($"asarot = {asarot}");

            if (asarot > ahadot)
            {
                Console.WriteLine("Asarot is bigger than ahadot");
            }
            else if (ahadot > asarot)
            {
                Console.WriteLine("Ahadot is bigger than asarot");
            }
            else
            {
                Console.WriteLine("Ahadot equal to Asarot");
            }
        }

        private static void Question4()
        {
            for (int i = 1; i <= 100; i++)
            {
                // check if i is prime or not
                int m = 2;
                while (i % m != 0 && m < i)
                {
                    m++;
                }

                if (m < i)
                {
                    Console.WriteLine($"{i} is prime indeed");
                }
            }
        }

        private static void Question5()
        {
            Console.WriteLine("Amount to withdraw?");
            int money = Convert.ToInt32(Console.ReadLine());
            int bill200 = money / 200;
            Console.WriteLine($"{bill200} x 200 bills");
            //money = money - bill200 * 200;
            money = money % 200;

            int bill100 = money / 100;
            Console.WriteLine($"{bill100} x 100 bills");
            money = money - bill100 * 100;
            //money = money % 100;

            int bill20 = money / 20;
            Console.WriteLine($"{bill20} x 20 bills");
            money = money - bill20 * 20;

            int coin5 = money / 5;
            Console.WriteLine($"{coin5} x 5 coins");


            Console.WriteLine("Goodbye");
        }

        private static void Question6()
        {
            Console.WriteLine("Enter size of Triangle:");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i <= size; i++)
            {
                /* 
                 * Easy:
                for (int j = 1; j <= i; j++)
                {
                    Console.Write( j ); // print j without line feed
                }
                for (int j = i + 1; j <= size; j++)
                {
                    Console.Write("*");
                }
                */
                // we don't like easy
                for (int j = 1; j <= size; j++)
                {
                    /*
                     * normal
                    if (j <= i)
                    {
                        Console.Write(j);
                    }
                    else
                    {
                        Console.Write("*");
                    }
                    */

                    // one-liner
                    Console.Write(j <= i ? j.ToString() : "*");
                }


                Console.WriteLine(); // go down a line after each i iteration
            }
        }

    }
}
