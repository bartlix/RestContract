using System;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace Codeworx.Rest.UnitTests.TestServerUtilities
{
    public class CustomStringOutputFormatter : StringOutputFormatter
    {
        protected override bool CanWriteType(Type type)
        {
            if (type == typeof(string))
            {
                // Call into base to check if the current request's content type is a supported media type.
                return base.CanWriteType(type);
            }

            return false;
        }
    }
}