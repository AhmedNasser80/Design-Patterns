
using System;

namespace Flyweight_DP
{
    public class DayDiscountCalc:IDiscountCalaculator
    {
       public double GetDiscountValue(DateTime currentDate, string itemId)
        {
          // call database to calc today discount
          return 0.15;
        }
    }
}