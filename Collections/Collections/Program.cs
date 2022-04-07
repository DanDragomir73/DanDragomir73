using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var Names = new List<string>();
            Names.Add("Joe");
            Names.Add("Bob");
            Names.Add("Jack");
            Names.Add("Steve");
            foreach (var name in Names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("--------------------");
            var Numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach(var num in Numbers)
            {
                if(num%2 == 0)
                    Console.WriteLine(num);
                    Console.ReadLine();
            }
            Console.ReadLine();     
        }
    }
}