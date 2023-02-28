using System;
using System.Linq;
using lab;

namespace Lab1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Repline;
            do
            {
                /*Console.WriteLine("input line");
                string line = Console.ReadLine();
                SClass test = new SClass(line);
                Console.WriteLine("String: " + test.ToString());
                Console.WriteLine("Sorted: " + test.sort());
                Console.WriteLine("Length: " + test.length());
                */
                task();
                Console.WriteLine("repeat?");
                Repline = Convert.ToInt32(Console.ReadLine());
            } while (Repline == 1);
        }
        static void task()
        {
            Console.WriteLine("input line");
            string line = Console.ReadLine();
            SClass test = new SClass(line);
            Console.WriteLine("String: " + test.ToString());
            Console.WriteLine("Sorted: " + test.sort());
            Console.WriteLine("Length: " + test.length());
        }
    }
}
