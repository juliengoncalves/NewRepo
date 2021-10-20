using System;

namespace Exercice_6
{
    class Program
    {
        static void Main(string[] args)
        {
            float moyenne;
            {
                Console.WriteLine("Quelle est ta moyenne ?");
                moyenne = float.Parse(Console.ReadLine());
                if (moyenne >= 16)
                    Console.WriteLine("Très bien");
                else (moyenne >= 14 && moyenne < 16);
                
                Console.WriteLine("Bien");
                {

                    if (moyenne >= 12 && moyenne < 14)
                        Console.WriteLine("Assez bien");

                    else (moyenne >= 10 && moyenne < 12);
                    Console.WriteLine("Passable");
                    {
                        if (moyenne > 10)
                        Console.WriteLine("Recalé");
                        Console.ReadLine();
                    }
                }
            }

        }
    }
}
