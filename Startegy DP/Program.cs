using Startegy_DP.With_DP;
using System;

namespace Startegy_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            MallardDuck MD = new MallardDuck();
            MD.Display();
            MD.Swim();
            MD.Quack();
            MD.Fly();
            Console.WriteLine("------");
            RubberDuck RD = new RubberDuck();
            RD.Display();
            RD.Swim();
            RD.Quack();
            RD.Fly();

            Console.WriteLine("Hunting Mode");
            MD.FlyBehavoiur = new RocketSpeedFly();
            MD.Fly();
        }
    }
}
