using Prism.Events;
using Prism.Ioc;
using Prism.Regions;
using Prism.Unity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Interop;
using Unity;
using VisualNovelGame.Controls;
using VisualNovelGame.Controls.SystemControls;
using VisualNovelGame.Controls.SystemControls.Template;
using VisualNovelGame.Interfaces;
using VisualNovelGame.Models;
using VisualNovelGame.Services;
using VisualNovelGame.Services.Interfaces;
using VisualNovelGame.ViewModels;
using VisualNovelGame.ViewModels.SystemControlViewModel;
using VisualNovelGame.Views;
using VisualNovelGameDB.Services;
using VisualNovelGameDB.Services.IServices;

namespace VisualNovelGame
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // 注册服务
            containerRegistry.RegisterSingleton<IEventAggregator, EventAggregator>();
            containerRegistry.RegisterSingleton<IRegionManager, RegionManager>();
            //containerRegistry.RegisterSingleton<IWindowService, WindowService>();
            containerRegistry.RegisterSingleton<IWindowSizeService, WindowSizeService>();
            containerRegistry.RegisterSingleton<ISystemSettingsService, SystemSettingsService>();
            containerRegistry.RegisterSingleton<IUserHabitService, UserHabitService>();
            containerRegistry.RegisterSingleton<IVNCService, VNCService>();
            containerRegistry.RegisterSingleton<IUIStringsService, UIStringsService>();



            // 注册视图
            containerRegistry.RegisterForNavigation<SystemControl>("System");
            containerRegistry.RegisterForNavigation<SystemSettingsView>();
            containerRegistry.RegisterForNavigation<MainView>();
            containerRegistry.RegisterForNavigation<IndexView>();
            containerRegistry.RegisterForNavigation<IndexControl>();
            containerRegistry.RegisterForNavigation<MainWindow>();
            containerRegistry.RegisterForNavigation<GameView>();
            containerRegistry.RegisterForNavigation<GameControl>();
            containerRegistry.RegisterForNavigation<Header>();
            containerRegistry.RegisterForNavigation<Body>();
            containerRegistry.RegisterForNavigation<Footer>();
            //System-Body的视图
            //containerRegistry.RegisterForNavigation<Basic>();
            containerRegistry.RegisterForNavigation<Display>();
            containerRegistry.RegisterForNavigation<General1>();
            containerRegistry.RegisterForNavigation<General2>();
            containerRegistry.RegisterForNavigation<Text>();
            containerRegistry.RegisterForNavigation<Sound>();
            containerRegistry.RegisterForNavigation<Dialog>();
            containerRegistry.RegisterForNavigation<Mouse>();
            containerRegistry.RegisterForNavigation<Keyboard>();
            containerRegistry.RegisterForNavigation<Gamepad>();
            containerRegistry.RegisterForNavigation<Basic>();



            // 注册ViewModel
            containerRegistry.Register<IndexControlViewModel>();
            containerRegistry.Register<BodyViewModel>();
            containerRegistry.Register<GameControlViewModel>();
            containerRegistry.Register<SystemControlViewModel>();
            containerRegistry.Register<HeaderViewModel>();
            containerRegistry.Register<SystemSettingsViewModel>();
            containerRegistry.Register<BasicViewModel>();
            containerRegistry.Register<DialogViewModel>();
            containerRegistry.Register<DialogViewModel>();
            containerRegistry.Register<General2ViewModel>();
            containerRegistry.Register<TextViewModel>();
            containerRegistry.Register<SoundViewModel>();
            containerRegistry.Register<FooterViewModel>();

            // 注册区域
            var regionManager = containerRegistry.GetContainer().Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("SystemSettings_HeaderRegion", typeof(Header));
            regionManager.RegisterViewWithRegion("SystemSettings_BodyRegion", typeof(Body));
            regionManager.RegisterViewWithRegion("SystemSettings_FooterRegion", typeof(Footer));
            regionManager.RegisterViewWithRegion("GameViewRegion", typeof(GameControl));
            regionManager.RegisterViewWithRegion("IndexViewRegion", typeof(IndexControl));
            regionManager.RegisterViewWithRegion("MainViewRegion", typeof(IndexView));
            regionManager.RegisterViewWithRegion("MainWindowRegion", typeof(MainView));
            regionManager.RegisterViewWithRegion("SystemSettingsViewRegion", typeof(SystemControl));


            containerRegistry.Register<Header>();
            containerRegistry.Register<Body>();
            containerRegistry.Register<Footer>();
            containerRegistry.Register<GameControl>();
        }
    }
}
