using System;
using System.Collections.Generic;

using BetterUnitTesting.PerfectSum;

using Shouldly;

using Xunit;

namespace BetterUnitTesting.Tests
{
    public class PerfectSumTests
    {
        [Fact]
        public void ShouldThrowArgumentNullExceptionWhenGivenNullSet()
        {
            Should.Throw<ArgumentNullException>(() => PerfectSumSolver.Solve(null, 0));
        }

        [Fact]
        public void ShouldFindNoSolutionsWithEmptySet()
        {
            var result = PerfectSumSolver.Solve(new HashSet<int>(), 0);

            result.HasValue.ShouldBe(false);
        }

        [Fact]
        public void ShouldFindSolutionForGivenSet()
        {
            var result = PerfectSumSolver.Solve(new HashSet<int>() { 1, 5, 20, 50, 100 }, 150);

            result.HasValue.ShouldBe(true);
            result.Contains((50, 100)).ShouldBe(true);
        }
    }
}