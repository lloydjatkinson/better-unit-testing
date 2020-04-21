using System;

namespace BetterUnitTesting.SmartHome.Abstractions
{
    public sealed class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}