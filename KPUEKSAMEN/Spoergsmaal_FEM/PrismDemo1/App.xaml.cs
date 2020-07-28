using PrismDemo1.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;
using LocationModule;
using PeopleModule;
namespace PrismDemo1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        protected override IModuleCatalog CreateModuleCatalog()
        {
            //return new DirectoryModuleCatalog() { ModulePath = @"..\Modules\" };
            return base.CreateModuleCatalog();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<PeopleModuleModule>();
            moduleCatalog.AddModule<LocationModuleModule>();
        }
    }
}
