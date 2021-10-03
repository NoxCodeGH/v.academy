using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Publisher
    {
        private readonly ObjectEvent<CustomArgs> _objectEvent = new();

        private readonly  string _name;
        private readonly EventBus<CustomArgs> _eventBus;

        public Publisher(string name, EventBus<CustomArgs> eventBus)
        {
            _name = name;
            _eventBus = eventBus;

            _eventBus.Publish(_objectEvent);
        }

        public void DoEvent()
        {
            CustomArgs customArgs = new(_name, 1);

            _objectEvent.DoEvent(customArgs);
        }
    }
}
