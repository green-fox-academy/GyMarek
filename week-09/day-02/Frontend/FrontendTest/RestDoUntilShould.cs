using Frontend.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;


namespace Frontend.FrontendTest
{
    public class RestDoUntilShould
    {
        private readonly TestServer Server;
        private readonly HttpClient Client;

        public RestDoUntilShould()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task ReturnOkStatus()
        {
            var response = await Client.GetAsync("rest/dountil/hellaaoouu");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task WithoutWhat()
        {
            var usedUntil = new DoU
            {
                Until = 5,
            };
            var convertedUsedUntil = JsonConvert.SerializeObject(usedUntil);
            var data = new StringContent(convertedUsedUntil.ToString(),
                         encoding: Encoding.UTF8,
                         mediaType: "application/json");

            var response = await Client.PostAsync("dountil", data);

            var responseString = await response.Content.ReadAsStringAsync();

            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }

        [Fact]
        public async Task InputNullSum()
        {
            var data = new StringContent(content: "",
                         encoding: Encoding.UTF8,
                         mediaType: "application/json");

            var response = await Client.PostAsync("dountil/sum", data);

            var responseString = await response.Content.ReadAsStringAsync();

            string error = "{\"error\":\"Please provide a number!\"}";

            Assert.Equal(error, responseString);
        }

        [Fact]
        public async Task InputNullFactor()
        {
            var data = new StringContent(content: "",
                         encoding: Encoding.UTF8,
                         mediaType: "application/json");

            var response = await Client.PostAsync("dountil/factor", data);

            var responseString = await response.Content.ReadAsStringAsync();

            string error = "{\"error\":\"Please provide a number!\"}";

            Assert.Equal(error, responseString);
        }

        [Fact]
        public async Task ReturnResult15WhenSum5()
        {
            var usedUntil = new DoU
            {
                Until = 5,
            };
            var convertedUsedUntil = JsonConvert.SerializeObject(usedUntil);
            var data = new StringContent(convertedUsedUntil.ToString(),
                         encoding: Encoding.UTF8,
                         mediaType: "application/json");

            var response = await Client.PostAsync("dountil/sum", data);

            var responseString = await response.Content.ReadAsStringAsync();

            string result = "{\"result\":\"15\"}";

            Assert.Equal(result, responseString);
        }

        [Fact]
        public async Task ReturnResult120WhenFactor5()
        {
            var usedUntil = new DoU
            {
                Until = 5,
            };
            var convertedUsedUntil = JsonConvert.SerializeObject(usedUntil);
            var data = new StringContent(convertedUsedUntil.ToString(),
                         encoding: Encoding.UTF8,
                         mediaType: "application/json");

            var response = await Client.PostAsync("dountil/factor", data);

            var responseString = await response.Content.ReadAsStringAsync();

            string result = "{\"result\":\"120\"}";

            Assert.Equal(result, responseString);
        }
    }
}
