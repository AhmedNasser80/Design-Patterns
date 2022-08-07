using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletone_DP
{
    class GCard
    {
        public int Data { get; protected set; }

        // Constructor Must Be Private
        GCard(int _data)
        {
            this.Data = _data;
        }

        #region Version 03 [Using Static Readonly Property]
        //public static GCard SingletoneObj { get; } = new GCard(123456);
        #endregion

        //static GCard SingletoneObj; // Initialized With Default Value = Null

        #region Version 02 [Using Static Constructor]
        //static GCard()
        //{
        //    SingletoneObj = new GCard(123456);
        //}
        //public GCard GetCard(int data)
        //{
        //    return SingletoneObj;
        //} 
        #endregion

        #region Version 01
        //public GCard GetCard()
        //{
        //    if (SingletoneObj == null)
        //        SingletoneObj = new GCard(123456);
        //    return SingletoneObj;
        //} 
        #endregion
    }
}
