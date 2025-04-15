using System.Linq;
using System.Reflection;

using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace Codeworx.Rest.AspNetCore.Conventions
{
    public class ModelStateFilterConvention : IActionModelConvention
    {
        public void Apply(ActionModel action)
        {
            if (action.Controller.ControllerType.GetInterfaces().Any(p => p.GetCustomAttribute<RestRouteAttribute>() is not null))
            {
                action.Filters.Add(new ModelStateFilterFactory());
            }
        }
    }
}