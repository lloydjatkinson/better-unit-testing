using System;

using BetterUnitTesting.SmartHome.Abstractions;

namespace BetterUnitTesting.SmartHome.Before
{
    public sealed class SmartHomeController : ISmartHomeController
    {
        public void Tick(Trigger trigger)
        {
            var now = CommonTime.GetTimeOfDay(DateTime.Now);
            var light = new Light();

            if (trigger.TriggerType == TriggerType.OnButtonPressed)
            {
                light.Set(true);
            }

            if (now == CommonTimes.Morning)
            {
                if (trigger.TriggerType == TriggerType.DoorOpened)
                {
                    light.Set(true);
                }
            }

            if (now == CommonTimes.Evening)
            {
                if (trigger.TriggerType == TriggerType.DoorOpened)
                {
                    light.Set(true);
                }
                else if (trigger.TriggerType == TriggerType.DoorClosed)
                {
                    light.Set(true);
                }
            }

            if (now == CommonTimes.Night)
            {
                if (trigger.TriggerType == TriggerType.MotionDetected)
                {
                    light.Set(true);
                }
            }
        }
    }
}