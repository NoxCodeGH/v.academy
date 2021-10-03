using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            EventBus<CustomArgs> eventBus = new();

            Publisher publisher = new("Publisher 1", eventBus);

            using (_ = new Subscriber(eventBus, "Subscriber 1"))
            using (_ = new Subscriber(eventBus, "Subscriber 2"))
            {
                publisher.DoEvent();
            }

            Console.ReadKey();
        }
    }
}
