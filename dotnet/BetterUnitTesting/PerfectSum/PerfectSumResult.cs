using System.Diagnostics;

namespace BetterUnitTesting.PerfectSum
{
    [DebuggerDisplay("{First} + {Second}")]
    public sealed class PerfectSumResult
    {
        public bool Solved { get; }

        public int First { get; }

        public int Second { get; }

        public PerfectSumResult(int first, int second)
        {
            First = first;
            Second = second;
        }

        public void Deconstruct(out int first, out int second)
        {
            first = First;
            second = Second;
        }
    }
}
