using Prism.Events;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using Unity;
using VisualNovelGame.Controls;
using VisualNovelGame.ViewModels;
using static VisualNovelGame.Services.EventAggregatorService;

namespace VisualNovelGame.Views
{
    /// <summary>
    /// Index.xaml 的交互逻辑
    /// </summary>
    public partial class IndexView : UserControl, INavigationAware
    {
        private readonly IRegionManager _regionManager;
        // 音乐
        private MediaPlayer _player = new MediaPlayer();

        // 构造函数
        public IndexView(IRegionManager regionManager)
        {
            InitializeComponent();

            // 初始化首页音乐
            //InitializePlayer();
            _regionManager = regionManager;
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return false;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            _regionManager.Regions.Remove("SystemSettingsViewRegion");
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {

        }

        // 初始化音乐
        //private void InitializePlayer()
        //{
        //    _player.Open(new Uri("Music/BEYOND.mp3", UriKind.Relative));
        //    _player.Volume = 0.1;
        //    _player.Play();
        //}

    }
}
