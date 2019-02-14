namespace portalManutencao.Infrastructure.Modules
{
    using Autofac;
    using System;

    public class WebApiModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //
            // Register all Types in portalManutencao.WebApi
            //

            Type startup = Type.GetType("portalManutencao.WebApi.Startup, portalManutencao.WebApi");

            builder.RegisterAssemblyTypes(startup.Assembly)
                .AsSelf()
                .InstancePerLifetimeScope();
        }
    }
}
