using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Person 1", 25);
            // person.Name = "Person 2"; // Вызовет ошибку компиляции
            // person.Age = 20;          // Вызовет ошибку компиляции

            Person person2 = person1.SetName("Person 2");    // Создаст новый объект с изменённым значением name
            Person person3 = person1.SetAge(20);             // Создаст новый объект с изменённым значением name

            Console.WriteLine("person1 - name: {0}, age: {1}", person1.Name, person1.Age);
            Console.WriteLine("person2 - name: {0}, age: {1}", person2.Name, person2.Age);
            Console.WriteLine("person3 - name: {0}, age: {1}", person3.Name, person3.Age);

            Console.ReadKey();
        }
    }
}
