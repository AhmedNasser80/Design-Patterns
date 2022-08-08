using AbstractFactory_DP.Factories;
using AbstractFactory_DP.Product_Parts.Engine;
using AbstractFactory_DP.Product_Parts.FrontWing;
using AbstractFactory_DP.Product_Parts.GearBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_DP
{
    internal class F1Car
    {
        IEngine engine;
        IFrontWing frontWing;
        IGearBox gearBox;
        AbstractFactory factory;
        public F1Car(AbstractFactory factory)
        {
                this.factory = factory;
        }
        public void CreatCar()
        {
            engine = factory.GetEngine();
            frontWing = factory.GetFrontWing();
            gearBox = factory.GetGearBox();
            Console.WriteLine("Car is Created Successfully");
        }
    }
}
