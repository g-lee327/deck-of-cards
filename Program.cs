using System;
using System.Collections.Generic;

namespace WAR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets play WAR!");
            Player gina = new Player ("Gina");
            System.Console.WriteLine($"Welcome player {gina.Name}");
            Player brent = new Player ("Brent");
            System.Console.WriteLine($"Welcome player {brent.Name}");
            Deck newDeck = new Deck ();
            newDeck.shuffle();
            Da();

        }
    }
}
