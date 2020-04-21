using System;
using System.Collections.Generic;

using Optional;

namespace BetterUnitTesting.PerfectSum
{
    public static class PerfectSumSolver
    {
        public static Option<(int first, int second)> Solve(ISet<int> set, int sum)
        {
            if (set == null) throw new ArgumentNullException(nameof(set));

            foreach (var first in set)
            {
                foreach (var second in set)
                {
                    if (first + second == sum)
                    {
                        return Option.Some<(int, int)>((first, second));
                    }
                }
            }

            return Option.None<(int, int)>();
        }
    }
}