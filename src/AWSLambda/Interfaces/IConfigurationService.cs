using Microsoft.Extensions.Configuration;

namespace AWSLambda.Interfaces
{
    /// <summary>
    /// Interface for configuration service
    /// </summary>
    public interface IConfigurationService
    {
        IConfiguration GetConfiguration();
    }
}
