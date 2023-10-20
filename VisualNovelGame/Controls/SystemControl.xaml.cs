using Prism.Ioc;
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
using VisualNovelGame.Controls.SystemControls;
using VisualNovelGame.Controls.SystemControls.Template;
using VisualNovelGame.ViewModels.SystemControlViewModel;

namespace VisualNovelGame.Controls
{
    /// <summary>
    /// SystemControl.xaml 的交互逻辑
    /// </summary>
    public partial class SystemControl : UserControl, INavigationAware
    {
        private readonly IRegionManager _regionManager;

        // 构造函数
        public SystemControl(SystemControlViewModel systemControlViewModel, IRegionManager regionManager)
        {
            InitializeComponent();
            DataContext = systemControlViewModel;
            _regionManager = regionManager;
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return false;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {

        }


    }
}
