using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_DP.Product_Parts.FrontWing
{
    internal interface IFrontWing
    {
        public int Count { get;}

    }
    class DesignA : IFrontWing
    {
        public int Count => 7;
    }
    class DesignB : IFrontWing
    {
        public int Count => 10;
    }
}
