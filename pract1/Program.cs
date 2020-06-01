using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создать коллекцию целых чисел (15 элементов)
            // заполнить данными от пользователя (с проверкой)
            // посчитать сумму всех элементов (for)
            // посчитать разность (while)
            // посчитать произведение (do while)
            // вывести коллекцию (foreach)


            var list = new List<int>();
            
            
                Console.WriteLine("Введите целочисленые элементы : ");
                for (int i = 0; i < 5; i++)
                {
                    try
                    {
                        list.Add(int.Parse(Console.ReadLine()));
                    }
                    catch(Exception)
                    {
                        Console.WriteLine("Неправильный ввод элемента!");
                        
                    }
                }
            foreach (int item in list)
            {
                Console.Write(" {0}", item);
            }

            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }
            Console.WriteLine("\n" + sum + "\n");

            int diff = list[0];
            int item1 = 0;
            while (item1 < list.Count - 1)
            {
                diff -= list[item1 + 1];
                item1++;
            }
            Console.WriteLine(diff);

            int mult = 1;
            int item2 = 0;
            do
            {
                mult *= list[item2];
                item2++;
            } while (item2 < list.Count);
            Console.WriteLine(mult);




            Console.ReadKey();
        }
    }
}
