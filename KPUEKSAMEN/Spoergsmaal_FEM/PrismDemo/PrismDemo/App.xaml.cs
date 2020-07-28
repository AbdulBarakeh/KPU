using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Prism.Ioc;
using Prism.Unity;
using PrismDemo.Views;

namespace PrismDemo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            Views.MainWindow v = Container.Resolve<Views.MainWindow>();
            return v;
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<Models.ICustomerStore, Models.DbCustomerStore>();
        }
    }
}
