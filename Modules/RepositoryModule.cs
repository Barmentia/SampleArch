using System.Reflection;
using Autofac;

namespace SampleArch.Modules
{
    public class RepositoryModule : Autofac.Module
    {
        /// <summary>
        /// It will register every class the ends with “Repository” in Autofac.
        /// </summary>
        /// <param name="builder"></param>
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(Assembly.Load("SampleArch.Repository"))
                   .Where(t => t.Name.EndsWith("Repository"))
                   .AsImplementedInterfaces()
                  .InstancePerLifetimeScope();
        }
    }
}