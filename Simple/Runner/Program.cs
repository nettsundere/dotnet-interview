using System;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace Runner
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await AsyncExample();
        }

        private static async Task AsyncExample()
        {
            var asyncApp = new Async.App();

            var resultWithoutAwait = await asyncApp.ComputeAsync();
            Console.WriteLine(resultWithoutAwait.StatusCode);

            var resultWithAwait = await asyncApp.AwaitComputeAsync();
            Console.WriteLine(resultWithAwait.StatusCode);
        }
    }
}
