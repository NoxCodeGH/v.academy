using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Subscriber : IDisposable
    {
        private readonly EventBus<CustomArgs> _eventBus;
        private readonly string _name;

        public Subscriber(EventBus<CustomArgs> eventBus, string name)
        {
            _eventBus = eventBus;
            _name = name;

            _eventBus.Subscribe(OnEvent);
        }

        public void Dispose() 
        {
            _eventBus.Unsubscribe(OnEvent);
        }

        void OnEvent(object sender, CustomArgs e)
        {
            Console.WriteLine("{0} подписан на {1} через EventBus. Код события: {2}", 
                _name, e.NamePublisher, e.CodeEvent);
        }
    }
}
