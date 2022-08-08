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
    abstract class AbstractFactory
    {
        public abstract IEngine GetEngine();
        public abstract IFrontWing GetFrontWing();

        public abstract IGearBox GetGearBox();

    }

}
