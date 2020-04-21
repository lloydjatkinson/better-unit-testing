using System;

namespace BetterUnitTesting.SmartHome.Abstractions
{
    public static class CommonTime
    {
        public static CommonTimes GetTimeOfDay(DateTime dateTime)
        {
            return dateTime switch
            {
                _ when (dateTime.Hour >= 0 && dateTime.Hour < 6) => CommonTimes.Night,
                _ when (dateTime.Hour >= 6 && dateTime.Hour < 12) => CommonTimes.Morning,
                _ when (dateTime.Hour >= 12 && dateTime.Hour < 18) => CommonTimes.Afternoon,
                _ => CommonTimes.Evening
            };
        }
    }
}
