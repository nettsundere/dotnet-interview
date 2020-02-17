using System;
using System.Threading.Tasks;

namespace Runner
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await AsyncExample();

            ConcurrencyExample();
        }

        private static async Task AsyncExample()
        {
            var asyncApp = new Async.App();

            var resultWithoutAwait = await asyncApp.ComputeAsync();
            Console.WriteLine(resultWithoutAwait.StatusCode);

            var resultWithAwait = await asyncApp.AwaitComputeAsync();
            Console.WriteLine(resultWithAwait.StatusCode);
        }

        private static void ConcurrencyExample()
        {
            var concurrentApp = new BadlyConcurrent.App();

            var value = 0;
            var attempt = 0;
            do
            {
                attempt++;
                value = concurrentApp.Sum();
            } while (value == BadlyConcurrent.App.Expected);
            
            Console.WriteLine($"Computation failed on attempt #{attempt}");
        }
    }
}
