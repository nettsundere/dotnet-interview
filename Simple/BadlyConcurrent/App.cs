using System.Linq;

namespace BadlyConcurrent
{
    public class App
    {
        private static int[] _collection = {1, 3, 7, 10};
        public const int Expected = 21;
        
        public int Sum()
        {
            var acc = 0;
            _collection.AsParallel().ForAll(x => acc += x);
            return acc;
        }
    }
}