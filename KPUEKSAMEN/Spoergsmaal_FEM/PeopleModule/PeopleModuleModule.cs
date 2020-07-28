using PeopleModule.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace PeopleModule
{
    public class PeopleModuleModule : IModule
    {
        private IRegionManager regionManager;

        public PeopleModuleModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }
        public void OnInitialized(IContainerProvider containerProvider)
        {
            this.regionManager.RegisterViewWithRegion("ContentRegion",typeof(PeopleView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<ICustomerStore, DbCustomerStore>();

        }
    }
}