using Prism.Commands;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using VisualNovelGame.Views;

namespace VisualNovelGame.ViewModels
{
    public class SystemSettingsViewModel : INavigationAware
    {
        // 服务
        private readonly IRegionManager _regionManager;

        // 委托
        public DelegateCommand RightClickEvent { get; private set; }

        // 构造函数
        public SystemSettingsViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;

            RightClickEvent = new DelegateCommand(ExecuteRightClickEvent);
        }

        // 导航参数
        public string returnRegion { get; private set; }
        public string returnView { get; private set; }

        // 右键返回上一个视图
        private void ExecuteRightClickEvent()
        {
            _regionManager.RequestNavigate(returnRegion, returnView);
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            //return false;
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {

        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            returnRegion = navigationContext.Parameters["ReturnRegion"] as string;
            returnView = navigationContext.Parameters["ReturnView"] as string;
        }

        public bool KeepAlive
        {
            get { return false; }
        }
    }
}
