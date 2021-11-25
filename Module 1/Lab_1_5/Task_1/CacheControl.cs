using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class CacheControl
    {
        private readonly int _maxCountObject;
        private readonly List<CacheObject> _cacheBox = new();

        public CacheControl(int maxCountObject)
        {
            _maxCountObject = maxCountObject;            
        }

        public void Add(CacheObject obj)
        {
            if (_cacheBox.Count == _maxCountObject)
            {
                _cacheBox.First().Dispose();
                _cacheBox.RemoveAt(0);
            }

            obj.EvDispose += DoRemoveItemList;
            _cacheBox.Add(obj);
        }

        private void DoRemoveItemList(CacheObject obj)
        {
            _cacheBox.Remove(obj);
        }
    }
}
