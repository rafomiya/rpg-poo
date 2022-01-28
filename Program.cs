using System;

namespace rpg_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Legend hattori = new Legend("Hattori", 100, 15, 42);
            Sourcerer queenNai = new Sourcerer("Queen Nai", 97, 15, 34);

            Console.WriteLine(hattori);
            Console.WriteLine(queenNai);

            hattori.Attack(queenNai);

            Console.WriteLine(hattori);
            Console.WriteLine(queenNai);

            Healer lucio = new Healer("Lucio", 100, 20, 42, 15);
            Console.WriteLine(lucio);

            lucio.Heal(queenNai);

            Console.WriteLine(queenNai);
        }
    }
}
