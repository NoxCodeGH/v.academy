using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "This dog eats too much vegetables after lunch";

            string [] textArr = text.Split(new char[] { ' ', '.', ',', ':', ';', '?', '!', '-' },   
                StringSplitOptions.RemoveEmptyEntries);     // Преобразование текста в массив по разделителю

            Dictionary<string, string> textTranslate = new(StringComparer.OrdinalIgnoreCase)    // Словарь переводов с игнорированием регистра
            {
                { "This", "Эта" },
                { "dog", "Собака" },
                { "eats", "Ест" },
                { "too", "Слишком" },
                { "much", "Много" },
                { "vegetables", "Овощей" },
                { "after", "После" },
                { "lunch", "Обеда" }
            };

            int idx = 0;
            int cntViewElement = 3;     // Количество выводимых слов
            string [][] sortText = textArr.
                Select(element => textTranslate.GetValueOrDefault(element, element)).   // Поиск значения в словаре
                Select(element => element.ToUpper()).                                   // Приведение слов к верхнему регистру
                GroupBy(element => idx++ / cntViewElement).                             // Групировка элементов по идексу
                Select(group => group.ToArray()).                                       // Представление группы элементов как массив
                ToArray();                                                              // Добавление массива в массив массивов

            foreach (var value in sortText)
                Console.WriteLine(string.Join(" ", value));     // Перебор элеметов массива с разделителем

            Console.ReadKey();
        }
    }
}
