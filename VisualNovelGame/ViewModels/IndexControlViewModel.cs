using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Provider;
using VisualNovelGame.Controls;

namespace VisualNovelGame.ViewModels
{
    public class IndexControlViewModel : BindableBase
    {
        // 服务
        private readonly IRegionManager _regionManager;

        public ObservableCollection<ButtonModel> Buttons { get; set; }
        private DelegateCommand<string> _indexTogoCommand;
        public DelegateCommand<string> IndexTogoCommand =>
            _indexTogoCommand ?? (_indexTogoCommand = new DelegateCommand<string>(ExecuteIndexTogoCommand));

        public class ButtonModel
        {
            public string Content { get; set; }
            public string CommandParameter { get; set; }
        }


        // 构造函数
        public IndexControlViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;

            Buttons = new ObservableCollection<ButtonModel>
            {
                new ButtonModel { Content = "序章", CommandParameter = "Prologue" },
                new ButtonModel { Content = "新游戏", CommandParameter = "NewGame" },
                new ButtonModel { Content = "读取存档", CommandParameter = "Load" },
                new ButtonModel { Content = "继续游戏", CommandParameter = "Continue" },
                new ButtonModel { Content = "流程图", CommandParameter = "Flowchart" },
                new ButtonModel { Content = "鉴赏模式", CommandParameter = "Extra" },
                new ButtonModel { Content = "后日谈", CommandParameter = "After" },
                new ButtonModel { Content = "系统设置", CommandParameter = "System" },
                new ButtonModel { Content = "结束游戏", CommandParameter = "Quit" },
                new ButtonModel { Content = "Simplified Chinese", CommandParameter = "Language" },
            };
        }

        // 首页按钮点击事件
        private void ExecuteIndexTogoCommand(string page)
        {
            if (page == "Prologue")
            {

            }
            else if (page == "NewGame")
            {
                // 开始游戏
                // 使MainView清空所有视图并导航到GameView
                var parameters = new NavigationParameters();
                parameters.Add("ReturnRegion", "IndexViewRegion");
                parameters.Add("ReturnView", "IndexControl");
                _regionManager.RequestNavigate("MainViewRegion", "GameView", parameters);
            }
            else if (page == "Load")
            {

            }
            else if (page == "Continue")
            {

            }
            else if (page == "FlowChart")
            {

            }
            else if (page == "Extra")
            {

            }
            else if (page == "After")
            {

            }
            else if (page == "System")
            {
                // 系统
                // 使IndexView导航至SystemSettings
                var parameters = new NavigationParameters();
                parameters.Add("ReturnRegion", "IndexViewRegion");
                parameters.Add("ReturnView", "IndexControl");
                _regionManager.RequestNavigate("IndexViewRegion", "SystemSettingsView", parameters);
            }
            else if (page == "Quit")
            {

            }
            else if (page == "Language")
            {

            }
        }


    }
}
