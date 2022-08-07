using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Startegy_DP.With_DP
{
    abstract class IQuack
    {
        public abstract void PerformQuack();
    }
    class NormalQuack : IQuack
    {
        public override void PerformQuack()
            => Console.WriteLine("Quaking");
    }
    class Sqeek : IQuack
    {
        public override void PerformQuack()
        {
            Console.WriteLine("Sqeek");
            Console.Beep();
        }
    }
}
