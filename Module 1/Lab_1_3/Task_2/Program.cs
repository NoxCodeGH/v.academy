using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Заполнение списка элементами
            List<string> numbers = new() { "Ноль", "Один", "Два", "Три", "Четыре", "Пять", "Шесть", "Семь", "Восемь"};

            var numbersSort = numbers
                .Where((name, index) => index < numbers[index].Length);  // Выбор элементов, у которых индекс меньше длины текста элемента

            foreach (var value in numbersSort)
                Console.WriteLine(value);

            Console.ReadKey();
        }
    }
}
