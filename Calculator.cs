using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0101
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 1st number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 2nd number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int option = 0;
            do
            {
                ShowMenu();

                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine($"{a} + {b} = {a + b}");
                        break;
                    case 2:
                        Console.WriteLine($"{a} - {b} = {a - b}");
                        break;
                    case 3:
                        Console.WriteLine($"{a} * {b} = {a * b}");
                        break;
                    case 4:
                        Console.WriteLine($"{a} / {b} = {a / Convert.ToDouble(b)}");
                        break;
                    case 5:
                        Console.WriteLine($"{a} Power {b} = {Math.Pow(a, b)}");
                        break;
                    case 6:
                        Console.WriteLine($"{a} 1/Power {b} = {Math.Pow(a, 1.0f / b)}");
                        break;
                    case 7:
                        Console.WriteLine("Good bye ... see you soon");
                        break;
                    default:
                        Console.WriteLine("Please choose an option between 1-7");
                        break;
                }
            }
            while (option != 7);
        }

        private static void ShowMenu()
        {
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Power");
            Console.WriteLine("6. 1/Power");
            Console.WriteLine("7. exit");
        }
    }
}
