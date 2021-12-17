using Amazon.Lambda.Core;
using AWSLambda.Interfaces;
using AWSLambda.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AWSLambda.Directives
{
    public class Discovery : IDirective
    {
        public string NameSpace => "alexa.discovery";

        public string Name => "discover";

        private readonly IConfigurationService _configurationService;

        public Discovery(IConfigurationService configurationService)
        {
            _configurationService = configurationService;
        }

        public async Task<SmartHomeResponse> Process(dynamic request, ILambdaContext context)
        {
            var testUrl = _configurationService.GetConfiguration()["TestUrl"];

            return new SmartHomeResponse
            {
                Event = new Event
                {
                    Header = new Header
                    {
                        Namespace = "Alexa.Discovery",
                        Name = "Discover.Response",
                        MessageId = request.directive.header.messageId,
                        PayloadVersion = "3"
                    },
                    Payload = new Payload
                    {
                        Endpoints = new List<Endpoint>()
                    }
                }
            };
        }
    }
}
