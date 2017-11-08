using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Frontend.FrontendTest
{
    public class RestGreeterShould
    {
        private readonly TestServer Server;
        private readonly HttpClient Client;

        public RestGreeterShould()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task ReturnOkStatus()
        {
            var response = await Client.GetAsync("rest/greeter/hellaaoouu");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ReturnGreeter()
        {
            var response = await Client.GetAsync("greeter?name=Petike&title=student");

            var responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"welcome_message\":\"Oh, hi there Petike, my dear student!\"}", responseJson);
        }

        [Fact]
        public async Task ReturnWOName()
        {
            var response = await Client.GetAsync("greeter?title=student");

            var responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"error\":\"Please provide a name!\"}", responseJson);
        }

        [Fact]
        public async Task ReturnWOTitle()
        {
            var response = await Client.GetAsync("greeter?name=Petike");

            var responseJson = await response.Content.ReadAsStringAsync();

            Assert.Equal("{\"error\":\"Please provide a title!\"}", responseJson);
        }
    }
}
