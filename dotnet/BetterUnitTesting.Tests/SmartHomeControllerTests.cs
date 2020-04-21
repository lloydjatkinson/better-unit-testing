using System;

using BetterUnitTesting.SmartHome.Abstractions;
using BetterUnitTesting.SmartHome.After;
using BetterUnitTesting.SmartHome.Before;
using BetterUnitTesting.Tests.Generators;
using FsCheck.Xunit;
using NSubstitute;

using Xunit;

namespace BetterUnitTesting.Tests
{
    public class SmartHomeControllerTestsIterationOne
    {
        [Fact]
        public void ShouldTurnOnLightWhenOnButtonPressed()
        {
            var controller = new SmartHomeController();

            controller.Tick(new Trigger(TriggerType.OnButtonPressed));

            // How do we check if the light was turned on? The SUT is untestable.
        }

        [Fact]
        public void ShouldTurnOnLightWhenOffButtonPressed()
        {
            var controller = new SmartHomeController();

            controller.Tick(new Trigger(TriggerType.OffButtonPressed));

            // How do we check if the light was turned on? The SUT is untestable.
        }

        [Fact]
        public void ShouldTurnOnLightWhenMotionIsDetectedAtNight()
        {
            var controller = new SmartHomeController();

            controller.Tick(new Trigger(TriggerType.OnButtonPressed));

            // How do we check if the light was turned on? The SUT is untestable.
            // Furthermore, even if we had a way of checking the light... the test has to be run at night.
        }

        [Fact]
        public void ShouldTurnOnLightWhenDoorIsOpenedInEvening()
        {
            var controller = new SmartHomeController();

            controller.Tick(new Trigger(TriggerType.OnButtonPressed));

            // How do we check if the light was turned on? The SUT is untestable.
            // Furthermore, even if we had a way of checking the light... the test has to be run in the evening.
        }
    }

    public class SmartHomeControllerTestsIterationTwo
    {
        public static TheoryData<DateTime> NightTimes =>
            new TheoryData<DateTime>
            {
                { new DateTime(2020, 1, 1, 1, 0, 0) },
                { new DateTime(2020, 1, 1, 2, 0, 0) },
                { new DateTime(2020, 1, 1, 3, 0, 0) },
                { new DateTime(2020, 1, 1, 4, 0, 0) },
                { new DateTime(2020, 1, 1, 5, 0, 0) },
            };

        [Fact]
        public void ShouldTurnOnLightWhenOnButtonPressed()
        {
            var light = Substitute.For<ILight>();
            var dateTime = Substitute.For<IDateTime>();
            var controller = new BetterSmartHomeController(dateTime, light);

            controller.Tick(new Trigger(TriggerType.OnButtonPressed));

            light.Received(1).Set(true);
        }

        [Fact]
        public void ShouldTurnOnLightWhenOffButtonPressed()
        {
            var light = Substitute.For<ILight>();
            var dateTime = Substitute.For<IDateTime>();
            var controller = new BetterSmartHomeController(dateTime, light);

            controller.Tick(new Trigger(TriggerType.OffButtonPressed));

            light.Received(1).Set(false);
        }

        [Theory]
        [MemberData(nameof(NightTimes))]
        public void ShouldTurnOnLightWhenMotionIsDetectedAtNight(DateTime date)
        {
            var light = Substitute.For<ILight>();
            var dateTime = Substitute.For<IDateTime>();
            dateTime.Now.Returns(date);

            var controller = new BetterSmartHomeController(dateTime, light);

            controller.Tick(new Trigger(TriggerType.MotionDetected));

            light.Received(1).Set(true);
        }
    }

    //[Properties(Arbitrary = new[] { typeof(NightTimeGenerator) })]
    //public class SmartHomeControllerTestsIterationThree
    //{
    //    [Property]
    //    public void ShouldTurnOnLightWhenMotionIsDetectedAtNight2(DateTime date)
    //    {
    //        var light = Substitute.For<ILight>();
    //        var dateTime = Substitute.For<IDateTime>();
    //        dateTime.Now.Returns(date);

    //        var controller = new BetterSmartHomeController(dateTime, light);

    //        controller.Tick(new Trigger(TriggerType.MotionDetected));

    //        light.Received(1).Set(true);
    //    }
    //}
}