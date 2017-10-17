using System;
using SharpTestsEx;
using Xunit;

namespace MementoFX.Messaging.Rebus.Tests
{
    public class RebusEventDispatcherFixture
    {
        [Fact]
        public void Ctor_should_throw_ArgumentNullException_on_null_bus_and_value_of_parameter_should_be_bus()
        {
            Executing.This(() => new RebusEventDispatcher(null))
                .Should()
                .Throw<ArgumentNullException>()
                .And
                .ValueOf
                .ParamName
                .Should()
                .Be
                .EqualTo("bus");
        }

    }
}
