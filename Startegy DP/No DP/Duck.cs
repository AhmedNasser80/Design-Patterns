using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Startegy_DP.No_DP
{
    abstract class Duck
    {
        public abstract void Display();

        public void Swim() =>
            Console.WriteLine("Swimming");

        public void Quack()
        {
            Console.WriteLine("Quacking");
            Console.Beep();
        }

        public void Fly() =>
            Console.WriteLine("Fly With Normal Speed");
    }
}
