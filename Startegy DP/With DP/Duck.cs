using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Startegy_DP.With_DP
{
    abstract class Duck
    {
        // 1. Composition Better Than Inheritance
        // 2. Develop Against Abstraction (IFly) Not Concrete Implementation (NormalFly, No Fly, ...)
        public IFly FlyBehavoiur { get; set; }
        public IQuack QuackBehaviour { get; set; }


        // 3. Delegation
        public void Fly()
        {
            FlyBehavoiur.PerformFly();
        }
        public void Quack()
        {
            QuackBehaviour.PerformQuack();
        }


        public Duck(IFly InitialFlyBehaviour, IQuack InitialQuackBehaviour)
        {
            FlyBehavoiur = InitialFlyBehaviour;
            QuackBehaviour = InitialQuackBehaviour;
        }



        public abstract void Display();
        public void Swim()
            => Console.WriteLine("Swimming");
    }
}
