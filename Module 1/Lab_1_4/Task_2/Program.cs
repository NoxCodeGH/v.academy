using System;
using System.Runtime.ExceptionServices;
using System.Reflection;

namespace Task_2
{
    class Program
    {
        static ExceptionDispatchInfo exceptionDispatchInfo;

        static void Main(string[] args)
        {
            try
            {
                int a = 1;
                int b = 0;
                Console.WriteLine($"Выражение: result = {a}/{b}");

                int result = a / b;
                Console.WriteLine($"result = {result}");
            }
            catch (DivideByZeroException ex)
            {
                exceptionDispatchInfo = ExceptionDispatchInfo.Capture(ex);

                Console.WriteLine($"Регистрация исключения в методе: {MethodBase.GetCurrentMethod().Name}");
                Console.WriteLine($"Исключение: {ex.Message}");
            }
            finally
            {
                Console.WriteLine();
                HandleException();

                Console.ReadKey();
            }                                   
        }

        static void HandleException()
        {
            try
            {
                if (exceptionDispatchInfo != null)
                    exceptionDispatchInfo.Throw();
            }
            catch
            {
                Console.WriteLine($"Вызов исключения в методе: {MethodBase.GetCurrentMethod().Name}");
                Console.WriteLine($"Исключение: {exceptionDispatchInfo.SourceException.Message}");
            }
        }
    }
}
