using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Person
    {
        private readonly string _name;
        private readonly int _age;

        public string Name
        {
            get { return _name; }
        }

        public Person SetName(string value)
        {
            return new Person(value, _age);
        }

        public int Age
        {
            get { return _age; }
        }

        public Person SetAge(int value)
        {
            return new Person(_name, value);
        }

        public Person(string name, int age)
        {
            _name = name;
            _age = age;
        }
    }
}
