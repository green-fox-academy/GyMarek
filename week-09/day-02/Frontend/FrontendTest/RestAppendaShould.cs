using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Frontend.FrontendTest
{
    public class RestAppendaShould
    {
        private readonly TestServer Server;
        private readonly HttpClient Client;

        public RestAppendaShould()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task ReturnOkStatus()
        {
            var response = await Client.GetAsync("rest/appenda/hellaaoouu");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ReturnAppenda()
        {
            var response = await Client.GetAsync("appenda/kuty");

            var responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"appended\":\"kutya\"}", responseJson);
        }

        [Fact]
        public async Task ReturnWOAppendable()
        {
            var response = await Client.GetAsync("appenda");            

            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }
    }
}
