using System;

namespace Traveltour.Data
{
    public static class DateTimeUtil 
    {
        public static bool IsEmpty(this DateTime dateTime)
        {
            return dateTime == default(DateTime);
        }
    }
}

