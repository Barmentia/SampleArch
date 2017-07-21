using System.Data.Entity;
using Autofac;
using SampleArch.Model;
using SampleArch.Repository;
using SampleArch.Repository.Interfaces;

namespace SampleArch.Modules
{
    public class EFModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule(new RepositoryModule());

            builder.RegisterType(typeof(SampleArchContext)).As(typeof(DbContext)).InstancePerLifetimeScope();
            builder.RegisterType(typeof(UnitOfWork)).As(typeof(IUnitOfWork)).InstancePerRequest();
        }
    }
}