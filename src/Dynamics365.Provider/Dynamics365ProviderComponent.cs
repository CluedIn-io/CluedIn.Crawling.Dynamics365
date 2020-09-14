using Castle.MicroKernel.Registration;

using CluedIn.Core;
using CluedIn.Core.Providers;
using CluedIn.Core.Server;
// 
using CluedIn.Core.Webhooks;
// 
using CluedIn.Crawling.Dynamics365.Core;
using CluedIn.Crawling.Dynamics365.Infrastructure.Installers;
// 
using CluedIn.Provider.Dynamics365.WebApi;
// 
using ComponentHost;
using CluedIn.Core.Server;

namespace CluedIn.Provider.Dynamics365
{
    [Component(Dynamics365Constants.ProviderName, "Providers", ComponentType.Service, ServerComponents.ProviderWebApi, Components.Server, Components.DataStores, Isolation = ComponentIsolation.NotIsolated)]
    public sealed class Dynamics365ProviderComponent : ServiceApplicationComponent<IBusServer>
    {
        public Dynamics365ProviderComponent(ComponentInfo componentInfo)
            : base(componentInfo)
        {
            // Dev. Note: Potential for compiler warning here ... CA2214: Do not call overridable methods in constructors
            //   this class has been sealed to prevent the CA2214 waring being raised by the compiler
            Container.Register(Component.For<Dynamics365ProviderComponent>().Instance(this));
        }

        public override void Start()
        {
            Container.Install(new InstallComponents());
            var asm = System.Reflection.Assembly.GetExecutingAssembly();

            Container.Register(Types.FromAssembly(asm).BasedOn<IProvider>().WithServiceFromInterface().If(t => !t.IsAbstract).LifestyleSingleton());
            Container.Register(Types.FromAssembly(asm).BasedOn<IEntityActionBuilder>().WithServiceFromInterface().If(t => !t.IsAbstract).LifestyleSingleton());

            State = ServiceState.Started;
        }

        public override void Stop()
        {
            if (State == ServiceState.Stopped)
                return;

            State = ServiceState.Stopped;
        }
    }
}
