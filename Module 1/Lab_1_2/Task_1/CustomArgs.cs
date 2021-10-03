using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class CustomArgs : EventArgs
    {
        public string NamePublisher { get; }
        public int CodeEvent { get; }

        public CustomArgs(string namePublisher, int codeEvent)
        {
            NamePublisher = namePublisher;
            CodeEvent = codeEvent;
        }
    }
}
