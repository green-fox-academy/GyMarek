using Frontend;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Frintend.FrontendTest
{
    public class RestDoublingShould
    {
        private readonly TestServer Server;
        private readonly HttpClient Client;

        public RestDoublingShould()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task ReturnOkStatus()
        {
            var response = await Client.GetAsync("rest/doubling/hellaaoouu");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task Return30to15()
        {
            var response = await Client.GetAsync("doubling?input=15");

            var responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"received\":15,\"result\":30}", responseJson);
        }

        [Fact]
        public async Task NoInput()
        {
            var response = await Client.GetAsync("doubling");

            var responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"error\":\"Please provide an input!\"}", responseJson);
        }
    }
}
