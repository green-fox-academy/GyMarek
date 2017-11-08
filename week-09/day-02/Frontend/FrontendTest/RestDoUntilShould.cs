using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Collections.Generic;
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
        public async Task InputNullOrEmptySum()
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
        public async Task InputNullOrEmptyFactor()
        {
            var data = new StringContent(content: "",
                         encoding: Encoding.UTF8,
                         mediaType: "application/json");

            var response = await Client.PostAsync("dountil/factor", data);

            var responseString = await response.Content.ReadAsStringAsync();

            string error = "{\"error\":\"Please provide a number!\"}";

            Assert.Equal(error, responseString);
        }

        
    }
}
