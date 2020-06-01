using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace PracticeCodeBlog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowPosition(2, 2);
            Console.SetWindowSize(200, 75);
            Console.ForegroundColor = ConsoleColor.Cyan;
            string word1 = "Wake up, Neo...";
            foreach (char letter in word1)
            {
                Console.Write(letter);
                Thread.Sleep(100);
            }
            Thread.Sleep(3000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            string word2 = "The Matrix has you...";
            foreach (char letter in word2)
            {
                Console.Write(letter);
                Thread.Sleep(100);
            }
            Thread.Sleep(3000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            string word3 = "Follow the white rabbit.";
            foreach (char letter in word3)
            {
                Console.Write(letter);
                Thread.Sleep(100);
            }
            Thread.Sleep(3000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            string word4 = "Knock, knock, Neo.";
            foreach (char letter in word4)
            {
                Console.Write(letter);
                Thread.Sleep(100);
            }
            Thread.Sleep(4000);



            //Console.ReadKey();

        }
    }
}
