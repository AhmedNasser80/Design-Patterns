using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_DP.Product_Parts.Engine
{
    internal interface IEngine
    {
        public int HoursePower { get;}
        public int MaxSpeed { get;}
    }
    class MercedesEngine : IEngine
    {
        public int HoursePower => 1000;

        public int MaxSpeed =>200;
    }
    class BMWEngine : IEngine
    {
        public int HoursePower => 1200;

        public int MaxSpeed => 300;
    }
}
