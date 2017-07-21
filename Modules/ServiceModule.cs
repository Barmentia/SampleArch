using System.Reflection;
using Autofac;

namespace SampleArch.Modules
{
    public class ServiceModule : Autofac.Module
    {
        /// <summary>
        /// It will register every class the ends with “Service” in Autofac.
        /// </summary>
        /// <param name="builder"></param>
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(Assembly.Load("SampleArch.Service"))
                      .Where(t => t.Name.EndsWith("Service"))
                      .AsImplementedInterfaces()
                      .InstancePerLifetimeScope();
        }
    }
}