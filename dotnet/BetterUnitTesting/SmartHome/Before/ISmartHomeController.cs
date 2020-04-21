using BetterUnitTesting.SmartHome.Abstractions;

namespace BetterUnitTesting.SmartHome.Before
{
    public interface ISmartHomeController
    {
        void Tick(Trigger trigger);
    }
}