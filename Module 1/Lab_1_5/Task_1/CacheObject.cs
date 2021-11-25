using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class CacheObject : IDisposable
    {
        private readonly Timer _timerAlive;

        public readonly string Name;
        public readonly int InterTimer;

        public event Action<CacheObject> EvDispose;

        public CacheObject(string name, int interTimer)
        {
            Name = name;
            InterTimer = interTimer;

            _timerAlive = new Timer(new TimerCallback(OnTimer), null, InterTimer, 0);
        }

        public void Dispose()
        {
            EvDispose?.Invoke(this);
            _timerAlive.Dispose();
        }

        private void OnTimer(object obj)
        {           
            Dispose();            
        }

        public void Call()
        {
            _timerAlive.Change(InterTimer, 0);
        }
    }
}
