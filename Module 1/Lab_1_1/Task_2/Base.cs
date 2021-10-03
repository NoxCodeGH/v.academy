using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public struct A
    {
        public string GetText()
        {
            return "text class A";
        }
    }

    public struct B
    {
        public readonly A _a;

        public B(A a)
        {
            _a = a;
        }

        public string GetText()
        {
            // return "text class B";
            return _a.GetText();    // Вызов метода "GetText()" структуры A
        }
    }
}
