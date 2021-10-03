using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class ObjectEvent<T>
    {
        public event EventHandler<T> EvHandler;

        public void DoEvent(T eventArgs)
        {
            EvHandler?.Invoke(this, eventArgs);
        }
    }

    class EventBus<T>
    {
        private ObjectEvent<T> _objectEvent;

        public void Publish(ObjectEvent<T> objectEvent)
        {
            _objectEvent = objectEvent;
        }

        public void Subscribe(EventHandler<T> value)
        {
            _objectEvent.EvHandler += value;
        }

        public void Unsubscribe(EventHandler<T> value)
        {
            _objectEvent.EvHandler -= value;
        }
    }
}
