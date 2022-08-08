using AbstractFactory_DP.Product_Parts.Engine;
using AbstractFactory_DP.Product_Parts.FrontWing;
using AbstractFactory_DP.Product_Parts.GearBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_DP.Factories
{
    internal class ConcFactory2:AbstractFactory
    {
        public override IEngine GetEngine()
          => new BMWEngine();

        public override IFrontWing GetFrontWing()
           => new DesignB();
        public override IGearBox GetGearBox()
          => new GearBoxY();
    }
}

