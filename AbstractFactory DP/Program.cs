using AbstractFactory_DP.Factories;
using System;

namespace AbstractFactory_DP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConcFactory1 factory = new ConcFactory1();
            F1Car car = new F1Car(factory);
            car.CreatCar();
        }
    }
}
