using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharpTestsEx;
using Rebus.Config;
using Rebus.Sagas;
using Rebus.Handlers;
using System.Threading.Tasks;
using Rebus.Bus;
using Moq;

namespace Memento.Messaging.Rebus.Tests
{
    [TestClass]
    public class RebusEventDispatcherFixture
    {
        [TestMethod]
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
