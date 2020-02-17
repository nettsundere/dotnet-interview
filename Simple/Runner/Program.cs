using System;
using System.Threading.Tasks;

namespace Runner
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var asyncApp = new Async.App();

            var resultWithoutAwait = await asyncApp.ComputeAsync();
            Console.WriteLine(resultWithoutAwait.StatusCode);

            var resultWithAwait = await asyncApp.AwaitComputeAsync();
            Console.WriteLine(resultWithAwait.StatusCode);
        }
    }
}
