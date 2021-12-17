namespace AWSLambda.Interfaces
{
    public interface IDirectiveResolver
    {
        IDirective Resolve(string nameSpace, string name);
    }
}
