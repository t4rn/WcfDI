using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using WcfDI.Infrastructure;
using WcfDI.Infrastructure.WcfContracts;
using WcfDI_CastleWindsor.Properties;

namespace WcfDI_CastleWindsor.CastleWindsorInstaller
{
    public class WindsorInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component.For<ITestService, TestService>(),
                Component.For<IRepository, LocalRepository>().DependsOn(Dependency.OnValue("connectionString", Settings.Default.ConnectionString)),
                Component.For<IValueService, ValueService>());
        }
    }
}