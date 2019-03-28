using MvcDemo.DataAccess;
using Autofac;

namespace MvcDemo.Modules
{
    public class EFModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType(typeof(MvcDemoContext)).As(typeof(IContext)).InstancePerLifetimeScope();

        }

    }
}