using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Startegy_DP.With_DP
{
    class RubberDuck:Duck
    {
        public RubberDuck() : base(new NoFly(), new Sqeek())
        {

        }

        public override void Display()
            => Console.WriteLine("I am Rubber Duck");
    }
}
