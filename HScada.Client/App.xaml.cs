
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using Prism.Unity;
using System.ComponentModel;
using System.Windows;
using System.Windows.Navigation;
using HScada.SystemElement.Contract;

namespace Client
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : PrismApplication
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            App.Current.ShutdownMode = System.Windows.ShutdownMode.OnExplicitShutdown;
            DispatcherUnhandledException += (sender, ex) =>
            {
                MessageBox.Show(ex.Exception.ToString());
                ex.Handled = true;
            };
            HScada.PLCModule.PlcModule.StaticCtorMotherd();
            base.OnStartup(e);


        }
        protected override Window CreateShell()
        {
            Shell shell = Container.Resolve<Shell>();
            return shell;
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IMessagebox, HScada.SystemElement.Messagebox>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<HScada.Services.Module_ServicesModule>();
            moduleCatalog.AddModule<HScada.SystemElement.SystemModuleModule>();
            moduleCatalog.AddModule<HScada.PLCModule.PlcModule>();
            moduleCatalog.AddModule<Module1.Module1Module>();
        }



    }
}
