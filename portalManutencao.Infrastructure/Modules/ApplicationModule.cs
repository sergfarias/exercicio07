namespace portalManutencao.Infrastructure.Modules
{
    using Autofac;
    using portalManutencao.Application;

    public class ApplicationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //
            // Register all Types in portalManutencao.Application
            //
            builder.RegisterAssemblyTypes(typeof(ApplicationException).Assembly)
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();
        }
    }
}
