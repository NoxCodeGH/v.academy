using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B(new A());
            Console.WriteLine("Вызов метода \"GetText()\" структуры B: " + b.GetText());

            Console.ReadKey();
        }
    }
}
