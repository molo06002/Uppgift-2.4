// See https://aka.ms/new-console-template for more information
using System;
namespace Uppgift_2_4
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Skriv in lönen för medarbetare 1");
            string x = Console.ReadLine();
            int y = Convert.ToInt32(x);
            Console.WriteLine("Skriv in lönen för medarbetare 2");
            string k = Console.ReadLine();
            int o = Convert.ToInt32(k);
            Console.WriteLine("Skriv in lönen för medarbetare 3");
            string p = Console.ReadLine();
            int u = Convert.ToInt32(p);
            int t = y + o + u;
            int R = t / 3;
            Console.WriteLine("Medellönen för alla är: " + R);//
        }
    }
}