using System;
using System.Globalization;
using System.Text;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Для отображения японских символов в консоли используется шрифт MS Gothic

            string textRu = "Привет мир!";
            Console.WriteLine($"Исходный текст En: {textRu}");            

            string textEn = "Hello World!";
            Console.WriteLine($"Исходный текст En: {textEn}");

            string textDe = "Hallo Welt!";
            Console.WriteLine($"Исходный текст De: {textDe}");

            string textJa = "こんにちは世界";
            Console.WriteLine($"Исходный текст Ja: {textJa}");            

            Console.WriteLine();

            byte[] bytesRu = Encoding.UTF8.GetBytes(textRu);
            Console.WriteLine($"Сериализация текста Ru: {BitConverter.ToString(bytesRu)}");

            byte[] bytesEn = Encoding.UTF8.GetBytes(textEn);
            Console.WriteLine($"Сериализация текста En: {BitConverter.ToString(bytesEn)}");

            byte[] bytesDe = Encoding.UTF8.GetBytes(textDe);
            Console.WriteLine($"Сериализация текста De: {BitConverter.ToString(bytesDe)}");

            byte[] bytesJa = Encoding.UTF8.GetBytes(textJa);
            Console.WriteLine($"Сериализация текста Ja: {BitConverter.ToString(bytesJa)}");

            Console.WriteLine();

            string resultRu = Encoding.UTF8.GetString(bytesRu);
            Console.WriteLine($"Десериализация массива байт Ru: {resultRu}");

            string resultEn = Encoding.UTF8.GetString(bytesEn);
            Console.WriteLine($"Десериализация массива байт En: {resultEn}");

            string resultDe = Encoding.UTF8.GetString(bytesDe);
            Console.WriteLine($"Десериализация массива байт De: {resultDe}");

            string resultJa = Encoding.UTF8.GetString(bytesJa);
            Console.WriteLine($"Десериализация массива байт Ja: {resultJa}");

            Console.ReadKey();
        }
    }
}
