using Autofac;
using Autofac.Configuration;
using Microsoft.Extensions.Configuration;
using Presenter;

namespace Configurator
{
    public static class AppConfigurator
    {
        public static void Run()
        {
            var container = GetDependencies();
            var presenter = container.Resolve<IPresenter>();
            presenter.Run();
        }

        private static IContainer GetDependencies()
        {
            var config = new ConfigurationBuilder();
            config.AddJsonFile("Autofac.json");

            var module = new ConfigurationModule(config.Build());
            var builder = new ContainerBuilder();
            builder.RegisterModule(module);
            return builder.Build();
        }
    }
}
