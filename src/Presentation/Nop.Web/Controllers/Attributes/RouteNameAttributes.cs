using System;

namespace Nop.Web.Controllers
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class RouteNameAttribute : Attribute
    {
        public string Name { get; }

        public RouteNameAttribute(string name)
        {
            Name = name;
        }
    }
}