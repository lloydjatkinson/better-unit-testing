using System;
using System.Collections.Generic;

using FsCheck;

namespace BetterUnitTesting.Tests.Generators
{
    public static class NightTimeGenerator
    {
        private static Gen<DateTime> Generator
            => Arb.Default.DateTime().Filter((dateTime) => dateTime.Hour >= 0 && dateTime.Hour < 6).Generator;

        private static IEnumerable<DateTime> Shrinker(DateTime dateTime)
        {
            if (dateTime.Hour != 0)
            {
                //yield return new DateTime(dateTime.Hour, dateTime.Minute, dateTime.Second);
                yield return new DateTime(dateTime.Hour, dateTime.Minute, dateTime.Second).Subtract(TimeSpan.FromMinutes(1));
            }

            //if (dateTime.Minute != 0)
            //{
            //    yield return new DateTime(dateTime.Hour, dateTime.Minute - 1, dateTime.Second);
            //}

            //if (dateTime.Second != 0)
            //{
            //    yield return new DateTime(dateTime.Hour, dateTime.Minute, dateTime.Second - 1);
            //}

            
        }

        public static Arbitrary<DateTime> DateTime => Arb.From(Generator);
    }
}