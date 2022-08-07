using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_DP
{
    // Component
    abstract class Player
    {
        public string Name { get; set; }
        public abstract void PassBall(); 
    }
    // Concrete Component
    class FieldPlayer : Player
    {
        public override void PassBall()
            => Console.WriteLine("Pass Ball With Leg");
    }
    // Concrete Component
    class GoalKeepr : Player
    {
        public override void PassBall()
            => Console.WriteLine("Pass Ball With Leg Or Hand");
    }
}
