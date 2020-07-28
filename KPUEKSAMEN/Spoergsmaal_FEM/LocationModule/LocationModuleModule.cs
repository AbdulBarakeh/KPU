using LocationModule.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace LocationModule
{
    public class LocationModuleModule : IModule
    {
        private IRegionManager regionManager;

        public LocationModuleModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }
        public void OnInitialized(IContainerProvider containerProvider)
        {
            this.regionManager.RegisterViewWithRegion("SecondRegion", typeof(LocationView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<ILocation, Location>();
            containerRegistry.Register<ICustomerStore, DbCustomerStore>();

        }
    }
}