using HScada.Services.Instance;
using HScada.Services.Contract;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace HScada.Services
{
    public class Module_ServicesModule : IModule
    {
        public void OnInitialized( IContainerProvider containerProvider)
        {
 
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<ILog, ConsolaLog>();
        }

        
    }
}