using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Prism.Commands;
using Prism.Common;
using Prism.Events;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using VisualNovelGame.Common;
using VisualNovelGame.Events;
using VisualNovelGame.Events.EventArgs;
using VisualNovelGame.Services.Interfaces;
using static VisualNovelGame.Models.BodyModel;

namespace VisualNovelGame.ViewModels
{
    public class BodyViewModel : BindableBase
    {
        private readonly IEventAggregator _eventAggregator;
        private readonly IWindowSizeService _windowSizeService;
        private readonly ISystemSettingsService _systemSettingsService;

        public DelegateCommand<string> WindowSizeCommand { get; private set; }
        public DelegateCommand<bool> AspectRatio { get; private set; }

        private dynamic Result;

        private bool _isMaximized;
        public bool IsMaximized
        {
            get { return _isMaximized; }
            set
            {
                SetProperty(ref _isMaximized, value);
            }
        }

        // Settings字段
        private SystemSettings _settings;
        // Settings属性
        public SystemSettings Settings
        {
            get { return _settings; }
            set { SetProperty(ref _settings, value); }
        }

        // 测试
        public class RadioButtonViewModel
        {
            public string Content { get; set; }
            public DelegateCommand<bool?> DelegateCommand { get; set; }
            public bool CommandParameter { get; set; }
            public bool IsChecked { get; set; }
            public string GroupName { get; set; }
        }

        public class WindowSizeButtonViewModel
        {
            public string Content { get; set; }
            public DelegateCommand<string> DelegateCommand { get; set; }
            public string CommandParameter { get; set; }
            public bool IsChecked { get; set; }
            public string GroupName { get; set; }
        }

        public ObservableCollection<RadioButtonViewModel> RadioButtons { get; set; }
        public ObservableCollection<WindowSizeButtonViewModel> WindowSizeButtons { get; set; }

        //public ObservableCollection<ObservableCollection<RadioButtonViewModel>> SystemRadioButtons { get; set; }

        // 构造函数
        public BodyViewModel(IEventAggregator eventAggregator, IWindowSizeService windowSizeService, ISystemSettingsService systemSettingsService)
        { 
            WindowSizeCommand = new DelegateCommand<string>(ExecuteWindowSizeCommand);
            //AspectRatio = new DelegateCommand<bool>(ExecuteAspectRatioCommand);

            _eventAggregator = eventAggregator;
            _windowSizeService = windowSizeService;
            _systemSettingsService = systemSettingsService;

            // 测试
            //SystemRadioButtons = new ObservableCollection<ObservableCollection<RadioButtonViewModel>>();
            RadioButtons = new ObservableCollection<RadioButtonViewModel>();
            var delegateCommand = new DelegateCommand<bool?>(ceshiceshila);
            RadioButtons.Add(new RadioButtonViewModel { Content = "选择2", DelegateCommand = delegateCommand, CommandParameter = false, GroupName="ceshi", IsChecked = false });
            RadioButtons.Add(new RadioButtonViewModel { Content = "选择1", DelegateCommand = delegateCommand, CommandParameter = true, GroupName="ceshi", IsChecked = false });
            //SystemRadioButtons.Add(RadioButtons);

            WindowSizeButtons = new ObservableCollection<WindowSizeButtonViewModel>();
            WindowSizeButtons.Add(new WindowSizeButtonViewModel { Content = "窗口", DelegateCommand = WindowSizeCommand, CommandParameter = "Screen", GroupName = "WindowSize", IsChecked = false });
            WindowSizeButtons.Add(new WindowSizeButtonViewModel { Content = "全屏", DelegateCommand = WindowSizeCommand, CommandParameter = "FullScreen", GroupName = "WindowSize", IsChecked = false });
        }

        private void ceshiceshila(bool? obj)
        {
            if (obj == true)
            {

            }
            else
            {

            }
        }

        private void ExecuteAspectRatioCommand(bool obj)
        {
            _systemSettingsService.SaveAspectRatio(obj);
        }

        // 屏幕大小按钮事件
        private void ExecuteWindowSizeCommand(string type)
        {
           if (type == "FullScreen")
            {
                //var args = WindowSizeArgsFactory.Create(true);
                //_eventAggregator.GetEvent<WindowSizeEvent>().Publish(args);
                _windowSizeService.SetWindowSizeMax();
            }
           else if (type == "Screen")
            {
                //var args = WindowSizeArgsFactory.Create(false, );
                //_eventAggregator.GetEvent<WindowSizeEvent>().Publish(args);
                var args = _windowSizeService.GetWindowSizeFromSystemSettings();
                args.Width = Application.Current.MainWindow.Width;
                args.Height = Application.Current.MainWindow.Height;
                _windowSizeService.SetWindowSize(args);
            }
        }

    }
}



