using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using VisualNovelGame.Controls;
using VisualNovelGame.Controls.SystemControls.Template;
using VisualNovelGame.Extensions;
using VisualNovelGame.ViewModels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace VisualNovelGame.Views
{
    /// <summary>
    /// SystemSettingsView.xaml 的交互逻辑
    /// </summary>
    public partial class SystemSettingsView : UserControl, INavigationAware
    {
        private readonly IRegionManager _regionManager;

        public SystemSettingsView(SystemSettingsViewModel systemSettingsViewModel, IRegionManager regionManager)
        {
            InitializeComponent();
            DataContext = systemSettingsViewModel;
            _regionManager = regionManager;
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return false;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            _regionManager.RemoveRegionsWithPrefix("SystemSettings_");
            _regionManager.Regions.Remove("SystemSettingsViewRegion");
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {

        }

    }
}
