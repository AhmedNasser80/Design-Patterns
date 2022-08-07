using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Startegy_DP.With_DP
{
    class MallardDuck : Duck
    {
        public MallardDuck():base(new NormalSpeedFly(), new NormalQuack())
        {

        }

        public override void Display()
            => Console.WriteLine("I am Mallard Duck");

    }
}
