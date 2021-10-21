using System;
using System.Linq;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Это что же получается: ходишь, ходишь в школу, а потом бац - вторая смена";
            Console.WriteLine("Исходный текст:\n{0}", text);
            Console.WriteLine();

            // Разделение строки на слова по определённым символам исключая пустые строки (длинные пробелы)
            string[] textSplit = text.Split(new char[] { ' ', '.', ',', ':', ';', '?', '!', '-' }, 
                StringSplitOptions.RemoveEmptyEntries);

            var sortText = textSplit
                .Select(word => new { Name = word, Len = word.ToString().Length })  // Создание анонимного типа содержащего два поля: слово и его размер
                .GroupBy(obj => obj.Len)                                            // Группировка объектов по полю: длина
                .Select(group => (LenWordInGroup: group.Key, Objs: group.Select(obj => obj))) // Создание анонимного типа содержащего два поля: длина слова в группе и набор сгруппированных объектов
                .OrderByDescending(groupObj => groupObj.Objs.Count())               // Сортировка по количеству объектов в группе в порядке убывания
                .ThenByDescending(groupObj => groupObj.LenWordInGroup);             // Сортировка по длине слова в группе в порядке убывания

            int i = 0;
            foreach (var groupObj in sortText)
            {
                i++;
                Console.WriteLine("Группа: {0}. Длина: {1}. Количество: {2}.", 
                    i, groupObj.LenWordInGroup, groupObj.Objs.Count());

                foreach (var name in groupObj.Objs)
                    Console.WriteLine(name.Name);

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
