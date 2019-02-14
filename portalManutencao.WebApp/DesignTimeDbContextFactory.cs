using portalManutencao.Infrastructure.InMemoryDataAccess;
using Autofac;
using portalManutencao.Infrastructure;
namespace portalManutencao.WebApp
{
    public class DesignTimeDbContextFactory //: IDesignTimeDbContextFactory<Context>
    {
        public Context CreateDbContext(string[] args)
        {
            ContainerBuilder builder = new ContainerBuilder() ;
            builder.RegisterType<Context>()
                .As<Context>()
                .SingleInstance();

            // Register all Types in InMemoryDataAccess namespace
            //
            builder.RegisterAssemblyTypes(typeof(InfrastructureException).Assembly)
                .Where(type => type.Namespace.Contains("InMemoryDataAccess"))
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();

            return new Context();
        }
    }
}
