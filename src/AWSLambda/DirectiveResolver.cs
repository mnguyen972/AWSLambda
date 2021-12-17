using AWSLambda.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AWSLambda
{
    public class DirectiveResolver : IDirectiveResolver
    {
        private readonly IEnumerable<IDirective> _directives;

        public DirectiveResolver(IEnumerable<IDirective> directives)
        {
            _directives = directives;
        }

        public IDirective Resolve(string nameSpace, string name)
        {
            IDirective directive = _directives.FirstOrDefault(item => item.NameSpace == nameSpace && item.Name == name);
            if (directive == null)
            {
                throw new Exception($"Directive with namespace {nameSpace} and name {name} not found");
            }

            return directive;
        }
    }

}
