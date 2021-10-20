using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gacdgaz
{
    class Program
    {
        static void Main(string[] args)
        {
            float a;//TVA
            float b;//prixHT

            Console.WriteLine("La TVA est de =");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Le prix HT est de =");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine($"Le prix TTC est {((a * b) / 100) + b}.");
            Console.ReadLine();
        }
    }
}
