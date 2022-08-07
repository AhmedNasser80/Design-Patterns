using System;
using System.Collections.Generic;

namespace Game_Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Football FB = new Football(new Position(0, 1, 2));
            FB.Attach(new Player("Ahmed"));
            FB.Attach(new Player("Messi"));

            FB.SetBallPosition(new Position(3, 5, 6));
            FB.Notify();

            Console.ReadKey();
        }
    }
}
