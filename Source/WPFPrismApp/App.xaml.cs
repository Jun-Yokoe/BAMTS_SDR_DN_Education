using Prism.Ioc;
using Prism.Modularity;
using System.Windows;

namespace BAMTS.Internal
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
            containerRegistry.RegisterForNavigation<BAMTS.Internal.UCMSEmployeeList>();
            containerRegistry.RegisterForNavigation<BAMTS.Internal.UCGCEmployeeList>();
        }
    }
}
