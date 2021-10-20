using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "", b = "", c = "";

            Console.WriteLine("Quel est votre prénom ?");
            a = (Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Quel est votre nom ?");
            b =(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Quel est votre age ?");
            c =(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"Bonjour je m'appelle {a} {b}, j'ai {c} ans");
            Console.ReadLine();



        }
    }
}
