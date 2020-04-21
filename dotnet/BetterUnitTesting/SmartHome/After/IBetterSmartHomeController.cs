using BetterUnitTesting.SmartHome.Abstractions;

namespace BetterUnitTesting.SmartHome.After
{
    public interface IBetterSmartHomeController
    {
        void Tick(Trigger trigger);
    }
}