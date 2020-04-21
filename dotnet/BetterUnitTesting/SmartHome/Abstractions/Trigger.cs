namespace BetterUnitTesting.SmartHome.Abstractions
{
    public sealed class Trigger
    {
        public TriggerType TriggerType { get; }

        public Trigger(TriggerType triggerType)
        {
            TriggerType = triggerType;
        }
    }
}
