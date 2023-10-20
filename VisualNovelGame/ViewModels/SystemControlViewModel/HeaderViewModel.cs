using Newtonsoft.Json.Linq;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace VisualNovelGame.ViewModels.SystemControlViewModel
{
    public class HeaderViewModel : BindableBase
    {
        // 保存Header页面中选择的单选项
        private string _selectedSetting;
        public string SelectedSetting
        {
            get { return _selectedSetting; }
            set
            {
                SetProperty(ref _selectedSetting, value);

                // 保存到用户设定的逻辑
                SaveSelectedSetting(value);
            }

        }

        // 服务
        private readonly IRegionManager _regionManager;

        // 委托
        private DelegateCommand<object> _bodyViewCommand;
        public DelegateCommand<object> BodyViewCommand =>
            _bodyViewCommand ?? (_bodyViewCommand = new DelegateCommand<object>(ExecuteBodyViewCommand));

        // 构造函数
        public HeaderViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;

            
            LoadSelectedSetting();
        }

        /// <summary>
        /// 每次进入Header时加载上次选择的项
        /// </summary>
        private void LoadSelectedSetting()
        {
            SelectedSetting = Properties.Settings.Default.HeaderDefault;
            ExecuteBodyViewCommand(SelectedSetting);
        }

        /// <summary>
        /// 将单选项选择的项保存到设置中，并作为导航参数传递
        /// </summary>
        /// <param name="obj"></param>
        private void ExecuteBodyViewCommand(object obj)
        {
            SelectedSetting = obj as string;
            _regionManager.RequestNavigate("SystemSettings_BodyRegion", SelectedSetting);
        }

        /// <summary>
        /// 保存选择的单选项到配置中
        /// </summary>
        /// <param name="value"></param>
        private void SaveSelectedSetting(string value)
        {
            Properties.Settings.Default.HeaderDefault = SelectedSetting;
            Properties.Settings.Default.Save();
        }
    }
}
