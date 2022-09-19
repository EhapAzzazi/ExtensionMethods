using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    /// <summary>
    /// You cannot modify the documented struct DateTime or any other documented class etc.. 
    ///  but u can add ur own methods or modification to it
    ///  using Extension by adding 'this' before the type "bets data" like (this DateTime value)
    ///   considering that class and methods have to be static.
    ///   /// </summary>
    static class DateTimeExtension
    {
        public static bool IsWeekEnd(this DateTime value) => value.DayOfWeek == DayOfWeek.Saturday || value.DayOfWeek == DayOfWeek.Friday;
        public static bool IsWeekDay(this DateTime value) => !IsWeekEnd(value);
    }
}
