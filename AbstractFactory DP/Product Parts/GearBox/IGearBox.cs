using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_DP.Product_Parts.GearBox
{
    internal interface IGearBox
    {
        public int ShiftNum { get;}
        public bool IsAutomatic { get;}
    }
    class GearBoxX : IGearBox
    {
        public int ShiftNum => 5;

        public bool IsAutomatic => true;
    }
    class GearBoxY : IGearBox
    {
        public int ShiftNum =>6;

        public bool IsAutomatic => false;
    }
}
