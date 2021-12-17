using Amazon.Lambda.Core;
using AWSLambda.Extensions;
using AWSLambda.Interfaces;
using AWSLambda.Models;
using AWSLambda.Services;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace AWSLambda
{
    public class Function
    {
        private static ServiceProvider ServiceProvider { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public Function()
        {
            //set up DI
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            ServiceProvider = serviceCollection.BuildServiceProvider();
        }

        /// <summary>
        /// Configure services
        /// </summary>
        /// <param name="serviceCollection"></param>
        private void ConfigureServices(IServiceCollection serviceCollection)
        {
            //register services with DI system
            serviceCollection.AddTransient<IConfigurationService, ConfigurationService>();
            serviceCollection.AddSingleton<IDirectiveResolver, DirectiveResolver>();
            serviceCollection.RegisterAllTypes<IDirective>(new[] { typeof(Function).Assembly });
        }

        /// <summary>
        /// Entry point
        /// </summary>
        /// <param name="request"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public async Task<object> FunctionHandler(dynamic request, ILambdaContext context)
        {
            using var scope = ServiceProvider.CreateScope();
            var directiveResolver = scope.ServiceProvider.GetService<IDirectiveResolver>();

            SmartHomeResponse response = null;

            try
            {
                Console.WriteLine($"Request: {JsonConvert.SerializeObject(request)}");

                IDirective directive = directiveResolver.Resolve(((string)request.directive.header.@namespace)?.ToLower(), ((string)request.directive.header.name)?.ToLower());
                response = await directive.Process(request, context);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex}");
            }

            Console.WriteLine($"Response: {JsonConvert.SerializeObject(response)}");

            return response;

        }
    }
}
