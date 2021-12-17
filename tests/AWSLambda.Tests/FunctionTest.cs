using Amazon.Lambda.TestUtilities;
using AWSLambda.Models;
using Newtonsoft.Json;
using System.IO;
using System.Threading.Tasks;
using Xunit;

namespace AWSLambda.Tests
{
    public class FunctionTest
    {
        [Fact]
        public async Task TestDiscovery()
        {
            var function = new Function();
            dynamic request = JsonConvert.DeserializeObject(File.ReadAllText(@".\TestJSONs\discovery.json"));
            SmartHomeResponse response = await function.FunctionHandler(request, new TestLambdaContext());

            Assert.Equal("Discover.Response", response.Event.Header.Name);
        }

    }
}
