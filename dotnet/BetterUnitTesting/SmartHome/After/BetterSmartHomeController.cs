using System;

using BetterUnitTesting.SmartHome.Abstractions;

namespace BetterUnitTesting.SmartHome.After
{
    public sealed class BetterSmartHomeController : IBetterSmartHomeController
    {
        private readonly IDateTime _dateTime;
        private readonly ILight _light;

        public BetterSmartHomeController(IDateTime dateTime, ILight light)
        {
            _dateTime = dateTime ?? throw new ArgumentNullException(nameof(dateTime));
            _light = light ?? throw new ArgumentNullException(nameof(light));
        }

        public void Tick(Trigger trigger)
        {
            var now = CommonTime.GetTimeOfDay(_dateTime.Now);

            var onOrOff = (now, trigger.TriggerType) switch
            {
                (_, TriggerType.OnButtonPressed) => true,
                (_, TriggerType.OffButtonPressed) => false,
                (CommonTimes.Morning, TriggerType.DoorOpened) => true,
                (CommonTimes.Evening, TriggerType.DoorOpened) => true,
                (CommonTimes.Evening, TriggerType.DoorClosed) => false,
                (CommonTimes.Night, TriggerType.MotionDetected) => true,
                _ => false
            };

            _light.Set(onOrOff);
        }
    }
}