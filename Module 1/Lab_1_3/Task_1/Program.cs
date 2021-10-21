using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_1
{
    class Person
    {
        public int Age;
        public string Name;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Инициализация списка с объектами Person
            List<Person> persons = new()
            {
                new Person { Age = 25, Name = "Александр" },
                new Person { Age = 27, Name = "Андрей" },
                new Person { Age = 20, Name = "Евгений" },
                new Person { Age = 32, Name = "Михаил" },
                new Person { Age = 23, Name = "Кирилл" },
                new Person { Age = 35, Name = "Дмитрий" }
            };

            // Сортировка списка
            var sortPerson = persons
                .Skip(3)                            // Выборка трёх элементов списка
                .Select(element => element.Name)    // Выбор имени у элемента списка
                .ToArray();                         // Преобразование в массив имён

            char delimeter = ',';
            string result = string.Join(delimeter, sortPerson); // Перечисление имён с разделителем
            Console.Write(result);

            Console.ReadKey();
        }
    }
}
