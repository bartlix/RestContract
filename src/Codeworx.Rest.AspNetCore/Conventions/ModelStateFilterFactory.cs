using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Codeworx.Rest.AspNetCore.Conventions
{
    internal class ModelStateFilterFactory : IFilterFactory
    {
        public bool IsReusable => true;

        public IFilterMetadata CreateInstance(IServiceProvider serviceProvider)
        {
            var options = serviceProvider.GetRequiredService<IOptions<ApiBehaviorOptions>>();
            var loggerFactory = serviceProvider.GetRequiredService<ILoggerFactory>();

            return new ModelStateInvalidFilter(options.Value, loggerFactory.CreateLogger<ModelStateInvalidFilter>());
        }
    }
}