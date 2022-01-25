using System;
using RPG_POO.src.Entities;

namespace RPG_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", "Knight");
            Wizard jenica = new Wizard("Jenica", "White Wizard");
            Ninja wedge = new Ninja("Wedge", "Ninja");
            Enemy kingMummy = new Enemy("King Mummy", "Zumbi");

            Console.WriteLine(kingMummy.Attack());
            Console.WriteLine(arus.Attack());
            Console.WriteLine(jenica.Attack());
        }
    }
}
