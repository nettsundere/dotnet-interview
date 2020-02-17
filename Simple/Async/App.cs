using System.Net.Http;
using System.Threading.Tasks;

namespace Async
{
    public class App
    {
        private static readonly HttpClient Client = new HttpClient();
        
        private const string SomeSite = "https://example.com";
        
        public Task<HttpResponseMessage> ComputeAsync()
        {
            return Client.GetAsync(SomeSite);
        }

        public async Task<HttpResponseMessage> AwaitComputeAsync()
        {
            return await Client.GetAsync(SomeSite).ConfigureAwait(false);
        }
    }
}
