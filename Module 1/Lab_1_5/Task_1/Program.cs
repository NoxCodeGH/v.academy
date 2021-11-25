namespace Task_1 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int maxCountObject = 5;
            int interTimer = 5000;

            CacheControl cacheControl = new(maxCountObject);

            List<CacheObject> listCacheObject = new()
            {
                new CacheObject("Кэш 1", interTimer),
                new CacheObject("Кэш 2", interTimer),
                new CacheObject("Кэш 3", interTimer),
                new CacheObject("Кэш 4", interTimer),
                new CacheObject("Кэш 5", interTimer)
            };            

            foreach (var item in listCacheObject)
            {
                Console.WriteLine($"{DateTime.Now.ToLongTimeString()} Добавление объекта: {item.Name}");
                item.EvDispose += DoDisposeCacheObject;
                cacheControl.Add(item);                
            }

            Console.WriteLine("-");

            CacheObject cacheObject_6 = new CacheObject("Кэш 6", interTimer);
            Console.WriteLine($"{DateTime.Now.ToLongTimeString()} Добавление объекта: {cacheObject_6.Name}");
            cacheObject_6.EvDispose += DoDisposeCacheObject;
            cacheControl.Add(cacheObject_6);

            Console.WriteLine("-");
            Console.WriteLine($"{DateTime.Now.ToLongTimeString()} Ожидание в 3 секунды");
            Task.Delay(3000).Wait();
            Console.WriteLine($"{DateTime.Now.ToLongTimeString()} Ожидание завершено");            

            Console.WriteLine("-");
            Console.WriteLine($"{DateTime.Now.ToLongTimeString()} Вызов объекта: {listCacheObject[2].Name}");
            listCacheObject[2].Call();

            Console.ReadKey();
        }

        private static void DoDisposeCacheObject(CacheObject cacheObject)
        {
            Console.WriteLine($"{DateTime.Now.ToLongTimeString()} Уничтожение объекта: {cacheObject.Name}");
        }
    }
}