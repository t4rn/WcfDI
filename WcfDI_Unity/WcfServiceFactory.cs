using Microsoft.Practices.Unity;
using Unity.Wcf;
using WcfDI.Infrastructure;
using WcfDI.Infrastructure.WcfContracts;

namespace WcfDI_Unity
{
    public class WcfServiceFactory : UnityServiceHostFactory
    {
        protected override void ConfigureContainer(IUnityContainer container)
        {
            container
                .RegisterType<ITestService, TestService>()
                .RegisterType<IValueService, ValueService>()
                .RegisterType<IRepository, LocalRepository>(new InjectionConstructor(Properties.Settings.Default.ConnectionString))
                ;
        }
    }
}