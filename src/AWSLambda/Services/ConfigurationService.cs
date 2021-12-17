using AWSLambda.Interfaces;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace AWSLambda.Services
{
    /// <summary>
    /// Contain methods to support retrieval of configuration
    /// </summary>
    public class ConfigurationService : IConfigurationService
    {
        /// <summary>
        /// Returns the configuration variables
        /// </summary>
        /// <returns>Configuration object</returns>
        public IConfiguration GetConfiguration()
        {
            return new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: false)
                .AddEnvironmentVariables()
                .Build();
        }
    }
}
