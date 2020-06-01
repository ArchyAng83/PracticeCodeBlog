using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uwerq
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("ввести числа");
                int firstDigit = int.Parse(Console.ReadLine());
                int secondDigit = int.Parse(Console.ReadLine());
                int thirdDigit = int.Parse(Console.ReadLine());

                if (firstDigit > secondDigit && firstDigit > thirdDigit)
                {
                    Console.WriteLine(firstDigit);
                }
                else if (secondDigit > firstDigit && secondDigit > thirdDigit)
                {
                    Console.WriteLine(secondDigit);
                }
                else
                    Console.WriteLine(thirdDigit);
            }


            int a = int.Parse(Console.ReadLine());

            switch (a % 2)
            {
                case 0:
                    Console.WriteLine("четное");
                    break;
                default:
                    Console.WriteLine("нечетное");
                    break;
            }

            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(a < 100 ? "меньше 100" : "больше 100");
            Console.ReadKey();
        }
    }
}
