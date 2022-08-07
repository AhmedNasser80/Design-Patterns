using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Startegy_DP.With_DP
{
    interface IFly
    {
        void PerformFly();
    }
    class NormalSpeedFly : IFly
    {
        public void PerformFly()
            => Console.WriteLine("Fly Normal Speed");
    }
    class NoFly : IFly
    {
        public void PerformFly()
            => Console.WriteLine("No Wings To Fly");
    }

    // Open Closed Principle
    class RocketSpeedFly : IFly
    {
        public void PerformFly()
            => Console.WriteLine("Fly Rocket Speed");
    }
}
