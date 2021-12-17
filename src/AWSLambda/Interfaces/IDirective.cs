using Amazon.Lambda.Core;
using AWSLambda.Models;
using System.Threading.Tasks;

namespace AWSLambda.Interfaces
{
    public interface IDirective
    {
        string NameSpace { get; }
        string Name { get; }
        Task<SmartHomeResponse> Process(dynamic request, ILambdaContext context);
    }

}
