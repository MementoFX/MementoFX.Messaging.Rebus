using Rebus.Bus;
using System;

namespace Memento.Messaging.Rebus
{
    /// <summary>
    /// Provides the implementation a Memento event dispatcher
    /// based upon Rebus
    /// </summary>
    public class RebusEventDispatcher : IEventDispatcher
    {
        /// <summary>
        /// Gets or sets the reference to the bus instance
        /// used by the dispatcher
        /// </summary>
        protected IBus Bus { get; private set; }

        /// <summary>
        /// Creates an instance of the event dispatcher
        /// </summary>
        /// <param name="bus"></param>
        public RebusEventDispatcher(IBus bus)
        {
            if (bus == null)
                throw new ArgumentNullException("bus");

            Bus = bus;
        }

        /// <summary>
        /// Dispatches an event
        /// </summary>
        /// <typeparam name="T">The type of the event</typeparam>
        /// <param name="event">The event to dispatch</param>
        public void Dispatch<T>(T @event) where T : DomainEvent
        {
            if (@event == null)
                throw new ArgumentNullException(nameof(@event));

            Bus.Publish(@event).Wait();
        }
    }
}
