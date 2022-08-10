using System;

namespace Flyweight_DP
{
    public interface IDiscountCalaculator
    {
       double GetDiscountValue(DateTime currentDate, string itemId=null);
    }
}