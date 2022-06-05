using NUnit.Framework;
using RestSharp;
using System.Net;
using System.Threading.Tasks;

namespace RestSharpTests
{
    public class ApiGitHubTests
    {
        private RestClient client;

        [SetUp]
        public void Setup()
        {
            this.client = new RestClient("https://api.github.com/");
        }

        [Test]
        public async Task TestGitHubApiRequest()
        {
            var request = new RestRequest(
                "/repos/dimosoftuni/postman/issues");
            var response = await this.client.ExecuteAsync(request);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            
        }
    }
}