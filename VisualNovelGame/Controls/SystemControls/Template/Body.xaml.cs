using Prism.Commands;
using Prism.Events;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
using VisualNovelGame.Events;
using VisualNovelGame.Events.EventArgs;
using VisualNovelGame.Models;
using VisualNovelGame.Services;
using VisualNovelGame.Services.Interfaces;
using VisualNovelGame.ViewModels;

namespace VisualNovelGame.Controls.SystemControls.Template
{
    /// <summary>
    /// Body.xaml 的交互逻辑
    /// </summary>
    public partial class Body : UserControl,IRegionMemberLifetime
    {
        public bool KeepAlive => true;

        private readonly IEventAggregator _eventAggregator;
        private readonly IWindowSizeService _windowSizeSerivce;
        


        // 构造函数
        public Body(BodyViewModel bodyViewModel, IWindowSizeService windowSizeService, IRegionManager regionManager)
        {
            InitializeComponent();
            _windowSizeSerivce = windowSizeService;
            DataContext = bodyViewModel;


        }

        private void UserControl_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (Application.Current.MainWindow.WindowState == WindowState.Maximized)
            {
                return;
            }
            double width = Application.Current.MainWindow.Width;
            double height = Application.Current.MainWindow.Height;
            _windowSizeSerivce.SaveWindowSizeToSystemSettings(new WindowSizeArgs(false, width, height));
        }

    }
}
